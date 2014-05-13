namespace HealthClinic
{
    partial class AdministratorManageLeaderLaboratory
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
            this.btn_DeleteLeader = new System.Windows.Forms.Button();
            this.btn_EditLeader = new System.Windows.Forms.Button();
            this.btn_AddLeader = new System.Windows.Forms.Button();
            this.dgv_ListOfLeaders = new System.Windows.Forms.DataGridView();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.kierownikLaboratoriumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDKlabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfLeaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kierownikLaboratoriumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DeleteLeader
            // 
            this.btn_DeleteLeader.Location = new System.Drawing.Point(291, 220);
            this.btn_DeleteLeader.Name = "btn_DeleteLeader";
            this.btn_DeleteLeader.Size = new System.Drawing.Size(119, 54);
            this.btn_DeleteLeader.TabIndex = 19;
            this.btn_DeleteLeader.Text = "Usuń";
            this.btn_DeleteLeader.UseVisualStyleBackColor = true;
            this.btn_DeleteLeader.Click += new System.EventHandler(this.btn_DeleteLeader_Click);
            // 
            // btn_EditLeader
            // 
            this.btn_EditLeader.Location = new System.Drawing.Point(151, 220);
            this.btn_EditLeader.Name = "btn_EditLeader";
            this.btn_EditLeader.Size = new System.Drawing.Size(119, 54);
            this.btn_EditLeader.TabIndex = 18;
            this.btn_EditLeader.Text = "Edytuj";
            this.btn_EditLeader.UseVisualStyleBackColor = true;
            this.btn_EditLeader.Click += new System.EventHandler(this.btn_EditLeader_Click);
            // 
            // btn_AddLeader
            // 
            this.btn_AddLeader.Location = new System.Drawing.Point(11, 220);
            this.btn_AddLeader.Name = "btn_AddLeader";
            this.btn_AddLeader.Size = new System.Drawing.Size(119, 54);
            this.btn_AddLeader.TabIndex = 17;
            this.btn_AddLeader.Text = "Dodaj";
            this.btn_AddLeader.UseVisualStyleBackColor = true;
            this.btn_AddLeader.Click += new System.EventHandler(this.btn_AddLeader_Click);
            // 
            // dgv_ListOfLeaders
            // 
            this.dgv_ListOfLeaders.AllowUserToAddRows = false;
            this.dgv_ListOfLeaders.AllowUserToDeleteRows = false;
            this.dgv_ListOfLeaders.AutoGenerateColumns = false;
            this.dgv_ListOfLeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOfLeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKlabDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dgv_ListOfLeaders.DataSource = this.kierownikLaboratoriumBindingSource;
            this.dgv_ListOfLeaders.Location = new System.Drawing.Point(12, 53);
            this.dgv_ListOfLeaders.MultiSelect = false;
            this.dgv_ListOfLeaders.Name = "dgv_ListOfLeaders";
            this.dgv_ListOfLeaders.ReadOnly = true;
            this.dgv_ListOfLeaders.Size = new System.Drawing.Size(561, 150);
            this.dgv_ListOfLeaders.TabIndex = 16;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Description.Location = new System.Drawing.Point(7, 15);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(313, 26);
            this.lbl_Description.TabIndex = 15;
            this.lbl_Description.Text = "Lista kierowników laboratoriów:";
            // 
            // kierownikLaboratoriumBindingSource
            // 
            this.kierownikLaboratoriumBindingSource.DataSource = typeof(HealthClinic.Kierownik_Laboratorium);
            // 
            // iDKlabDataGridViewTextBoxColumn
            // 
            this.iDKlabDataGridViewTextBoxColumn.DataPropertyName = "ID_Klab";
            this.iDKlabDataGridViewTextBoxColumn.HeaderText = "ID_Klab";
            this.iDKlabDataGridViewTextBoxColumn.Name = "iDKlabDataGridViewTextBoxColumn";
            this.iDKlabDataGridViewTextBoxColumn.ReadOnly = true;
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
            // AdministratorManageLeaderLaboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 320);
            this.Controls.Add(this.btn_DeleteLeader);
            this.Controls.Add(this.btn_EditLeader);
            this.Controls.Add(this.btn_AddLeader);
            this.Controls.Add(this.dgv_ListOfLeaders);
            this.Controls.Add(this.lbl_Description);
            this.Name = "AdministratorManageLeaderLaboratory";
            this.Text = "Zarządzaj kierownikami";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfLeaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kierownikLaboratoriumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteLeader;
        private System.Windows.Forms.Button btn_EditLeader;
        private System.Windows.Forms.Button btn_AddLeader;
        private System.Windows.Forms.DataGridView dgv_ListOfLeaders;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKlabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kierownikLaboratoriumBindingSource;

    }
}