using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medicine.View.AdministratorForms;

namespace Medicine.View
{
    public partial class FormAdministrator : Form
    {
        private Form1 parentForm;
        public FormAdministrator(Form1 f)
        {
            InitializeComponent();
            parentForm = f;
        }

        private void FormAdministrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void FormAdministrator_Load(object sender, EventArgs e)
        {
            UpdateDataBindings();
        }

        private void UpdateDataBindings()
        {
            this.administratorsTableAdapter.Fill(this.medicinedbDataSet.Administrators);
            this.medServicesTableAdapter.Fill(this.medicinedbDataSet.MedServices);
            this.medOrganizationsTableAdapter.Fill(this.medicinedbDataSet.MedOrganizations);
            this.doctorsTableAdapter.Fill(this.medicinedbDataSet.Doctors);
            this.pacientsTableAdapter.Fill(this.medicinedbDataSet.Pacients);
        }

        private void ButtonCreatePacient_Click(object sender, EventArgs e)
        {
            Form createPacientForm = new FormAdministratorCreatePacient(this);
            Hide();
            createPacientForm.Show();
            createPacientForm.Enabled = true;
        }
    }
}
