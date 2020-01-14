using Medicine.Controller;
using Medicine.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicine.View.AdministratorForms
{
    public partial class FormCreatePacient : Form
    {
        private string action;
        private int targetId;
        MainController control = new MainController();
        Form parentForm;
        public FormCreatePacient(Form f, string act = "create", int target = -1)
        {
            action = act;
            targetId = target;
            parentForm = f;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pacient pac = new Pacient
            {
                Auth = new PacientAuth
                {
                    Login = textBoxCreatePacientLogin.Text,
                    Password = control.GetHash(textBoxCreatePacientPassword.Text)
                },
                Fio = textBoxCreatePacientFio.Text,
                Passport = textBoxCreatePacientPassport.Text,
                Oms = textBoxCreatePacientOms.Text,
                Phone = textBoxCreatePacientNumber.Text,
                Address = textBoxCreatePacientAddress.Text,
                Job = textBoxCreatePacientJob.Text,
                Position = textBoxCreatePacientPosition.Text
            };

            if (action == "update")
            {
                if (targetId >= 0)
                {
                    control.UpdatePacient(pac, targetId);
                }
                else
                {
                    MessageBox.Show("Выберите изменяемую запись");
                }
            }
            else
            {
                control.CreatePacient(pac);
            }
            FormAdministrator form = (FormAdministrator)parentForm;
            form.UpdateDataBindings();
            Close();
        }

        private void FormAdministratorCreatePacient_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }
    }
}
