using Medicine.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medicine.Model;

namespace Medicine.View.AdministratorForms
{
    public partial class FormCreateDoctor : Form
    {
        private MainController control = new MainController();
        private MedOrganization selectedOrg;
        private Form parentForm;

        public void SetSelectedMedOrg(MedOrganization org)
        {
            selectedOrg = org;
            textBoxCreateDocMedOrg.Text = org.Name;
        }

        public FormCreateDoctor(Form f)
        {
            parentForm = f;
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSelectMedOrg_Click(object sender, EventArgs e)
        {
            FormSelectMedOrg form = new FormSelectMedOrg(this);
            form.Show();
            form.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (selectedOrg == null)
            {
                MessageBox.Show("Выберите организацию");
            }
            else
            {
                string hashPass = control.GetHash(textBoxCreateDocPassword.Text);

                Doctor dr = new Doctor
                {
                    Auth = new DoctorAuth
                    {
                        Login = textBoxCreateDocLogin.Text,
                        Password = hashPass
                    },
                    Fio = textBoxCreateDocFio.Text,
                    Speciality = textBoxCreateDocSpeciality.Text,
                    Room = Convert.ToInt32(textBoxCreateDocRoom.Text),
                    MedOrganizationId = selectedOrg.Id
                };
                control.CreateDoctor(dr);
                FormAdministrator pform = (FormAdministrator)parentForm;
                pform.UpdateDataBindings();
                Close();
            }
        }

        private void FormCreateDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }
    }
}
