namespace Medicine.View.AdministratorForms
{
    partial class FormSelectMedOrg
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewSelectMedOrg = new System.Windows.Forms.DataGridView();
            this.medicinedbDataSet = new Medicine.MedicinedbDataSet();
            this.medOrganizationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medOrganizationsTableAdapter = new Medicine.MedicinedbDataSetTableAdapters.MedOrganizationsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSelectMedOrg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectMedOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinedbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOrganizationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSelectMedOrg
            // 
            this.dataGridViewSelectMedOrg.AllowUserToAddRows = false;
            this.dataGridViewSelectMedOrg.AllowUserToDeleteRows = false;
            this.dataGridViewSelectMedOrg.AutoGenerateColumns = false;
            this.dataGridViewSelectMedOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectMedOrg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewSelectMedOrg.DataSource = this.medOrganizationsBindingSource;
            this.dataGridViewSelectMedOrg.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewSelectMedOrg.MultiSelect = false;
            this.dataGridViewSelectMedOrg.Name = "dataGridViewSelectMedOrg";
            this.dataGridViewSelectMedOrg.ReadOnly = true;
            this.dataGridViewSelectMedOrg.RowHeadersWidth = 51;
            this.dataGridViewSelectMedOrg.RowTemplate.Height = 24;
            this.dataGridViewSelectMedOrg.Size = new System.Drawing.Size(675, 350);
            this.dataGridViewSelectMedOrg.TabIndex = 0;
            // 
            // medicinedbDataSet
            // 
            this.medicinedbDataSet.DataSetName = "MedicinedbDataSet";
            this.medicinedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medOrganizationsBindingSource
            // 
            this.medOrganizationsBindingSource.DataMember = "MedOrganizations";
            this.medOrganizationsBindingSource.DataSource = this.medicinedbDataSet;
            // 
            // medOrganizationsTableAdapter
            // 
            this.medOrganizationsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // buttonSelectMedOrg
            // 
            this.buttonSelectMedOrg.Location = new System.Drawing.Point(13, 370);
            this.buttonSelectMedOrg.Name = "buttonSelectMedOrg";
            this.buttonSelectMedOrg.Size = new System.Drawing.Size(675, 68);
            this.buttonSelectMedOrg.TabIndex = 1;
            this.buttonSelectMedOrg.Text = "Выбрать";
            this.buttonSelectMedOrg.UseVisualStyleBackColor = true;
            this.buttonSelectMedOrg.Click += new System.EventHandler(this.ButtonSelectMedOrg_Click);
            // 
            // FormSelectMedOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.buttonSelectMedOrg);
            this.Controls.Add(this.dataGridViewSelectMedOrg);
            this.Name = "FormSelectMedOrg";
            this.Text = "FormSelectMedOrg";
            this.Load += new System.EventHandler(this.FormSelectMedOrg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectMedOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOrganizationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSelectMedOrg;
        private MedicinedbDataSet medicinedbDataSet;
        private System.Windows.Forms.BindingSource medOrganizationsBindingSource;
        private MedicinedbDataSetTableAdapters.MedOrganizationsTableAdapter medOrganizationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSelectMedOrg;
    }
}