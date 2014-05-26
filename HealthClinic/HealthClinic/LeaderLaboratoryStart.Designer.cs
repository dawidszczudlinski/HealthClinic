namespace HealthClinic
{
    partial class LeaderLaboratoryStart
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
            this.lbl_State = new System.Windows.Forms.Label();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_ServicePatient = new System.Windows.Forms.Button();
            this.btn_ShowExamination = new System.Windows.Forms.Button();
            this.dgv_ListOfVisits = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badanieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(24, 16);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(32, 13);
            this.lbl_State.TabIndex = 11;
            this.lbl_State.Text = "Stan:";
            // 
            // cmb_State
            // 
            this.cmb_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.Items.AddRange(new object[] {
            "Rej"});
            this.cmb_State.Location = new System.Drawing.Point(78, 16);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(67, 21);
            this.cmb_State.TabIndex = 10;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(204, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 28);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Szukaj";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_ServicePatient
            // 
            this.btn_ServicePatient.Location = new System.Drawing.Point(625, 277);
            this.btn_ServicePatient.Name = "btn_ServicePatient";
            this.btn_ServicePatient.Size = new System.Drawing.Size(96, 50);
            this.btn_ServicePatient.TabIndex = 14;
            this.btn_ServicePatient.Text = "Obsługa";
            this.btn_ServicePatient.UseVisualStyleBackColor = true;
            this.btn_ServicePatient.Click += new System.EventHandler(this.btn_ServicePatient_Click);
            // 
            // btn_ShowExamination
            // 
            this.btn_ShowExamination.Location = new System.Drawing.Point(503, 277);
            this.btn_ShowExamination.Name = "btn_ShowExamination";
            this.btn_ShowExamination.Size = new System.Drawing.Size(96, 50);
            this.btn_ShowExamination.TabIndex = 13;
            this.btn_ShowExamination.Text = "Pokaż";
            this.btn_ShowExamination.UseVisualStyleBackColor = true;
            this.btn_ShowExamination.Click += new System.EventHandler(this.btn_ShowExamination_Click);
            // 
            // dgv_ListOfVisits
            // 
            this.dgv_ListOfVisits.AutoGenerateColumns = false;
            this.dgv_ListOfVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOfVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgv_ListOfVisits.DataSource = this.badanieBindingSource;
            this.dgv_ListOfVisits.Location = new System.Drawing.Point(12, 60);
            this.dgv_ListOfVisits.MultiSelect = false;
            this.dgv_ListOfVisits.Name = "dgv_ListOfVisits";
            this.dgv_ListOfVisits.ReadOnly = true;
            this.dgv_ListOfVisits.RowHeadersVisible = false;
            this.dgv_ListOfVisits.Size = new System.Drawing.Size(709, 196);
            this.dgv_ListOfVisits.TabIndex = 15;
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
            // LeaderLaboratoryStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 353);
            this.Controls.Add(this.dgv_ListOfVisits);
            this.Controls.Add(this.btn_ServicePatient);
            this.Controls.Add(this.btn_ShowExamination);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.cmb_State);
            this.Controls.Add(this.btn_Search);
            this.Name = "LeaderLaboratoryStart";
            this.Text = "Wybierz badanie";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badanieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ServicePatient;
        private System.Windows.Forms.Button btn_ShowExamination;
        private System.Windows.Forms.DataGridView dgv_ListOfVisits;
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