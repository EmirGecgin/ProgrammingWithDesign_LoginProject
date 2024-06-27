namespace WinForm
{
    partial class FormSignUp
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPassword2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtQuestion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAnswer = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(129, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.Location = new System.Drawing.Point(204, 112);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(220, 30);
            this.TxtPassword.TabIndex = 6;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUsername.Location = new System.Drawing.Point(204, 63);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(220, 30);
            this.TxtUsername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // TxtPassword2
            // 
            this.TxtPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword2.Location = new System.Drawing.Point(204, 166);
            this.TxtPassword2.Name = "TxtPassword2";
            this.TxtPassword2.Size = new System.Drawing.Size(220, 30);
            this.TxtPassword2.TabIndex = 8;
            this.TxtPassword2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(80, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gizli Soru:";
            // 
            // TxtQuestion
            // 
            this.TxtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtQuestion.Location = new System.Drawing.Point(204, 221);
            this.TxtQuestion.Name = "TxtQuestion";
            this.TxtQuestion.Size = new System.Drawing.Size(220, 30);
            this.TxtQuestion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(63, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gizli Cevap:";
            // 
            // TxtAnswer
            // 
            this.TxtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAnswer.Location = new System.Drawing.Point(204, 278);
            this.TxtAnswer.Name = "TxtAnswer";
            this.TxtAnswer.Size = new System.Drawing.Size(220, 30);
            this.TxtAnswer.TabIndex = 12;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignUp.Location = new System.Drawing.Point(204, 337);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(220, 39);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.Text = "Kaydol";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(494, 451);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPassword2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUsername);
            this.Name = "FormSignUp";
            this.Text = "FormSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPassword2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAnswer;
        private System.Windows.Forms.Button btnSignUp;
    }
}