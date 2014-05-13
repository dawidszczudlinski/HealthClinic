namespace HealthClinic
{
    partial class AdministratorManageAccounts
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
            this.lbl_Description = new System.Windows.Forms.Label();
            this.dgv_ListOfAccounts = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtwygasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_AddAccount = new System.Windows.Forms.Button();
            this.btn_EditAccount = new System.Windows.Forms.Button();
            this.btn_DeleteAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Description.Location = new System.Drawing.Point(43, 31);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(105, 26);
            this.lbl_Description.TabIndex = 0;
            this.lbl_Description.Text = "Lista kont";
            // 
            // dgv_ListOfAccounts
            // 
            this.dgv_ListOfAccounts.AllowUserToAddRows = false;
            this.dgv_ListOfAccounts.AllowUserToDeleteRows = false;
            this.dgv_ListOfAccounts.AutoGenerateColumns = false;
            this.dgv_ListOfAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOfAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.hasloDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.rolaDataGridViewTextBoxColumn,
            this.dtwygasDataGridViewTextBoxColumn});
            this.dgv_ListOfAccounts.DataSource = this.kontoBindingSource;
            this.dgv_ListOfAccounts.Location = new System.Drawing.Point(12, 73);
            this.dgv_ListOfAccounts.MultiSelect = false;
            this.dgv_ListOfAccounts.Name = "dgv_ListOfAccounts";
            this.dgv_ListOfAccounts.ReadOnly = true;
            this.dgv_ListOfAccounts.Size = new System.Drawing.Size(561, 150);
            this.dgv_ListOfAccounts.TabIndex = 1;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hasloDataGridViewTextBoxColumn
            // 
            this.hasloDataGridViewTextBoxColumn.DataPropertyName = "Haslo";
            this.hasloDataGridViewTextBoxColumn.HeaderText = "Haslo";
            this.hasloDataGridViewTextBoxColumn.Name = "hasloDataGridViewTextBoxColumn";
            this.hasloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolaDataGridViewTextBoxColumn
            // 
            this.rolaDataGridViewTextBoxColumn.DataPropertyName = "rola";
            this.rolaDataGridViewTextBoxColumn.HeaderText = "rola";
            this.rolaDataGridViewTextBoxColumn.Name = "rolaDataGridViewTextBoxColumn";
            this.rolaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtwygasDataGridViewTextBoxColumn
            // 
            this.dtwygasDataGridViewTextBoxColumn.DataPropertyName = "Dt_wygas";
            this.dtwygasDataGridViewTextBoxColumn.HeaderText = "Dt_wygas";
            this.dtwygasDataGridViewTextBoxColumn.Name = "dtwygasDataGridViewTextBoxColumn";
            this.dtwygasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kontoBindingSource
            // 
            this.kontoBindingSource.DataSource = typeof(HealthClinic.Konto);
            // 
            // btn_AddAccount
            // 
            this.btn_AddAccount.Location = new System.Drawing.Point(48, 243);
            this.btn_AddAccount.Name = "btn_AddAccount";
            this.btn_AddAccount.Size = new System.Drawing.Size(119, 54);
            this.btn_AddAccount.TabIndex = 2;
            this.btn_AddAccount.Text = "Dodaj konto";
            this.btn_AddAccount.UseVisualStyleBackColor = true;
            this.btn_AddAccount.Click += new System.EventHandler(this.btn_AddAccount_Click);
            // 
            // btn_EditAccount
            // 
            this.btn_EditAccount.Location = new System.Drawing.Point(188, 243);
            this.btn_EditAccount.Name = "btn_EditAccount";
            this.btn_EditAccount.Size = new System.Drawing.Size(119, 54);
            this.btn_EditAccount.TabIndex = 3;
            this.btn_EditAccount.Text = "Edytuj konto";
            this.btn_EditAccount.UseVisualStyleBackColor = true;
            this.btn_EditAccount.Click += new System.EventHandler(this.btn_EditAccount_Click);
            // 
            // btn_DeleteAccount
            // 
            this.btn_DeleteAccount.Location = new System.Drawing.Point(328, 243);
            this.btn_DeleteAccount.Name = "btn_DeleteAccount";
            this.btn_DeleteAccount.Size = new System.Drawing.Size(119, 54);
            this.btn_DeleteAccount.TabIndex = 4;
            this.btn_DeleteAccount.Text = "Usuń konto";
            this.btn_DeleteAccount.UseVisualStyleBackColor = true;
            this.btn_DeleteAccount.Click += new System.EventHandler(this.btn_DeleteAccount_Click);
            // 
            // AdministratorManageAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 376);
            this.Controls.Add(this.btn_DeleteAccount);
            this.Controls.Add(this.btn_EditAccount);
            this.Controls.Add(this.btn_AddAccount);
            this.Controls.Add(this.dgv_ListOfAccounts);
            this.Controls.Add(this.lbl_Description);
            this.Name = "AdministratorManageAccounts";
            this.Text = "Zarządzaj kontami";
            this.Load += new System.EventHandler(this.AdministratorManageAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.DataGridView dgv_ListOfAccounts;
        private System.Windows.Forms.BindingSource kontoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtwygasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_AddAccount;
        private System.Windows.Forms.Button btn_EditAccount;
        private System.Windows.Forms.Button btn_DeleteAccount;
    }
}