using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void FormAdministrator_Load(object sender, EventArgs e)
        {
            
            this.resultsTableAdapter.Fill(this.medicinedbDataSet3.Results);
            
            this.medOrganizationsTableAdapter.Fill(this.medicinedbDataSet2.MedOrganizations);
            
            this.medServicesTableAdapter.Fill(this.medicinedbDataSet1.MedServices);
            
            this.doctorsTableAdapter.Fill(this.medicinedbDataSet.Doctors);
            
            this.pacientsTableAdapter.Fill(this.medicinedbDataSetPacients.Pacients);

        }

        private void FormAdministrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void ButtonCreatePacient_Click(object sender, EventArgs e)
        {
            FormAdministratorCreatePacient f = new FormAdministratorCreatePacient(this);
            Hide();
        }
    }
}
