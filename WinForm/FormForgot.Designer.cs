namespace WinForm
{
    partial class FormForgot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPassword2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.BtnUpdatePassword = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(49, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Gizli Cevap:";
            // 
            // TxtAnswer
            // 
            this.TxtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAnswer.Location = new System.Drawing.Point(190, 82);
            this.TxtAnswer.Name = "TxtAnswer";
            this.TxtAnswer.Size = new System.Drawing.Size(220, 30);
            this.TxtAnswer.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gizli Soru:";
            // 
            // TxtQuestion
            // 
            this.TxtQuestion.Enabled = false;
            this.TxtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtQuestion.Location = new System.Drawing.Point(190, 25);
            this.TxtQuestion.Name = "TxtQuestion";
            this.TxtQuestion.Size = new System.Drawing.Size(220, 30);
            this.TxtQuestion.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // TxtPassword2
            // 
            this.TxtPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword2.Location = new System.Drawing.Point(161, 89);
            this.TxtPassword2.Name = "TxtPassword2";
            this.TxtPassword2.Size = new System.Drawing.Size(220, 30);
            this.TxtPassword2.TabIndex = 16;
            this.TxtPassword2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yeni Şifre:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.Location = new System.Drawing.Point(161, 35);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(220, 30);
            this.TxtPassword.TabIndex = 14;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignUp.Location = new System.Drawing.Point(190, 138);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(220, 39);
            this.btnSignUp.TabIndex = 22;
            this.btnSignUp.Text = "Cevabı Kontrol Et";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // BtnUpdatePassword
            // 
            this.BtnUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdatePassword.Location = new System.Drawing.Point(161, 140);
            this.BtnUpdatePassword.Name = "BtnUpdatePassword";
            this.BtnUpdatePassword.Size = new System.Drawing.Size(220, 39);
            this.BtnUpdatePassword.TabIndex = 23;
            this.BtnUpdatePassword.Text = "Şifreyi Güncelle";
            this.BtnUpdatePassword.UseVisualStyleBackColor = true;
            this.BtnUpdatePassword.Click += new System.EventHandler(this.BtnUpdatePassword_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtPassword2);
            this.groupBox1.Controls.Add(this.BtnUpdatePassword);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(33, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 204);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre İşlemleri";
            // 
            // FormForgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtQuestion);
            this.Name = "FormForgot";
            this.Text = "FormForgot";
            this.Load += new System.EventHandler(this.FormForgot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPassword2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button BtnUpdatePassword;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}