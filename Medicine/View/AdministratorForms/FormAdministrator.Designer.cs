﻿namespace Medicine.View
{
    partial class FormAdministrator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDeletePacient = new System.Windows.Forms.Button();
            this.buttonUpdatePacient = new System.Windows.Forms.Button();
            this.buttonCreatePacient = new System.Windows.Forms.Button();
            this.dataGridViewFormAdministratorPacients = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.omsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinedbDataSet = new Medicine.MedicinedbDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonCreateDoctor = new System.Windows.Forms.Button();
            this.dataGridViewFormAdministratorDoctors = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medOrganizationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewFormAdministratorOrganizations = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medOrganizationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewFormAdministratorServices = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewFormAdministratorAdministrators = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administratorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientsTableAdapter = new Medicine.MedicinedbDataSetTableAdapters.PacientsTableAdapter();
            this.doctorsTableAdapter = new Medicine.MedicinedbDataSetTableAdapters.DoctorsTableAdapter();
            this.medOrganizationsTableAdapter = new Medicine.MedicinedbDataSetTableAdapters.MedOrganizationsTableAdapter();
            this.medServicesTableAdapter = new Medicine.MedicinedbDataSetTableAdapters.MedServicesTableAdapter();
            this.administratorsTableAdapter = new Medicine.MedicinedbDataSetTableAdapters.AdministratorsTableAdapter();
            this.medicinedbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEditDoctor = new System.Windows.Forms.Button();
            this.buttonDeleteDoctor = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormAdministratorPacients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinedbDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormAdministratorDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormAdministratorOrganizations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOrganizationsBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormAdministratorServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medServicesBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormAdministratorAdministrators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinedbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1394, 663);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDeletePacient);
            this.tabPage1.Controls.Add(this.buttonUpdatePacient);
            this.tabPage1.Controls.Add(this.buttonCreatePacient);
            this.tabPage1.Controls.Add(this.dataGridViewFormAdministratorPacients);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1386, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пациенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePacient
            // 
            this.buttonDeletePacient.Location = new System.Drawing.Point(1025, 139);
            this.buttonDeletePacient.Name = "buttonDeletePacient";
            this.buttonDeletePacient.Size = new System.Drawing.Size(355, 63);
            this.buttonDeletePacient.TabIndex = 3;
            this.buttonDeletePacient.Text = "Удалить выбранного пациента";
            this.buttonDeletePacient.UseVisualStyleBackColor = true;
            this.buttonDeletePacient.Click += new System.EventHandler(this.ButtonDeletePacient_Click);
            // 
            // buttonUpdatePacient
            // 
            this.buttonUpdatePacient.Location = new System.Drawing.Point(1026, 74);
            this.buttonUpdatePacient.Name = "buttonUpdatePacient";
            this.buttonUpdatePacient.Size = new System.Drawing.Size(354, 58);
            this.buttonUpdatePacient.TabIndex = 2;
            this.buttonUpdatePacient.Text = "Изменить выбранного пациента";
            this.buttonUpdatePacient.UseVisualStyleBackColor = true;
            this.buttonUpdatePacient.Click += new System.EventHandler(this.ButtonUpdatePacient_Click);
            // 
            // buttonCreatePacient
            // 
            this.buttonCreatePacient.Location = new System.Drawing.Point(1025, 7);
            this.buttonCreatePacient.Name = "buttonCreatePacient";
            this.buttonCreatePacient.Size = new System.Drawing.Size(355, 60);
            this.buttonCreatePacient.TabIndex = 1;
            this.buttonCreatePacient.Text = "Создать нового пациента";
            this.buttonCreatePacient.UseVisualStyleBackColor = true;
            this.buttonCreatePacient.Click += new System.EventHandler(this.ButtonCreatePacient_Click);
            // 
            // dataGridViewFormAdministratorPacients
            // 
            this.dataGridViewFormAdministratorPacients.AllowUserToAddRows = false;
            this.dataGridViewFormAdministratorPacients.AllowUserToDeleteRows = false;
            this.dataGridViewFormAdministratorPacients.AutoGenerateColumns = false;
            this.dataGridViewFormAdministratorPacients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormAdministratorPacients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.omsDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.dataGridViewFormAdministratorPacients.DataSource = this.pacientsBindingSource;
            this.dataGridViewFormAdministratorPacients.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewFormAdministratorPacients.Name = "dataGridViewFormAdministratorPacients";
            this.dataGridViewFormAdministratorPacients.ReadOnly = true;
            this.dataGridViewFormAdministratorPacients.RowHeadersWidth = 51;
            this.dataGridViewFormAdministratorPacients.RowTemplate.Height = 24;
            this.dataGridViewFormAdministratorPacients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFormAdministratorPacients.Size = new System.Drawing.Size(1012, 621);
            this.dataGridViewFormAdministratorPacients.TabIndex = 0;
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
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "Fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Fio";
            this.fioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.Width = 125;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Passport";
            this.passportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportDataGridViewTextBoxColumn.Width = 125;
            // 
            // omsDataGridViewTextBoxColumn
            // 
            this.omsDataGridViewTextBoxColumn.DataPropertyName = "Oms";
            this.omsDataGridViewTextBoxColumn.HeaderText = "Oms";
            this.omsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.omsDataGridViewTextBoxColumn.Name = "omsDataGridViewTextBoxColumn";
            this.omsDataGridViewTextBoxColumn.ReadOnly = true;
            this.omsDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "Job";
            this.jobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            this.jobDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 125;
            // 
            // pacientsBindingSource
            // 
            this.pacientsBindingSource.DataMember = "Pacients";
            this.pacientsBindingSource.DataSource = this.medicinedbDataSet;
            // 
            // medicinedbDataSet
            // 
            this.medicinedbDataSet.DataSetName = "MedicinedbDataSet";
            this.medicinedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDeleteDoctor);
            this.tabPage2.Controls.Add(this.buttonEditDoctor);
            this.tabPage2.Controls.Add(this.buttonCreateDoctor);
            this.tabPage2.Controls.Add(this.dataGridViewFormAdministratorDoctors);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1386, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Врачи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonCreateDoctor
            // 
            this.buttonCreateDoctor.Location = new System.Drawing.Point(1025, 7);
            this.buttonCreateDoctor.Name = "buttonCreateDoctor";
            this.buttonCreateDoctor.Size = new System.Drawing.Size(355, 74);
            this.buttonCreateDoctor.TabIndex = 1;
            this.buttonCreateDoctor.Text = "Создать врача";
            this.buttonCreateDoctor.UseVisualStyleBackColor = true;
            this.buttonCreateDoctor.Click += new System.EventHandler(this.ButtonCreateDoctor_Click);
            // 
            // dataGridViewFormAdministratorDoctors
            // 
            this.dataGridViewFormAdministratorDoctors.AllowUserToAddRows = false;
            this.dataGridViewFormAdministratorDoctors.AllowUserToDeleteRows = false;
            this.dataGridViewFormAdministratorDoctors.AutoGenerateColumns = false;
            this.dataGridViewFormAdministratorDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormAdministratorDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.fioDataGridViewTextBoxColumn1,
            this.specialityDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.medOrganizationIdDataGridViewTextBoxColumn});
            this.dataGridViewFormAdministratorDoctors.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewFormAdministratorDoctors.DataSource = this.doctorsBindingSource;
            this.dataGridViewFormAdministratorDoctors.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewFormAdministratorDoctors.MultiSelect = false;
            this.dataGridViewFormAdministratorDoctors.Name = "dataGridViewFormAdministratorDoctors";
            this.dataGridViewFormAdministratorDoctors.ReadOnly = true;
            this.dataGridViewFormAdministratorDoctors.RowHeadersWidth = 51;
            this.dataGridViewFormAdministratorDoctors.RowTemplate.Height = 24;
            this.dataGridViewFormAdministratorDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFormAdministratorDoctors.Size = new System.Drawing.Size(1012, 621);
            this.dataGridViewFormAdministratorDoctors.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 80;
            // 
            // fioDataGridViewTextBoxColumn1
            // 
            this.fioDataGridViewTextBoxColumn1.DataPropertyName = "Fio";
            this.fioDataGridViewTextBoxColumn1.HeaderText = "Fio";
            this.fioDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fioDataGridViewTextBoxColumn1.Name = "fioDataGridViewTextBoxColumn1";
            this.fioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn1.Width = 125;
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "Speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "Speciality";
            this.specialityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            this.specialityDataGridViewTextBoxColumn.ReadOnly = true;
            this.specialityDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomDataGridViewTextBoxColumn.Width = 125;
            // 
            // medOrganizationIdDataGridViewTextBoxColumn
            // 
            this.medOrganizationIdDataGridViewTextBoxColumn.DataPropertyName = "MedOrganizationId";
            this.medOrganizationIdDataGridViewTextBoxColumn.HeaderText = "MedOrganizationId";
            this.medOrganizationIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medOrganizationIdDataGridViewTextBoxColumn.Name = "medOrganizationIdDataGridViewTextBoxColumn";
            this.medOrganizationIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.medOrganizationIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.medicinedbDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewFormAdministratorOrganizations);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1386, 634);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Организации";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFormAdministratorOrganizations
            // 
            this.dataGridViewFormAdministratorOrganizations.AllowUserToAddRows = false;
            this.dataGridViewFormAdministratorOrganizations.AllowUserToDeleteRows = false;
            this.dataGridViewFormAdministratorOrganizations.AutoGenerateColumns = false;
            this.dataGridViewFormAdministratorOrganizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormAdministratorOrganizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn1});
            this.dataGridViewFormAdministratorOrganizations.DataSource = this.medOrganizationsBindingSource;
            this.dataGridViewFormAdministratorOrganizations.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewFormAdministratorOrganizations.Name = "dataGridViewFormAdministratorOrganizations";
            this.dataGridViewFormAdministratorOrganizations.ReadOnly = true;
            this.dataGridViewFormAdministratorOrganizations.RowHeadersWidth = 51;
            this.dataGridViewFormAdministratorOrganizations.RowTemplate.Height = 24;
            this.dataGridViewFormAdministratorOrganizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFormAdministratorOrganizations.Size = new System.Drawing.Size(1012, 621);
            this.dataGridViewFormAdministratorOrganizations.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 80;
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
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "Director";
            this.directorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            this.directorDataGridViewTextBoxColumn.ReadOnly = true;
            this.directorDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            this.phoneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn1.Width = 125;
            // 
            // medOrganizationsBindingSource
            // 
            this.medOrganizationsBindingSource.DataMember = "MedOrganizations";
            this.medOrganizationsBindingSource.DataSource = this.medicinedbDataSet;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewFormAdministratorServices);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1386, 634);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Услуги";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFormAdministratorServices
            // 
            this.dataGridViewFormAdministratorServices.AllowUserToAddRows = false;
            this.dataGridViewFormAdministratorServices.AllowUserToDeleteRows = false;
            this.dataGridViewFormAdministratorServices.AutoGenerateColumns = false;
            this.dataGridViewFormAdministratorServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormAdministratorServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewFormAdministratorServices.DataSource = this.medServicesBindingSource;
            this.dataGridViewFormAdministratorServices.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewFormAdministratorServices.Name = "dataGridViewFormAdministratorServices";
            this.dataGridViewFormAdministratorServices.ReadOnly = true;
            this.dataGridViewFormAdministratorServices.RowHeadersWidth = 51;
            this.dataGridViewFormAdministratorServices.RowTemplate.Height = 24;
            this.dataGridViewFormAdministratorServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFormAdministratorServices.Size = new System.Drawing.Size(1012, 621);
            this.dataGridViewFormAdministratorServices.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // medServicesBindingSource
            // 
            this.medServicesBindingSource.DataMember = "MedServices";
            this.medServicesBindingSource.DataSource = this.medicinedbDataSet;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewFormAdministratorAdministrators);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1386, 634);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Администраторы";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFormAdministratorAdministrators
            // 
            this.dataGridViewFormAdministratorAdministrators.AllowUserToAddRows = false;
            this.dataGridViewFormAdministratorAdministrators.AutoGenerateColumns = false;
            this.dataGridViewFormAdministratorAdministrators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormAdministratorAdministrators.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.loginDataGridViewTextBoxColumn});
            this.dataGridViewFormAdministratorAdministrators.DataSource = this.administratorsBindingSource;
            this.dataGridViewFormAdministratorAdministrators.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewFormAdministratorAdministrators.Name = "dataGridViewFormAdministratorAdministrators";
            this.dataGridViewFormAdministratorAdministrators.ReadOnly = true;
            this.dataGridViewFormAdministratorAdministrators.RowHeadersWidth = 51;
            this.dataGridViewFormAdministratorAdministrators.RowTemplate.Height = 24;
            this.dataGridViewFormAdministratorAdministrators.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFormAdministratorAdministrators.Size = new System.Drawing.Size(1012, 621);
            this.dataGridViewFormAdministratorAdministrators.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            this.idDataGridViewTextBoxColumn4.Width = 80;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // administratorsBindingSource
            // 
            this.administratorsBindingSource.DataMember = "Administrators";
            this.administratorsBindingSource.DataSource = this.medicinedbDataSet;
            // 
            // pacientsTableAdapter
            // 
            this.pacientsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // medOrganizationsTableAdapter
            // 
            this.medOrganizationsTableAdapter.ClearBeforeFill = true;
            // 
            // medServicesTableAdapter
            // 
            this.medServicesTableAdapter.ClearBeforeFill = true;
            // 
            // administratorsTableAdapter
            // 
            this.administratorsTableAdapter.ClearBeforeFill = true;
            // 
            // medicinedbDataSetBindingSource
            // 
            this.medicinedbDataSetBindingSource.DataSource = this.medicinedbDataSet;
            this.medicinedbDataSetBindingSource.Position = 0;
            // 
            // buttonEditDoctor
            // 
            this.buttonEditDoctor.Location = new System.Drawing.Point(1025, 87);
            this.buttonEditDoctor.Name = "buttonEditDoctor";
            this.buttonEditDoctor.Size = new System.Drawing.Size(355, 74);
            this.buttonEditDoctor.TabIndex = 2;
            this.buttonEditDoctor.Text = "Изменить выбранного врача";
            this.buttonEditDoctor.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDoctor
            // 
            this.buttonDeleteDoctor.Location = new System.Drawing.Point(1025, 167);
            this.buttonDeleteDoctor.Name = "buttonDeleteDoctor";
            this.buttonDeleteDoctor.Size = new System.Drawing.Size(355, 74);
            this.buttonDeleteDoctor.TabIndex = 3;
            this.buttonDeleteDoctor.Text = "Удалить врача";
            this.buttonDeleteDoctor.UseVisualStyleBackColor = true;
            // 
            // FormAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 688);
            this.Controls.Add(this.tabControl1);
            this.Enabled = false;
            this.Name = "FormAdministrator";
            this.Text = "FormAdministrator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdministrator_FormClosed);
            this.Load += new System.EventHandler(this.FormAdministrator_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormAdministratorPacients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinedbDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormAdministratorDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormAdministratorOrganizations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOrganizationsBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormAdministratorServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medServicesBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormAdministratorAdministrators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinedbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewFormAdministratorPacients;
        private System.Windows.Forms.TabPage tabPage2;
        private MedicinedbDataSet medicinedbDataSet;
        private System.Windows.Forms.BindingSource pacientsBindingSource;
        private MedicinedbDataSetTableAdapters.PacientsTableAdapter pacientsTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewFormAdministratorDoctors;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private MedicinedbDataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewFormAdministratorOrganizations;
        private System.Windows.Forms.BindingSource medOrganizationsBindingSource;
        private MedicinedbDataSetTableAdapters.MedOrganizationsTableAdapter medOrganizationsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewFormAdministratorServices;
        private System.Windows.Forms.BindingSource medServicesBindingSource;
        private MedicinedbDataSetTableAdapters.MedServicesTableAdapter medServicesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewFormAdministratorAdministrators;
        private System.Windows.Forms.BindingSource administratorsBindingSource;
        private MedicinedbDataSetTableAdapters.AdministratorsTableAdapter administratorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medOrganizationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCreatePacient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn omsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medicinedbDataSetBindingSource;
        private System.Windows.Forms.Button buttonDeletePacient;
        private System.Windows.Forms.Button buttonUpdatePacient;
        private System.Windows.Forms.Button buttonCreateDoctor;
        private System.Windows.Forms.Button buttonDeleteDoctor;
        private System.Windows.Forms.Button buttonEditDoctor;
    }
}