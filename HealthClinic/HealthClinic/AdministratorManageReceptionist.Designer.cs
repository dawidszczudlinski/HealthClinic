namespace HealthClinic
{
    partial class AdministratorManageReceptionist
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
            this.btn_DeleteReceptionist = new System.Windows.Forms.Button();
            this.btn_EditReceptionist = new System.Windows.Forms.Button();
            this.btn_AddReceptionist = new System.Windows.Forms.Button();
            this.dgv_ListOfReceptionists = new System.Windows.Forms.DataGridView();
            this.iDrejDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rejestratorkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfReceptionists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rejestratorkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DeleteReceptionist
            // 
            this.btn_DeleteReceptionist.Location = new System.Drawing.Point(307, 227);
            this.btn_DeleteReceptionist.Name = "btn_DeleteReceptionist";
            this.btn_DeleteReceptionist.Size = new System.Drawing.Size(119, 54);
            this.btn_DeleteReceptionist.TabIndex = 9;
            this.btn_DeleteReceptionist.Text = "Usuń";
            this.btn_DeleteReceptionist.UseVisualStyleBackColor = true;
            this.btn_DeleteReceptionist.Click += new System.EventHandler(this.btn_DeleteReceptionist_Click);
            // 
            // btn_EditReceptionist
            // 
            this.btn_EditReceptionist.Location = new System.Drawing.Point(167, 227);
            this.btn_EditReceptionist.Name = "btn_EditReceptionist";
            this.btn_EditReceptionist.Size = new System.Drawing.Size(119, 54);
            this.btn_EditReceptionist.TabIndex = 8;
            this.btn_EditReceptionist.Text = "Edytuj";
            this.btn_EditReceptionist.UseVisualStyleBackColor = true;
            this.btn_EditReceptionist.Click += new System.EventHandler(this.btn_EditReceptionist_Click);
            // 
            // btn_AddReceptionist
            // 
            this.btn_AddReceptionist.Location = new System.Drawing.Point(27, 227);
            this.btn_AddReceptionist.Name = "btn_AddReceptionist";
            this.btn_AddReceptionist.Size = new System.Drawing.Size(119, 54);
            this.btn_AddReceptionist.TabIndex = 7;
            this.btn_AddReceptionist.Text = "Dodaj";
            this.btn_AddReceptionist.UseVisualStyleBackColor = true;
            this.btn_AddReceptionist.Click += new System.EventHandler(this.btn_AddReceptionist_Click);
            // 
            // dgv_ListOfReceptionists
            // 
            this.dgv_ListOfReceptionists.AllowUserToAddRows = false;
            this.dgv_ListOfReceptionists.AllowUserToDeleteRows = false;
            this.dgv_ListOfReceptionists.AutoGenerateColumns = false;
            this.dgv_ListOfReceptionists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOfReceptionists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDrejDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dgv_ListOfReceptionists.DataSource = this.rejestratorkaBindingSource;
            this.dgv_ListOfReceptionists.Location = new System.Drawing.Point(28, 60);
            this.dgv_ListOfReceptionists.MultiSelect = false;
            this.dgv_ListOfReceptionists.Name = "dgv_ListOfReceptionists";
            this.dgv_ListOfReceptionists.ReadOnly = true;
            this.dgv_ListOfReceptionists.Size = new System.Drawing.Size(561, 150);
            this.dgv_ListOfReceptionists.TabIndex = 6;
            // 
            // iDrejDataGridViewTextBoxColumn
            // 
            this.iDrejDataGridViewTextBoxColumn.DataPropertyName = "ID_rej";
            this.iDrejDataGridViewTextBoxColumn.HeaderText = "ID_rej";
            this.iDrejDataGridViewTextBoxColumn.Name = "iDrejDataGridViewTextBoxColumn";
            this.iDrejDataGridViewTextBoxColumn.ReadOnly = true;
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
            // rejestratorkaBindingSource
            // 
            this.rejestratorkaBindingSource.DataSource = typeof(HealthClinic.Rejestratorka);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Description.Location = new System.Drawing.Point(23, 22);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(208, 26);
            this.lbl_Description.TabIndex = 5;
            this.lbl_Description.Text = "Lista recepcjonistów";
            // 
            // AdministratorManageReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 357);
            this.Controls.Add(this.btn_DeleteReceptionist);
            this.Controls.Add(this.btn_EditReceptionist);
            this.Controls.Add(this.btn_AddReceptionist);
            this.Controls.Add(this.dgv_ListOfReceptionists);
            this.Controls.Add(this.lbl_Description);
            this.Name = "AdministratorManageReceptionist";
            this.Text = "Zarządzaj recepcjonistami";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfReceptionists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rejestratorkaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteReceptionist;
        private System.Windows.Forms.Button btn_EditReceptionist;
        private System.Windows.Forms.Button btn_AddReceptionist;
        private System.Windows.Forms.DataGridView dgv_ListOfReceptionists;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDrejDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rejestratorkaBindingSource;
    }
}