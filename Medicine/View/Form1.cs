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
        private MainController control = new MainController();
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
            textBoxAuthPassword.Clear();
            textBoxAuthLogin.Clear();
            string authResult = control.Authorize(loginAuth, passwordAuth); //возвращается тип авторизованного пользователя
            switch (authResult)
            {
                case "administrator":
                    FormAdministrator form = new FormAdministrator(this);
                    Hide();
                    form.Show();
                    form.Enabled = true;
                    break;
                case "pacient":
                    MessageBox.Show("zashel pacient");
                    break;
                case "doctor":
                    MessageBox.Show("zashel doc");
                    break;
                case "not found":
                    MessageBox.Show("Пользователь с таким паролем и/или логином не найден");
                    break;
                default:
                    MessageBox.Show("Что-то пошло не так");
                    break;
            }
        }
    }
}
