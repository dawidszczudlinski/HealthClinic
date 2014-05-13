namespace HealthClinic
{
    partial class AdministratorAddEditExamination
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
            this.lbl_ExaminationName = new System.Windows.Forms.Label();
            this.lbl_ExaminationDescription = new System.Windows.Forms.Label();
            this.txt_ExaminationName = new System.Windows.Forms.TextBox();
            this.txt_ExaminationDescription = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ExaminationName
            // 
            this.lbl_ExaminationName.AutoSize = true;
            this.lbl_ExaminationName.Location = new System.Drawing.Point(24, 26);
            this.lbl_ExaminationName.Name = "lbl_ExaminationName";
            this.lbl_ExaminationName.Size = new System.Drawing.Size(43, 13);
            this.lbl_ExaminationName.TabIndex = 1;
            this.lbl_ExaminationName.Text = "Nazwa:";
            // 
            // lbl_ExaminationDescription
            // 
            this.lbl_ExaminationDescription.AutoSize = true;
            this.lbl_ExaminationDescription.Location = new System.Drawing.Point(27, 61);
            this.lbl_ExaminationDescription.Name = "lbl_ExaminationDescription";
            this.lbl_ExaminationDescription.Size = new System.Drawing.Size(31, 13);
            this.lbl_ExaminationDescription.TabIndex = 2;
            this.lbl_ExaminationDescription.Text = "Opis:";
            // 
            // txt_ExaminationName
            // 
            this.txt_ExaminationName.Location = new System.Drawing.Point(94, 23);
            this.txt_ExaminationName.Name = "txt_ExaminationName";
            this.txt_ExaminationName.Size = new System.Drawing.Size(147, 20);
            this.txt_ExaminationName.TabIndex = 4;
            // 
            // txt_ExaminationDescription
            // 
            this.txt_ExaminationDescription.Location = new System.Drawing.Point(94, 58);
            this.txt_ExaminationDescription.Name = "txt_ExaminationDescription";
            this.txt_ExaminationDescription.Size = new System.Drawing.Size(147, 20);
            this.txt_ExaminationDescription.TabIndex = 5;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(24, 98);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(97, 38);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(144, 98);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(97, 38);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Anuluj";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AdministratorAddEditExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 166);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_ExaminationDescription);
            this.Controls.Add(this.txt_ExaminationName);
            this.Controls.Add(this.lbl_ExaminationDescription);
            this.Controls.Add(this.lbl_ExaminationName);
            this.Name = "AdministratorAddEditExamination";
            this.Text = "Zarządzaj badaniem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ExaminationName;
        private System.Windows.Forms.Label lbl_ExaminationDescription;
        private System.Windows.Forms.TextBox txt_ExaminationName;
        private System.Windows.Forms.TextBox txt_ExaminationDescription;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}