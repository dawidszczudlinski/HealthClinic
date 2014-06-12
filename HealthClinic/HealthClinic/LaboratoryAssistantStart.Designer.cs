namespace HealthClinic
{
    partial class LaboratoryAssistantStart
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
            this.lbl_RegistrationDate = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Pesel = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_Filtr = new System.Windows.Forms.Label();
            this.lbl_Pesel = new System.Windows.Forms.Label();
            this.lbl_Imie = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
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
            this.badanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.healthClinicDataSet = new HealthClinic.HealthClinicDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_ServicePatient = new System.Windows.Forms.Button();
            this.badanieTableAdapter = new HealthClinic.HealthClinicDataSetTableAdapters.BadanieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badanieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthClinicDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(19, 127);
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
            "Zle",
            "Zat",
            "Anul"});
            this.cmb_State.Location = new System.Drawing.Point(117, 119);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(67, 21);
            this.cmb_State.TabIndex = 10;
            // 
            // lbl_RegistrationDate
            // 
            this.lbl_RegistrationDate.AutoSize = true;
            this.lbl_RegistrationDate.Location = new System.Drawing.Point(320, 29);
            this.lbl_RegistrationDate.Name = "lbl_RegistrationDate";
            this.lbl_RegistrationDate.Size = new System.Drawing.Size(80, 13);
            this.lbl_RegistrationDate.TabIndex = 8;
            this.lbl_RegistrationDate.Text = "Data rejestracji:";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(169, 163);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 50);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Szukaj";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Pesel
            // 
            this.txt_Pesel.Location = new System.Drawing.Point(117, 85);
            this.txt_Pesel.Name = "txt_Pesel";
            this.txt_Pesel.Size = new System.Drawing.Size(148, 20);
            this.txt_Pesel.TabIndex = 6;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(117, 59);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(148, 20);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(117, 29);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(148, 20);
            this.txt_LastName.TabIndex = 4;
            // 
            // lbl_Filtr
            // 
            this.lbl_Filtr.AutoSize = true;
            this.lbl_Filtr.Location = new System.Drawing.Point(19, 15);
            this.lbl_Filtr.Name = "lbl_Filtr";
            this.lbl_Filtr.Size = new System.Drawing.Size(23, 13);
            this.lbl_Filtr.TabIndex = 3;
            this.lbl_Filtr.Text = "Filtr";
            // 
            // lbl_Pesel
            // 
            this.lbl_Pesel.AutoSize = true;
            this.lbl_Pesel.Location = new System.Drawing.Point(19, 92);
            this.lbl_Pesel.Name = "lbl_Pesel";
            this.lbl_Pesel.Size = new System.Drawing.Size(44, 13);
            this.lbl_Pesel.TabIndex = 2;
            this.lbl_Pesel.Text = "PESEL:";
            // 
            // lbl_Imie
            // 
            this.lbl_Imie.AutoSize = true;
            this.lbl_Imie.Location = new System.Drawing.Point(19, 66);
            this.lbl_Imie.Name = "lbl_Imie";
            this.lbl_Imie.Size = new System.Drawing.Size(29, 13);
            this.lbl_Imie.TabIndex = 1;
            this.lbl_Imie.Text = "Imie:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(19, 36);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(56, 13);
            this.lbl_LastName.TabIndex = 0;
            this.lbl_LastName.Text = "Nazwisko:";
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
            this.iDwizDataGridViewTextBoxColumn});
            this.dgv_ListOfVisits.DataSource = this.badanieBindingSource;
            this.dgv_ListOfVisits.Location = new System.Drawing.Point(12, 249);
            this.dgv_ListOfVisits.MultiSelect = false;
            this.dgv_ListOfVisits.Name = "dgv_ListOfVisits";
            this.dgv_ListOfVisits.ReadOnly = true;
            this.dgv_ListOfVisits.Size = new System.Drawing.Size(709, 196);
            this.dgv_ListOfVisits.TabIndex = 10;
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
            // badanieBindingSource
            // 
            this.badanieBindingSource.DataMember = "Badanie";
            this.badanieBindingSource.DataSource = this.healthClinicDataSet;
            // 
            // healthClinicDataSet
            // 
            this.healthClinicDataSet.DataSetName = "HealthClinicDataSet";
            this.healthClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.lbl_State);
            this.groupBox1.Controls.Add(this.cmb_State);
            this.groupBox1.Controls.Add(this.lbl_RegistrationDate);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_Pesel);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_LastName);
            this.groupBox1.Controls.Add(this.lbl_Filtr);
            this.groupBox1.Controls.Add(this.lbl_Pesel);
            this.groupBox1.Controls.Add(this.lbl_Imie);
            this.groupBox1.Controls.Add(this.lbl_LastName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 231);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(308, 66);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // btn_ServicePatient
            // 
            this.btn_ServicePatient.Location = new System.Drawing.Point(552, 460);
            this.btn_ServicePatient.Name = "btn_ServicePatient";
            this.btn_ServicePatient.Size = new System.Drawing.Size(96, 50);
            this.btn_ServicePatient.TabIndex = 12;
            this.btn_ServicePatient.Text = "Obsługa";
            this.btn_ServicePatient.UseVisualStyleBackColor = true;
            this.btn_ServicePatient.Click += new System.EventHandler(this.btn_ServicePatient_Click);
            // 
            // badanieTableAdapter
            // 
            this.badanieTableAdapter.ClearBeforeFill = true;
            // 
            // LaboratoryAssistantStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 520);
            this.Controls.Add(this.btn_ServicePatient);
            this.Controls.Add(this.dgv_ListOfVisits);
            this.Controls.Add(this.groupBox1);
            this.Name = "LaboratoryAssistantStart";
            this.Text = "Wybierz badanie";
            this.Load += new System.EventHandler(this.LaboratoryAssistantStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badanieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthClinicDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.Label lbl_RegistrationDate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Pesel;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_Filtr;
        private System.Windows.Forms.Label lbl_Pesel;
        private System.Windows.Forms.Label lbl_Imie;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.DataGridView dgv_ListOfVisits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ServicePatient;
        private HealthClinicDataSet healthClinicDataSet;
        private System.Windows.Forms.BindingSource badanieBindingSource;
        private HealthClinicDataSetTableAdapters.BadanieTableAdapter badanieTableAdapter;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker2;

    }
}