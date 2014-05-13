﻿namespace HealthClinic
{
    partial class DoctorPhysicalExamination
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
            this.dgv_PhysicalExamination = new System.Windows.Forms.DataGridView();
            this.col_IDExamination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExaminationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExaminationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExaminationResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExaminationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_PhysicalExamination = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhysicalExamination)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PhysicalExamination
            // 
            this.dgv_PhysicalExamination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhysicalExamination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IDExamination,
            this.col_ExaminationCode,
            this.col_ExaminationName,
            this.col_ExaminationResult,
            this.col_ExaminationDate});
            this.dgv_PhysicalExamination.Location = new System.Drawing.Point(21, 72);
            this.dgv_PhysicalExamination.Name = "dgv_PhysicalExamination";
            this.dgv_PhysicalExamination.Size = new System.Drawing.Size(552, 231);
            this.dgv_PhysicalExamination.TabIndex = 0;
            // 
            // col_IDExamination
            // 
            this.col_IDExamination.HeaderText = "ID badania";
            this.col_IDExamination.Name = "col_IDExamination";
            // 
            // col_ExaminationCode
            // 
            this.col_ExaminationCode.HeaderText = "Kod badania";
            this.col_ExaminationCode.Name = "col_ExaminationCode";
            // 
            // col_ExaminationName
            // 
            this.col_ExaminationName.HeaderText = "Nazwa";
            this.col_ExaminationName.Name = "col_ExaminationName";
            // 
            // col_ExaminationResult
            // 
            this.col_ExaminationResult.HeaderText = "Wynik";
            this.col_ExaminationResult.Name = "col_ExaminationResult";
            // 
            // col_ExaminationDate
            // 
            this.col_ExaminationDate.HeaderText = "Data wykonania";
            this.col_ExaminationDate.Name = "col_ExaminationDate";
            // 
            // lbl_PhysicalExamination
            // 
            this.lbl_PhysicalExamination.AutoSize = true;
            this.lbl_PhysicalExamination.Location = new System.Drawing.Point(18, 28);
            this.lbl_PhysicalExamination.Name = "lbl_PhysicalExamination";
            this.lbl_PhysicalExamination.Size = new System.Drawing.Size(177, 13);
            this.lbl_PhysicalExamination.TabIndex = 1;
            this.lbl_PhysicalExamination.Text = "Badania fizykalne związane z wizytą";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(76, 343);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(103, 47);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Powrót";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(217, 343);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(103, 47);
            this.btn_Show.TabIndex = 3;
            this.btn_Show.Text = "Pokaż badanie";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(358, 343);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(103, 47);
            this.btn_New.TabIndex = 4;
            this.btn_New.Text = "Nowe badanie";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // DoctorPhysicalExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 472);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_PhysicalExamination);
            this.Controls.Add(this.dgv_PhysicalExamination);
            this.Name = "DoctorPhysicalExamination";
            this.Text = "Badania fizykalne";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhysicalExamination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PhysicalExamination;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDExamination;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExaminationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExaminationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExaminationResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExaminationDate;
        private System.Windows.Forms.Label lbl_PhysicalExamination;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_New;
    }
}