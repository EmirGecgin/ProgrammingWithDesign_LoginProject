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
    
    public partial class FormForgot : Form
    {
        public int userId;
        UserManager userManager;
        public FormForgot()
        {
            userManager=UserManager.GetInstance();
            InitializeComponent();
            
        }

        private void FormForgot_Load(object sender, EventArgs e)
        {
            TxtQuestion.Text = userManager.GetQuestionByUserId(userId);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (TxtAnswer.Text.Trim() == "")
            {
                MessageBox.Show("Gizli cevabı yazınız!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool control =userManager.ControlAnswer(userId, TxtAnswer.Text);
            if(control)
            {
                groupBox1.Enabled = true;
            }
            if (!control)
            {
                MessageBox.Show("Gizli cevabı yanlış!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void BtnUpdatePassword_Click(object sender, EventArgs e)
        {
            if(TxtPassword.Text.Trim()=="" && TxtPassword2.Text.Trim() == "")
            {
                MessageBox.Show("Şifre Bilgilerini eksiksiz girin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TxtPassword.Text.Trim() != TxtPassword2.Text.Trim())
            {
                MessageBox.Show("Şifre Bilgilerini doğru girin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show(userManager.UpdatePassword(userId, TxtPassword.Text));
            Close();    
        }
    }
}
