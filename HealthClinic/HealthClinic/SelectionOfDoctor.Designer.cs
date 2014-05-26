namespace HealthClinic
{
    partial class SelectionOfDoctor
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
            this.dgv_ListOfDoctors = new System.Windows.Forms.DataGridView();
            this.col_DoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DoctorLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DoctorVisits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Choice = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListOfDoctors
            // 
            this.dgv_ListOfDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOfDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DoctorID,
            this.col_DoctorName,
            this.col_DoctorLastName,
            this.col_DoctorVisits});
            this.dgv_ListOfDoctors.Location = new System.Drawing.Point(12, 12);
            this.dgv_ListOfDoctors.MultiSelect = false;
            this.dgv_ListOfDoctors.Name = "dgv_ListOfDoctors";
            this.dgv_ListOfDoctors.ReadOnly = true;
            this.dgv_ListOfDoctors.Size = new System.Drawing.Size(507, 196);
            this.dgv_ListOfDoctors.TabIndex = 0;
            // 
            // col_DoctorID
            // 
            this.col_DoctorID.HeaderText = "ID lekarza";
            this.col_DoctorID.Name = "col_DoctorID";
            this.col_DoctorID.ReadOnly = true;
            // 
            // col_DoctorName
            // 
            this.col_DoctorName.HeaderText = "Imie";
            this.col_DoctorName.Name = "col_DoctorName";
            this.col_DoctorName.ReadOnly = true;
            // 
            // col_DoctorLastName
            // 
            this.col_DoctorLastName.HeaderText = "Nazwisko";
            this.col_DoctorLastName.Name = "col_DoctorLastName";
            this.col_DoctorLastName.ReadOnly = true;
            // 
            // col_DoctorVisits
            // 
            this.col_DoctorVisits.HeaderText = "Liczba wizyt";
            this.col_DoctorVisits.Name = "col_DoctorVisits";
            this.col_DoctorVisits.ReadOnly = true;
            // 
            // btn_Choice
            // 
            this.btn_Choice.Location = new System.Drawing.Point(105, 225);
            this.btn_Choice.Name = "btn_Choice";
            this.btn_Choice.Size = new System.Drawing.Size(103, 39);
            this.btn_Choice.TabIndex = 1;
            this.btn_Choice.Text = "Wybierz";
            this.btn_Choice.UseVisualStyleBackColor = true;
            this.btn_Choice.Click += new System.EventHandler(this.btn_Choice_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(226, 225);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(103, 39);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Wróć";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // SelectionOfDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 277);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Choice);
            this.Controls.Add(this.dgv_ListOfDoctors);
            this.Name = "SelectionOfDoctor";
            this.Text = "Wybierz lekarza";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfDoctors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListOfDoctors;
        private System.Windows.Forms.Button btn_Choice;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DoctorLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DoctorVisits;
    }
}