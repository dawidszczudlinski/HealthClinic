namespace HealthClinic
{
    partial class AdministratorManageLaboratoryAssistant
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
            this.btn_DeleteLaborant = new System.Windows.Forms.Button();
            this.btn_EditLaborant = new System.Windows.Forms.Button();
            this.btn_AddLaborant = new System.Windows.Forms.Button();
            this.dgv_ListOfLaborants = new System.Windows.Forms.DataGridView();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.laborantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDlabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfLaborants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DeleteLaborant
            // 
            this.btn_DeleteLaborant.Location = new System.Drawing.Point(301, 221);
            this.btn_DeleteLaborant.Name = "btn_DeleteLaborant";
            this.btn_DeleteLaborant.Size = new System.Drawing.Size(119, 54);
            this.btn_DeleteLaborant.TabIndex = 14;
            this.btn_DeleteLaborant.Text = "Usuń";
            this.btn_DeleteLaborant.UseVisualStyleBackColor = true;
            this.btn_DeleteLaborant.Click += new System.EventHandler(this.btn_DeleteLaborant_Click);
            // 
            // btn_EditLaborant
            // 
            this.btn_EditLaborant.Location = new System.Drawing.Point(161, 221);
            this.btn_EditLaborant.Name = "btn_EditLaborant";
            this.btn_EditLaborant.Size = new System.Drawing.Size(119, 54);
            this.btn_EditLaborant.TabIndex = 13;
            this.btn_EditLaborant.Text = "Edytuj";
            this.btn_EditLaborant.UseVisualStyleBackColor = true;
            this.btn_EditLaborant.Click += new System.EventHandler(this.btn_EditLaborant_Click);
            // 
            // btn_AddLaborant
            // 
            this.btn_AddLaborant.Location = new System.Drawing.Point(21, 221);
            this.btn_AddLaborant.Name = "btn_AddLaborant";
            this.btn_AddLaborant.Size = new System.Drawing.Size(119, 54);
            this.btn_AddLaborant.TabIndex = 12;
            this.btn_AddLaborant.Text = "Dodaj";
            this.btn_AddLaborant.UseVisualStyleBackColor = true;
            this.btn_AddLaborant.Click += new System.EventHandler(this.btn_AddLaborant_Click);
            // 
            // dgv_ListOfLaborants
            // 
            this.dgv_ListOfLaborants.AllowUserToAddRows = false;
            this.dgv_ListOfLaborants.AllowUserToDeleteRows = false;
            this.dgv_ListOfLaborants.AutoGenerateColumns = false;
            this.dgv_ListOfLaborants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOfLaborants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDlabDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dgv_ListOfLaborants.DataSource = this.laborantBindingSource;
            this.dgv_ListOfLaborants.Location = new System.Drawing.Point(22, 54);
            this.dgv_ListOfLaborants.MultiSelect = false;
            this.dgv_ListOfLaborants.Name = "dgv_ListOfLaborants";
            this.dgv_ListOfLaborants.ReadOnly = true;
            this.dgv_ListOfLaborants.Size = new System.Drawing.Size(561, 150);
            this.dgv_ListOfLaborants.TabIndex = 11;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Description.Location = new System.Drawing.Point(17, 16);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(176, 26);
            this.lbl_Description.TabIndex = 10;
            this.lbl_Description.Text = "Lista laborantów:";
            // 
            // laborantBindingSource
            // 
            this.laborantBindingSource.DataSource = typeof(HealthClinic.Laborant);
            // 
            // iDlabDataGridViewTextBoxColumn
            // 
            this.iDlabDataGridViewTextBoxColumn.DataPropertyName = "ID_lab";
            this.iDlabDataGridViewTextBoxColumn.HeaderText = "ID_lab";
            this.iDlabDataGridViewTextBoxColumn.Name = "iDlabDataGridViewTextBoxColumn";
            this.iDlabDataGridViewTextBoxColumn.ReadOnly = true;
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
            // AdministratorManageLaboratoryAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 292);
            this.Controls.Add(this.btn_DeleteLaborant);
            this.Controls.Add(this.btn_EditLaborant);
            this.Controls.Add(this.btn_AddLaborant);
            this.Controls.Add(this.dgv_ListOfLaborants);
            this.Controls.Add(this.lbl_Description);
            this.Name = "AdministratorManageLaboratoryAssistant";
            this.Text = "Zarządzaj laborantami";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfLaborants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteLaborant;
        private System.Windows.Forms.Button btn_EditLaborant;
        private System.Windows.Forms.Button btn_AddLaborant;
        private System.Windows.Forms.DataGridView dgv_ListOfLaborants;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDlabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource laborantBindingSource;

    }
}