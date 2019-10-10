namespace Medicine
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAuth = new System.Windows.Forms.Button();
            this.textBoxAuthLogin = new System.Windows.Forms.TextBox();
            this.textBoxAuthPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAuth
            // 
            this.buttonAuth.Location = new System.Drawing.Point(370, 217);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(75, 23);
            this.buttonAuth.TabIndex = 0;
            this.buttonAuth.Text = "Войти";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxAuthLogin
            // 
            this.textBoxAuthLogin.Location = new System.Drawing.Point(117, 102);
            this.textBoxAuthLogin.Name = "textBoxAuthLogin";
            this.textBoxAuthLogin.Size = new System.Drawing.Size(328, 22);
            this.textBoxAuthLogin.TabIndex = 1;
            // 
            // textBoxAuthPassword
            // 
            this.textBoxAuthPassword.Location = new System.Drawing.Point(117, 176);
            this.textBoxAuthPassword.Name = "textBoxAuthPassword";
            this.textBoxAuthPassword.PasswordChar = '*';
            this.textBoxAuthPassword.Size = new System.Drawing.Size(328, 22);
            this.textBoxAuthPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вход";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAuthPassword);
            this.Controls.Add(this.textBoxAuthLogin);
            this.Controls.Add(this.buttonAuth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.TextBox textBoxAuthLogin;
        private System.Windows.Forms.TextBox textBoxAuthPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

