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
    public partial class FormLogin : Form
    {
        UserManager usermanager;
        public FormLogin()
        {
            usermanager = UserManager.GetInstance();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(usermanager.LoginControl(TxtUsername.Text,TxtPassword.Text))
            {
                MessageBox.Show("Giriş Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDashboard formDashboard = new FormDashboard();
                formDashboard.username = TxtUsername.Text;
                formDashboard.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız ve şifre hatalı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.ShowDialog();
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (TxtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Kullanıcı adını giriniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            int userId=usermanager.GetUserIdByUsername(TxtUsername.Text.Trim());
            if (userId < 1)
            {
                MessageBox.Show("Kullanıcı adınızı hatalı girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            FormForgot formForgot = new FormForgot();
            formForgot.userId=userId;
            formForgot.ShowDialog();
        }
    }
}
