namespace HealthClinic
{
    partial class AdministratorManageDoctors
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
            this.btn_DeleteDoctor = new System.Windows.Forms.Button();
            this.btn_EditDoctor = new System.Windows.Forms.Button();
            this.btn_AddDoctor = new System.Windows.Forms.Button();
            this.dgv_ListOfDoctors = new System.Windows.Forms.DataGridView();
            this.iDlekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npwzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lekarzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DeleteDoctor
            // 
            this.btn_DeleteDoctor.Location = new System.Drawing.Point(333, 237);
            this.btn_DeleteDoctor.Name = "btn_DeleteDoctor";
            this.btn_DeleteDoctor.Size = new System.Drawing.Size(119, 54);
            this.btn_DeleteDoctor.TabIndex = 14;
            this.btn_DeleteDoctor.Text = "Usuń";
            this.btn_DeleteDoctor.UseVisualStyleBackColor = true;
            this.btn_DeleteDoctor.Click += new System.EventHandler(this.btn_DeleteDoctor_Click);
            // 
            // btn_EditDoctor
            // 
            this.btn_EditDoctor.Location = new System.Drawing.Point(178, 237);
            this.btn_EditDoctor.Name = "btn_EditDoctor";
            this.btn_EditDoctor.Size = new System.Drawing.Size(119, 54);
            this.btn_EditDoctor.TabIndex = 13;
            this.btn_EditDoctor.Text = "Edytuj";
            this.btn_EditDoctor.UseVisualStyleBackColor = true;
            this.btn_EditDoctor.Click += new System.EventHandler(this.btn_EditDoctor_Click);
            // 
            // btn_AddDoctor
            // 
            this.btn_AddDoctor.Location = new System.Drawing.Point(27, 237);
            this.btn_AddDoctor.Name = "btn_AddDoctor";
            this.btn_AddDoctor.Size = new System.Drawing.Size(119, 54);
            this.btn_AddDoctor.TabIndex = 12;
            this.btn_AddDoctor.Text = "Dodaj";
            this.btn_AddDoctor.UseVisualStyleBackColor = true;
            this.btn_AddDoctor.Click += new System.EventHandler(this.btn_AddDoctor_Click);
            // 
            // dgv_ListOfDoctors
            // 
            this.dgv_ListOfDoctors.AllowUserToAddRows = false;
            this.dgv_ListOfDoctors.AllowUserToDeleteRows = false;
            this.dgv_ListOfDoctors.AutoGenerateColumns = false;
            this.dgv_ListOfDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOfDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDlekDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.npwzDataGridViewTextBoxColumn});
            this.dgv_ListOfDoctors.DataSource = this.lekarzBindingSource;
            this.dgv_ListOfDoctors.Location = new System.Drawing.Point(12, 58);
            this.dgv_ListOfDoctors.MultiSelect = false;
            this.dgv_ListOfDoctors.Name = "dgv_ListOfDoctors";
            this.dgv_ListOfDoctors.ReadOnly = true;
            this.dgv_ListOfDoctors.Size = new System.Drawing.Size(649, 150);
            this.dgv_ListOfDoctors.TabIndex = 11;
            // 
            // iDlekDataGridViewTextBoxColumn
            // 
            this.iDlekDataGridViewTextBoxColumn.DataPropertyName = "ID_lek";
            this.iDlekDataGridViewTextBoxColumn.HeaderText = "ID_lek";
            this.iDlekDataGridViewTextBoxColumn.Name = "iDlekDataGridViewTextBoxColumn";
            this.iDlekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            this.pESELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // npwzDataGridViewTextBoxColumn
            // 
            this.npwzDataGridViewTextBoxColumn.DataPropertyName = "npwz";
            this.npwzDataGridViewTextBoxColumn.HeaderText = "npwz";
            this.npwzDataGridViewTextBoxColumn.Name = "npwzDataGridViewTextBoxColumn";
            this.npwzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lekarzBindingSource
            // 
            this.lekarzBindingSource.DataSource = typeof(HealthClinic.Lekarz);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Description.Location = new System.Drawing.Point(22, 18);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(133, 26);
            this.lbl_Description.TabIndex = 10;
            this.lbl_Description.Text = "Lista lekarzy";
            // 
            // AdministratorManageDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 316);
            this.Controls.Add(this.btn_DeleteDoctor);
            this.Controls.Add(this.btn_EditDoctor);
            this.Controls.Add(this.btn_AddDoctor);
            this.Controls.Add(this.dgv_ListOfDoctors);
            this.Controls.Add(this.lbl_Description);
            this.Name = "AdministratorManageDoctors";
            this.Text = "Zarządzaj lekarzami";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteDoctor;
        private System.Windows.Forms.Button btn_EditDoctor;
        private System.Windows.Forms.Button btn_AddDoctor;
        private System.Windows.Forms.DataGridView dgv_ListOfDoctors;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDlekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn npwzDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lekarzBindingSource;
    }
}