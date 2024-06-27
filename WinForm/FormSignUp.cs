using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormSignUp : Form
    {
        UserManager userManager;
        public FormSignUp()
        {
            userManager=UserManager.GetInstance();
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text!=TxtPassword2.Text)
            {
                MessageBox.Show("Şifre Bilgileri Birbirleriyle Uyuşmuyorlar!");
                return;
            }
            User user = new User(TxtUsername.Text,TxtPassword.Text,TxtQuestion.Text,TxtAnswer.Text);
            MessageBox.Show(userManager.AddUser(user));
            string username= TxtUsername.Text;
            var formLogin = (FormLogin) Application.OpenForms["FormLogin"];
            formLogin.TxtUsername.Text = username;
            Close();
        }   
    }
}
