using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medicine.Controller;
using Medicine.View.AdministratorForms;

namespace Medicine.View
{
    public partial class FormAdministrator : Form
    {
        private Form1 parentForm;
        private MainController control = new MainController();
        public FormAdministrator(Form1 f)
        {
            InitializeComponent();
            parentForm = f;
        }

        private void FormAdministrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Close();
        }

        private void FormAdministrator_Load(object sender, EventArgs e)
        {
            UpdateDataBindings();
        }

        public void UpdateDataBindings()
        {
            this.administratorsTableAdapter.Fill(this.medicinedbDataSet.Administrators);
            this.medServicesTableAdapter.Fill(this.medicinedbDataSet.MedServices);
            this.medOrganizationsTableAdapter.Fill(this.medicinedbDataSet.MedOrganizations);
            this.doctorsTableAdapter.Fill(this.medicinedbDataSet.Doctors);
            this.pacientsTableAdapter.Fill(this.medicinedbDataSet.Pacients);
        }

        private void ButtonCreatePacient_Click(object sender, EventArgs e)
        {
            Form createPacientForm = new FormCreatePacient(this, "create");
            Hide();
            createPacientForm.Show();
            createPacientForm.Enabled = true;
        }

        private void ButtonUpdatePacient_Click(object sender, EventArgs e)
        {
            int row = dataGridViewFormAdministratorPacients.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewFormAdministratorPacients.Rows[row].Cells[0].Value);
            Form createPacientForm = new FormCreatePacient(this, "update", id);
            Hide();
            createPacientForm.Show();
            createPacientForm.Enabled = true;
        }

        private void ButtonDeletePacient_Click(object sender, EventArgs e)
        {
            int row = dataGridViewFormAdministratorPacients.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewFormAdministratorPacients.Rows[row].Cells[0].Value);
            control.DeletePacient(id);
            UpdateDataBindings();
        }

        private void ButtonCreateDoctor_Click(object sender, EventArgs e)
        {
            Hide();
            FormCreateDoctor f = new FormCreateDoctor(this);
            f.Show();
            f.Enabled = true;
        }
    }
}
