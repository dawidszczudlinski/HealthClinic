namespace HealthClinic
{
    partial class DoctorPhysicalExaminationMap
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slownikbadanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slownikbadanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.slownikbadanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(348, 192);
            this.dataGridView1.TabIndex = 0;
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
            this.slownikbadanBindingSource.DataSource = typeof(HealthClinic.Slownik_badan);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(190, 223);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(107, 48);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Powrót";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(48, 223);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(107, 48);
            this.btn_OK.TabIndex = 13;
            this.btn_OK.Text = "Zatwierdź";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // DoctorPhysicalExaminationMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 283);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DoctorPhysicalExaminationMap";
            this.Text = "Wybierz badanie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slownikbadanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource slownikbadanBindingSource;
    }
}