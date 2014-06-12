namespace HealthClinic
{
    partial class DoctorLaboratoryExaminationMap
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.dgv_LaboratoryExamination = new System.Windows.Forms.DataGridView();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slownikbadanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.healthClinicDataSet = new HealthClinic.HealthClinicDataSet();
            this.slownik_badanTableAdapter = new HealthClinic.HealthClinicDataSetTableAdapters.Slownik_badanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LaboratoryExamination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slownikbadanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthClinicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(209, 213);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(107, 48);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "Powrót";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(67, 213);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(107, 48);
            this.btn_OK.TabIndex = 16;
            this.btn_OK.Text = "Zatwierdź";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // dgv_LaboratoryExamination
            // 
            this.dgv_LaboratoryExamination.AutoGenerateColumns = false;
            this.dgv_LaboratoryExamination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LaboratoryExamination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dgv_LaboratoryExamination.DataSource = this.slownikbadanBindingSource;
            this.dgv_LaboratoryExamination.Location = new System.Drawing.Point(26, 12);
            this.dgv_LaboratoryExamination.MultiSelect = false;
            this.dgv_LaboratoryExamination.Name = "dgv_LaboratoryExamination";
            this.dgv_LaboratoryExamination.ReadOnly = true;
            this.dgv_LaboratoryExamination.Size = new System.Drawing.Size(355, 192);
            this.dgv_LaboratoryExamination.TabIndex = 15;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slownikbadanBindingSource
            // 
            this.slownikbadanBindingSource.DataMember = "Slownik_badan";
            this.slownikbadanBindingSource.DataSource = this.healthClinicDataSet;
            // 
            // healthClinicDataSet
            // 
            this.healthClinicDataSet.DataSetName = "HealthClinicDataSet";
            this.healthClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // slownik_badanTableAdapter
            // 
            this.slownik_badanTableAdapter.ClearBeforeFill = true;
            // 
            // DoctorLaboratoryExaminationMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 278);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dgv_LaboratoryExamination);
            this.Name = "DoctorLaboratoryExaminationMap";
            this.Text = "Wybierz badanie";
            this.Load += new System.EventHandler(this.DoctorLaboratoryExaminationMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LaboratoryExamination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slownikbadanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthClinicDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridView dgv_LaboratoryExamination;
        private HealthClinicDataSet healthClinicDataSet;
        private System.Windows.Forms.BindingSource slownikbadanBindingSource;
        private HealthClinicDataSetTableAdapters.Slownik_badanTableAdapter slownik_badanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
    }
}