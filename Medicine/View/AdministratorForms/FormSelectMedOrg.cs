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
    public partial class FormSelectMedOrg : Form
    {
        MainController control = new MainController();
        private FormCreateDoctor parentForm;
        public FormSelectMedOrg(FormCreateDoctor f)
        {
            parentForm = f;
            InitializeComponent();
        }

        private void FormSelectMedOrg_Load(object sender, EventArgs e)
        {
            this.medOrganizationsTableAdapter.Fill(this.medicinedbDataSet.MedOrganizations);
        }

        private void ButtonSelectMedOrg_Click(object sender, EventArgs e)
        {
            int row = dataGridViewSelectMedOrg.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridViewSelectMedOrg.Rows[row].Cells[0].Value);
            MedOrganization org = control.GetMedOrgById(id);
            parentForm.SetSelectedMedOrg(org);
            Close();
        }
    }
}
