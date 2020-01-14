namespace Medicine.View.AdministratorForms
{
    partial class FormCreateDoctor
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCreateDocFio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCreateDocRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCreateDocMedOrg = new System.Windows.Forms.TextBox();
            this.buttonSelectMedOrg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCreateDocLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCreateDocPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCreateDocSpeciality = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите фамилию, имя, отчество";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBoxCreateDocFio
            // 
            this.textBoxCreateDocFio.Location = new System.Drawing.Point(16, 34);
            this.textBoxCreateDocFio.Name = "textBoxCreateDocFio";
            this.textBoxCreateDocFio.Size = new System.Drawing.Size(820, 22);
            this.textBoxCreateDocFio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите специализацию (направление деятельности)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите номер кабинета";
            // 
            // textBoxCreateDocRoom
            // 
            this.textBoxCreateDocRoom.Location = new System.Drawing.Point(413, 89);
            this.textBoxCreateDocRoom.Name = "textBoxCreateDocRoom";
            this.textBoxCreateDocRoom.Size = new System.Drawing.Size(171, 22);
            this.textBoxCreateDocRoom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Выберите медицинскую организацию";
            // 
            // textBoxCreateDocMedOrg
            // 
            this.textBoxCreateDocMedOrg.Location = new System.Drawing.Point(16, 151);
            this.textBoxCreateDocMedOrg.Name = "textBoxCreateDocMedOrg";
            this.textBoxCreateDocMedOrg.ReadOnly = true;
            this.textBoxCreateDocMedOrg.Size = new System.Drawing.Size(568, 22);
            this.textBoxCreateDocMedOrg.TabIndex = 7;
            // 
            // buttonSelectMedOrg
            // 
            this.buttonSelectMedOrg.Location = new System.Drawing.Point(590, 148);
            this.buttonSelectMedOrg.Name = "buttonSelectMedOrg";
            this.buttonSelectMedOrg.Size = new System.Drawing.Size(246, 28);
            this.buttonSelectMedOrg.TabIndex = 8;
            this.buttonSelectMedOrg.Text = "Выбрать...";
            this.buttonSelectMedOrg.UseVisualStyleBackColor = true;
            this.buttonSelectMedOrg.Click += new System.EventHandler(this.ButtonSelectMedOrg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите логин для авторизации";
            // 
            // textBoxCreateDocLogin
            // 
            this.textBoxCreateDocLogin.Location = new System.Drawing.Point(16, 247);
            this.textBoxCreateDocLogin.Name = "textBoxCreateDocLogin";
            this.textBoxCreateDocLogin.Size = new System.Drawing.Size(281, 22);
            this.textBoxCreateDocLogin.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите пароль для авторизации";
            // 
            // textBoxCreateDocPassword
            // 
            this.textBoxCreateDocPassword.Location = new System.Drawing.Point(16, 322);
            this.textBoxCreateDocPassword.Name = "textBoxCreateDocPassword";
            this.textBoxCreateDocPassword.PasswordChar = '*';
            this.textBoxCreateDocPassword.Size = new System.Drawing.Size(281, 22);
            this.textBoxCreateDocPassword.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(823, 61);
            this.button1.TabIndex = 13;
            this.button1.Text = "Создать/изменить данные врача";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxCreateDocSpeciality
            // 
            this.textBoxCreateDocSpeciality.Location = new System.Drawing.Point(16, 89);
            this.textBoxCreateDocSpeciality.Name = "textBoxCreateDocSpeciality";
            this.textBoxCreateDocSpeciality.Size = new System.Drawing.Size(365, 22);
            this.textBoxCreateDocSpeciality.TabIndex = 3;
            // 
            // FormCreateDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCreateDocPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCreateDocLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSelectMedOrg);
            this.Controls.Add(this.textBoxCreateDocMedOrg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCreateDocRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCreateDocSpeciality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCreateDocFio);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateDoctor";
            this.Text = "FormCreateDoctor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCreateDoctor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCreateDocFio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCreateDocRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCreateDocMedOrg;
        private System.Windows.Forms.Button buttonSelectMedOrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCreateDocLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCreateDocPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCreateDocSpeciality;
    }
}