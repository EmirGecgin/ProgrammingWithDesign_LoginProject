namespace WinForm
{
    partial class FormLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
            this.LnkSignUp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUsername.Location = new System.Drawing.Point(170, 210);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(220, 30);
            this.TxtUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.Location = new System.Drawing.Point(170, 259);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(220, 30);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(170, 307);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(220, 39);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkForgot
            // 
            this.lnkForgot.AutoSize = true;
            this.lnkForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkForgot.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkForgot.Location = new System.Drawing.Point(221, 398);
            this.lnkForgot.Name = "lnkForgot";
            this.lnkForgot.Size = new System.Drawing.Size(114, 18);
            this.lnkForgot.TabIndex = 6;
            this.lnkForgot.TabStop = true;
            this.lnkForgot.Text = "Şifremi Unuttum";
            this.lnkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForgot_LinkClicked);
            // 
            // LnkSignUp
            // 
            this.LnkSignUp.AutoSize = true;
            this.LnkSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkSignUp.Location = new System.Drawing.Point(247, 365);
            this.LnkSignUp.Name = "LnkSignUp";
            this.LnkSignUp.Size = new System.Drawing.Size(53, 18);
            this.LnkSignUp.TabIndex = 7;
            this.LnkSignUp.TabStop = true;
            this.LnkSignUp.Text = "Kaydol";
            this.LnkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSignUp_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 468);
            this.Controls.Add(this.LnkSignUp);
            this.Controls.Add(this.lnkForgot);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUsername);
            this.DoubleBuffered = true;
            this.Name = "FormLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private System.Windows.Forms.LinkLabel LnkSignUp;
        public System.Windows.Forms.TextBox TxtUsername;
    }
}

