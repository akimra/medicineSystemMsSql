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
    public partial class FormAdministratorCreatePacient : Form
    {
        FormAdministrator parentForm;
        public FormAdministratorCreatePacient(FormAdministrator f)
        {
            InitializeComponent();
            parentForm = f;
        }
    }
}
