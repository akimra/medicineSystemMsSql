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

        private void FormAdministrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void FormAdministrator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicinedbDataSet.Administrators". При необходимости она может быть перемещена или удалена.
            this.administratorsTableAdapter.Fill(this.medicinedbDataSet.Administrators);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicinedbDataSet.MedServices". При необходимости она может быть перемещена или удалена.
            this.medServicesTableAdapter.Fill(this.medicinedbDataSet.MedServices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicinedbDataSet.MedOrganizations". При необходимости она может быть перемещена или удалена.
            this.medOrganizationsTableAdapter.Fill(this.medicinedbDataSet.MedOrganizations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicinedbDataSet.Doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter.Fill(this.medicinedbDataSet.Doctors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicinedbDataSet.Pacients". При необходимости она может быть перемещена или удалена.
            this.pacientsTableAdapter.Fill(this.medicinedbDataSet.Pacients);

        }
    }
}
