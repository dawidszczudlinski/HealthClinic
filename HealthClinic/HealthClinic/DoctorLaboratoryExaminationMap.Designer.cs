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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.dgv_LaboratoryExamination = new System.Windows.Forms.DataGridView();
            this.col_ExaminationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExaminationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LaboratoryExamination)).BeginInit();
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
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(67, 213);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(107, 48);
            this.btn_OK.TabIndex = 16;
            this.btn_OK.Text = "Zatwierdź";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // dgv_LaboratoryExamination
            // 
            this.dgv_LaboratoryExamination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LaboratoryExamination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ExaminationCode,
            this.col_ExaminationName});
            this.dgv_LaboratoryExamination.Location = new System.Drawing.Point(31, 2);
            this.dgv_LaboratoryExamination.Name = "dgv_LaboratoryExamination";
            this.dgv_LaboratoryExamination.Size = new System.Drawing.Size(285, 192);
            this.dgv_LaboratoryExamination.TabIndex = 15;
            // 
            // col_ExaminationCode
            // 
            this.col_ExaminationCode.HeaderText = "Kod badania";
            this.col_ExaminationCode.Name = "col_ExaminationCode";
            this.col_ExaminationCode.Width = 90;
            // 
            // col_ExaminationName
            // 
            this.col_ExaminationName.HeaderText = "Nazwa badania";
            this.col_ExaminationName.Name = "col_ExaminationName";
            this.col_ExaminationName.Width = 150;
            // 
            // DoctorLaboratoryExaminationMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 262);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dgv_LaboratoryExamination);
            this.Name = "DoctorLaboratoryExaminationMap";
            this.Text = "Wybierz badanie";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LaboratoryExamination)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridView dgv_LaboratoryExamination;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExaminationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExaminationName;
    }
}