﻿namespace HealthClinic
{
    partial class DoctorLaboratoryExamination
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
            this.dgv_PhysicalExamination = new System.Windows.Forms.DataGridView();
            this.col_IDExamination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExaminationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExaminationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExaminationResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExaminationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDbadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtzleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtwykanulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wynikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtzatwanulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDlabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKlabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDwizDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kierownikLaboratoriumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slownikbadanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wizytaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_LaboratoryExamination = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhysicalExamination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badanieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PhysicalExamination
            // 
            this.dgv_PhysicalExamination.AutoGenerateColumns = false;
            this.dgv_PhysicalExamination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhysicalExamination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IDExamination,
            this.col_ExaminationCode,
            this.col_ExaminationName,
            this.col_ExaminationResult,
            this.col_ExaminationDate,
            this.iDbadDataGridViewTextBoxColumn,
            this.dtzleDataGridViewTextBoxColumn,
            this.dtwykanulDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.wynikDataGridViewTextBoxColumn,
            this.uwagiDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dtzatwanulDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.iDlabDataGridViewTextBoxColumn,
            this.iDKlabDataGridViewTextBoxColumn,
            this.iDwizDataGridViewTextBoxColumn,
            this.kierownikLaboratoriumDataGridViewTextBoxColumn,
            this.laborantDataGridViewTextBoxColumn,
            this.slownikbadanDataGridViewTextBoxColumn,
            this.wizytaDataGridViewTextBoxColumn});
            this.dgv_PhysicalExamination.DataSource = this.badanieBindingSource;
            this.dgv_PhysicalExamination.Location = new System.Drawing.Point(12, 44);
            this.dgv_PhysicalExamination.MultiSelect = false;
            this.dgv_PhysicalExamination.Name = "dgv_PhysicalExamination";
            this.dgv_PhysicalExamination.ReadOnly = true;
            this.dgv_PhysicalExamination.Size = new System.Drawing.Size(1010, 231);
            this.dgv_PhysicalExamination.TabIndex = 5;
            // 
            // col_IDExamination
            // 
            this.col_IDExamination.HeaderText = "ID badania";
            this.col_IDExamination.Name = "col_IDExamination";
            this.col_IDExamination.ReadOnly = true;
            // 
            // col_ExaminationCode
            // 
            this.col_ExaminationCode.HeaderText = "Kod badania";
            this.col_ExaminationCode.Name = "col_ExaminationCode";
            this.col_ExaminationCode.ReadOnly = true;
            // 
            // col_ExaminationName
            // 
            this.col_ExaminationName.HeaderText = "Nazwa";
            this.col_ExaminationName.Name = "col_ExaminationName";
            this.col_ExaminationName.ReadOnly = true;
            // 
            // col_ExaminationResult
            // 
            this.col_ExaminationResult.HeaderText = "Wynik";
            this.col_ExaminationResult.Name = "col_ExaminationResult";
            this.col_ExaminationResult.ReadOnly = true;
            // 
            // col_ExaminationDate
            // 
            this.col_ExaminationDate.HeaderText = "Data wykonania";
            this.col_ExaminationDate.Name = "col_ExaminationDate";
            this.col_ExaminationDate.ReadOnly = true;
            // 
            // iDbadDataGridViewTextBoxColumn
            // 
            this.iDbadDataGridViewTextBoxColumn.DataPropertyName = "ID_bad";
            this.iDbadDataGridViewTextBoxColumn.HeaderText = "ID_bad";
            this.iDbadDataGridViewTextBoxColumn.Name = "iDbadDataGridViewTextBoxColumn";
            this.iDbadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtzleDataGridViewTextBoxColumn
            // 
            this.dtzleDataGridViewTextBoxColumn.DataPropertyName = "Dt_zle";
            this.dtzleDataGridViewTextBoxColumn.HeaderText = "Dt_zle";
            this.dtzleDataGridViewTextBoxColumn.Name = "dtzleDataGridViewTextBoxColumn";
            this.dtzleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtwykanulDataGridViewTextBoxColumn
            // 
            this.dtwykanulDataGridViewTextBoxColumn.DataPropertyName = "Dt_wyk_anul";
            this.dtwykanulDataGridViewTextBoxColumn.HeaderText = "Dt_wyk_anul";
            this.dtwykanulDataGridViewTextBoxColumn.Name = "dtwykanulDataGridViewTextBoxColumn";
            this.dtwykanulDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wynikDataGridViewTextBoxColumn
            // 
            this.wynikDataGridViewTextBoxColumn.DataPropertyName = "Wynik";
            this.wynikDataGridViewTextBoxColumn.HeaderText = "Wynik";
            this.wynikDataGridViewTextBoxColumn.Name = "wynikDataGridViewTextBoxColumn";
            this.wynikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uwagiDataGridViewTextBoxColumn
            // 
            this.uwagiDataGridViewTextBoxColumn.DataPropertyName = "Uwagi";
            this.uwagiDataGridViewTextBoxColumn.HeaderText = "Uwagi";
            this.uwagiDataGridViewTextBoxColumn.Name = "uwagiDataGridViewTextBoxColumn";
            this.uwagiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtzatwanulDataGridViewTextBoxColumn
            // 
            this.dtzatwanulDataGridViewTextBoxColumn.DataPropertyName = "Dt_zatw_anul";
            this.dtzatwanulDataGridViewTextBoxColumn.HeaderText = "Dt_zatw_anul";
            this.dtzatwanulDataGridViewTextBoxColumn.Name = "dtzatwanulDataGridViewTextBoxColumn";
            this.dtzatwanulDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDlabDataGridViewTextBoxColumn
            // 
            this.iDlabDataGridViewTextBoxColumn.DataPropertyName = "ID_lab";
            this.iDlabDataGridViewTextBoxColumn.HeaderText = "ID_lab";
            this.iDlabDataGridViewTextBoxColumn.Name = "iDlabDataGridViewTextBoxColumn";
            this.iDlabDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDKlabDataGridViewTextBoxColumn
            // 
            this.iDKlabDataGridViewTextBoxColumn.DataPropertyName = "ID_Klab";
            this.iDKlabDataGridViewTextBoxColumn.HeaderText = "ID_Klab";
            this.iDKlabDataGridViewTextBoxColumn.Name = "iDKlabDataGridViewTextBoxColumn";
            this.iDKlabDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDwizDataGridViewTextBoxColumn
            // 
            this.iDwizDataGridViewTextBoxColumn.DataPropertyName = "ID_wiz";
            this.iDwizDataGridViewTextBoxColumn.HeaderText = "ID_wiz";
            this.iDwizDataGridViewTextBoxColumn.Name = "iDwizDataGridViewTextBoxColumn";
            this.iDwizDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kierownikLaboratoriumDataGridViewTextBoxColumn
            // 
            this.kierownikLaboratoriumDataGridViewTextBoxColumn.DataPropertyName = "Kierownik_Laboratorium";
            this.kierownikLaboratoriumDataGridViewTextBoxColumn.HeaderText = "Kierownik_Laboratorium";
            this.kierownikLaboratoriumDataGridViewTextBoxColumn.Name = "kierownikLaboratoriumDataGridViewTextBoxColumn";
            this.kierownikLaboratoriumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // laborantDataGridViewTextBoxColumn
            // 
            this.laborantDataGridViewTextBoxColumn.DataPropertyName = "Laborant";
            this.laborantDataGridViewTextBoxColumn.HeaderText = "Laborant";
            this.laborantDataGridViewTextBoxColumn.Name = "laborantDataGridViewTextBoxColumn";
            this.laborantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slownikbadanDataGridViewTextBoxColumn
            // 
            this.slownikbadanDataGridViewTextBoxColumn.DataPropertyName = "Slownik_badan";
            this.slownikbadanDataGridViewTextBoxColumn.HeaderText = "Slownik_badan";
            this.slownikbadanDataGridViewTextBoxColumn.Name = "slownikbadanDataGridViewTextBoxColumn";
            this.slownikbadanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wizytaDataGridViewTextBoxColumn
            // 
            this.wizytaDataGridViewTextBoxColumn.DataPropertyName = "Wizyta";
            this.wizytaDataGridViewTextBoxColumn.HeaderText = "Wizyta";
            this.wizytaDataGridViewTextBoxColumn.Name = "wizytaDataGridViewTextBoxColumn";
            this.wizytaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // badanieBindingSource
            // 
            this.badanieBindingSource.DataSource = typeof(HealthClinic.Badanie);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(357, 316);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(103, 47);
            this.btn_New.TabIndex = 9;
            this.btn_New.Text = "Nowe badanie";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(216, 316);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(103, 47);
            this.btn_Show.TabIndex = 8;
            this.btn_Show.Text = "Pokaż badanie";
            this.btn_Show.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(75, 316);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(103, 47);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Powrót";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // lbl_LaboratoryExamination
            // 
            this.lbl_LaboratoryExamination.AutoSize = true;
            this.lbl_LaboratoryExamination.Location = new System.Drawing.Point(17, 9);
            this.lbl_LaboratoryExamination.Name = "lbl_LaboratoryExamination";
            this.lbl_LaboratoryExamination.Size = new System.Drawing.Size(196, 13);
            this.lbl_LaboratoryExamination.TabIndex = 6;
            this.lbl_LaboratoryExamination.Text = "Badania laboratoryjne związane z wizytą";
            // 
            // DoctorLaboratoryExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 399);
            this.Controls.Add(this.dgv_PhysicalExamination);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_LaboratoryExamination);
            this.Name = "DoctorLaboratoryExamination";
            this.Text = "Badania laboratoryjne";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhysicalExamination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badanieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PhysicalExamination;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDExamination;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExaminationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExaminationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExaminationResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExaminationDate;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_LaboratoryExamination;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDbadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtzleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtwykanulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wynikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtzatwanulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDlabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKlabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDwizDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kierownikLaboratoriumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slownikbadanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wizytaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource badanieBindingSource;

    }
}