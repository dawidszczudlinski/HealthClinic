namespace HealthClinic
{
    partial class DoctorPhysicalExamination
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
            this.lbl_PhysicalExamination = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.badanieTableAdapter = new HealthClinic.HealthClinicDataSetTableAdapters.BadanieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhysicalExamination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badanieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthClinicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PhysicalExamination
            // 
            this.dgv_PhysicalExamination.AutoGenerateColumns = false;
            this.dgv_PhysicalExamination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhysicalExamination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgv_PhysicalExamination.DataSource = this.badanieBindingSource;
            this.dgv_PhysicalExamination.Location = new System.Drawing.Point(21, 72);
            this.dgv_PhysicalExamination.MultiSelect = false;
            this.dgv_PhysicalExamination.Name = "dgv_PhysicalExamination";
            this.dgv_PhysicalExamination.ReadOnly = true;
            this.dgv_PhysicalExamination.Size = new System.Drawing.Size(552, 231);
            this.dgv_PhysicalExamination.TabIndex = 0;
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
            // lbl_PhysicalExamination
            // 
            this.lbl_PhysicalExamination.AutoSize = true;
            this.lbl_PhysicalExamination.Location = new System.Drawing.Point(18, 28);
            this.lbl_PhysicalExamination.Name = "lbl_PhysicalExamination";
            this.lbl_PhysicalExamination.Size = new System.Drawing.Size(177, 13);
            this.lbl_PhysicalExamination.TabIndex = 1;
            this.lbl_PhysicalExamination.Text = "Badania fizykalne związane z wizytą";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(76, 343);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(103, 47);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Powrót";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(358, 343);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(103, 47);
            this.btn_New.TabIndex = 4;
            this.btn_New.Text = "Nowe badanie";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // badanieTableAdapter
            // 
            this.badanieTableAdapter.ClearBeforeFill = true;
            // 
            // DoctorPhysicalExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 472);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_PhysicalExamination);
            this.Controls.Add(this.dgv_PhysicalExamination);
            this.Name = "DoctorPhysicalExamination";
            this.Text = "Badania fizykalne";
            this.Load += new System.EventHandler(this.DoctorPhysicalExamination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhysicalExamination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badanieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthClinicDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PhysicalExamination;
        private System.Windows.Forms.Label lbl_PhysicalExamination;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_New;
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
    }
}