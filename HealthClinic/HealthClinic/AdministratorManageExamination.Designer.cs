namespace HealthClinic
{
    partial class AdministratorManageExamination
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
            this.dgv_ListOfExaminations = new System.Windows.Forms.DataGridView();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.btn_DeleteExamination = new System.Windows.Forms.Button();
            this.btn_EditExamination = new System.Windows.Forms.Button();
            this.btn_AddExamination = new System.Windows.Forms.Button();
            this.slownikbadanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfExaminations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slownikbadanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListOfExaminations
            // 
            this.dgv_ListOfExaminations.AllowUserToAddRows = false;
            this.dgv_ListOfExaminations.AllowUserToDeleteRows = false;
            this.dgv_ListOfExaminations.AutoGenerateColumns = false;
            this.dgv_ListOfExaminations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOfExaminations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn});
            this.dgv_ListOfExaminations.DataSource = this.slownikbadanBindingSource;
            this.dgv_ListOfExaminations.Location = new System.Drawing.Point(31, 64);
            this.dgv_ListOfExaminations.MultiSelect = false;
            this.dgv_ListOfExaminations.Name = "dgv_ListOfExaminations";
            this.dgv_ListOfExaminations.ReadOnly = true;
            this.dgv_ListOfExaminations.Size = new System.Drawing.Size(507, 219);
            this.dgv_ListOfExaminations.TabIndex = 0;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Description.Location = new System.Drawing.Point(26, 22);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(124, 26);
            this.lbl_Description.TabIndex = 1;
            this.lbl_Description.Text = "Lista badań";
            // 
            // btn_DeleteExamination
            // 
            this.btn_DeleteExamination.Location = new System.Drawing.Point(346, 306);
            this.btn_DeleteExamination.Name = "btn_DeleteExamination";
            this.btn_DeleteExamination.Size = new System.Drawing.Size(119, 54);
            this.btn_DeleteExamination.TabIndex = 7;
            this.btn_DeleteExamination.Text = "Usuń badanie";
            this.btn_DeleteExamination.UseVisualStyleBackColor = true;
            this.btn_DeleteExamination.Click += new System.EventHandler(this.btn_DeleteExamination_Click);
            // 
            // btn_EditExamination
            // 
            this.btn_EditExamination.Location = new System.Drawing.Point(206, 306);
            this.btn_EditExamination.Name = "btn_EditExamination";
            this.btn_EditExamination.Size = new System.Drawing.Size(119, 54);
            this.btn_EditExamination.TabIndex = 6;
            this.btn_EditExamination.Text = "Edytuj badanie";
            this.btn_EditExamination.UseVisualStyleBackColor = true;
            this.btn_EditExamination.Click += new System.EventHandler(this.btn_EditExamination_Click);
            // 
            // btn_AddExamination
            // 
            this.btn_AddExamination.Location = new System.Drawing.Point(66, 306);
            this.btn_AddExamination.Name = "btn_AddExamination";
            this.btn_AddExamination.Size = new System.Drawing.Size(119, 54);
            this.btn_AddExamination.TabIndex = 5;
            this.btn_AddExamination.Text = "Dodaj badanie";
            this.btn_AddExamination.UseVisualStyleBackColor = true;
            this.btn_AddExamination.Click += new System.EventHandler(this.btn_AddExamination_Click);
            // 
            // slownikbadanBindingSource
            // 
            this.slownikbadanBindingSource.DataSource = typeof(HealthClinic.Slownik_badan);
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
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            this.typDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AdministratorManageExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 423);
            this.Controls.Add(this.btn_DeleteExamination);
            this.Controls.Add(this.btn_EditExamination);
            this.Controls.Add(this.btn_AddExamination);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.dgv_ListOfExaminations);
            this.Name = "AdministratorManageExamination";
            this.Text = "Zarządzaj badaniami";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfExaminations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slownikbadanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListOfExaminations;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Button btn_DeleteExamination;
        private System.Windows.Forms.Button btn_EditExamination;
        private System.Windows.Forms.Button btn_AddExamination;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource slownikbadanBindingSource;
    }
}