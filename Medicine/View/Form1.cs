using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medicine.Model;
using Medicine.Controller;
using Medicine.View;

namespace Medicine
{
    public partial class Form1 : Form
    {
        public string GetHash(string input)
        {
            byte[] hash;
            using (var md5 = MD5.Create())
            {
                hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            }

            return Convert.ToBase64String(hash);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string loginAuth = textBoxAuthLogin.Text;
            string passwordAuth = GetHash(textBoxAuthPassword.Text);
            textBoxAuthLogin.Clear();
            textBoxAuthPassword.Clear();
            using (MedicineDbContext db = new MedicineDbContext())
            {
                List<IAuthProfile> authList = new List<IAuthProfile>();
                IAuthProfile target = null;
                authList.AddRange(db.Administrators);
                authList.AddRange(db.PacientAuths);
                authList.AddRange(db.DoctorAuths);
                foreach (var a in authList)
                {
                    if (a.GetLogin() == loginAuth && a.GetHashPassword() == passwordAuth)
                    {
                        target = a;
                        break;
                    }
                }
                if (target == null)
                {
                    MessageBox.Show("Такого пользователя не существует");
                }
                else
                {
                    switch (target.GetTypeAuth())
                    {
                        case "administrator":
                            MessageBox.Show("зашел админ");
                            FormAdministrator form = new FormAdministrator(this);
                            Hide();
                            form.Show();
                            break;
                        case "pacient":
                            MessageBox.Show("zashel pacient");
                            break;
                        case "doctor":
                            MessageBox.Show("zashel doc");
                            break;
                        default:
                            MessageBox.Show("Что-то пошло не так");
                            break;
                    }
                        
                }
            }
        }
    }
}
