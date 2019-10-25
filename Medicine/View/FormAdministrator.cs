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
    }
}
