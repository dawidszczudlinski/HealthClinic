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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Choice = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.col_DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DoctorVisits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DoctorName,
            this.col_DoctorVisits});
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(307, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Choice
            // 
            this.btn_Choice.Location = new System.Drawing.Point(105, 225);
            this.btn_Choice.Name = "btn_Choice";
            this.btn_Choice.Size = new System.Drawing.Size(103, 39);
            this.btn_Choice.TabIndex = 1;
            this.btn_Choice.Text = "Wybierz";
            this.btn_Choice.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(226, 225);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(103, 39);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Wróć";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // col_DoctorName
            // 
            this.col_DoctorName.HeaderText = "Lekarz";
            this.col_DoctorName.Name = "col_DoctorName";
            this.col_DoctorName.Width = 150;
            // 
            // col_DoctorVisits
            // 
            this.col_DoctorVisits.HeaderText = "Liczba wizyt";
            this.col_DoctorVisits.Name = "col_DoctorVisits";
            // 
            // SelectionOfDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 277);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Choice);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SelectionOfDoctor";
            this.Text = "Wybierz lekarza";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Choice;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DoctorVisits;
    }
}