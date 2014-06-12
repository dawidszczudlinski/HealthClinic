namespace HealthClinic
{
    partial class DoctorRealizePhysicalExamination
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
            this.lbl_IDExamination = new System.Windows.Forms.Label();
            this.lbl_ExaminationCode = new System.Windows.Forms.Label();
            this.lbl_ExaminationName = new System.Windows.Forms.Label();
            this.lbl_ExaminationResult = new System.Windows.Forms.Label();
            this.txt_ExaminationResult = new System.Windows.Forms.TextBox();
            this.txt_IDExamination = new System.Windows.Forms.TextBox();
            this.txt_ExaminationCode = new System.Windows.Forms.TextBox();
            this.txt_ExaminationName = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_ChoiceExamination = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_IDExamination
            // 
            this.lbl_IDExamination.AutoSize = true;
            this.lbl_IDExamination.Location = new System.Drawing.Point(9, 16);
            this.lbl_IDExamination.Name = "lbl_IDExamination";
            this.lbl_IDExamination.Size = new System.Drawing.Size(62, 13);
            this.lbl_IDExamination.TabIndex = 0;
            this.lbl_IDExamination.Text = "ID badania:";
            // 
            // lbl_ExaminationCode
            // 
            this.lbl_ExaminationCode.AutoSize = true;
            this.lbl_ExaminationCode.Location = new System.Drawing.Point(9, 65);
            this.lbl_ExaminationCode.Name = "lbl_ExaminationCode";
            this.lbl_ExaminationCode.Size = new System.Drawing.Size(70, 13);
            this.lbl_ExaminationCode.TabIndex = 1;
            this.lbl_ExaminationCode.Text = "Kod badania:";
            // 
            // lbl_ExaminationName
            // 
            this.lbl_ExaminationName.AutoSize = true;
            this.lbl_ExaminationName.Location = new System.Drawing.Point(9, 113);
            this.lbl_ExaminationName.Name = "lbl_ExaminationName";
            this.lbl_ExaminationName.Size = new System.Drawing.Size(84, 13);
            this.lbl_ExaminationName.TabIndex = 2;
            this.lbl_ExaminationName.Text = "Nazwa badania:";
            // 
            // lbl_ExaminationResult
            // 
            this.lbl_ExaminationResult.AutoSize = true;
            this.lbl_ExaminationResult.Location = new System.Drawing.Point(9, 157);
            this.lbl_ExaminationResult.Name = "lbl_ExaminationResult";
            this.lbl_ExaminationResult.Size = new System.Drawing.Size(40, 13);
            this.lbl_ExaminationResult.TabIndex = 3;
            this.lbl_ExaminationResult.Text = "Wynik:";
            // 
            // txt_ExaminationResult
            // 
            this.txt_ExaminationResult.Location = new System.Drawing.Point(12, 187);
            this.txt_ExaminationResult.Multiline = true;
            this.txt_ExaminationResult.Name = "txt_ExaminationResult";
            this.txt_ExaminationResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ExaminationResult.Size = new System.Drawing.Size(285, 147);
            this.txt_ExaminationResult.TabIndex = 7;
            // 
            // txt_IDExamination
            // 
            this.txt_IDExamination.Location = new System.Drawing.Point(116, 9);
            this.txt_IDExamination.Name = "txt_IDExamination";
            this.txt_IDExamination.Size = new System.Drawing.Size(78, 20);
            this.txt_IDExamination.TabIndex = 8;
            // 
            // txt_ExaminationCode
            // 
            this.txt_ExaminationCode.Location = new System.Drawing.Point(116, 58);
            this.txt_ExaminationCode.Name = "txt_ExaminationCode";
            this.txt_ExaminationCode.Size = new System.Drawing.Size(78, 20);
            this.txt_ExaminationCode.TabIndex = 9;
            // 
            // txt_ExaminationName
            // 
            this.txt_ExaminationName.Location = new System.Drawing.Point(116, 106);
            this.txt_ExaminationName.Name = "txt_ExaminationName";
            this.txt_ExaminationName.Size = new System.Drawing.Size(181, 20);
            this.txt_ExaminationName.TabIndex = 10;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(48, 354);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(107, 48);
            this.btn_OK.TabIndex = 11;
            this.btn_OK.Text = "Zatwierdź";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(190, 354);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(107, 48);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Powrót";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_ChoiceExamination
            // 
            this.btn_ChoiceExamination.Location = new System.Drawing.Point(210, 30);
            this.btn_ChoiceExamination.Name = "btn_ChoiceExamination";
            this.btn_ChoiceExamination.Size = new System.Drawing.Size(87, 48);
            this.btn_ChoiceExamination.TabIndex = 13;
            this.btn_ChoiceExamination.Text = "Wybierz badanie";
            this.btn_ChoiceExamination.UseVisualStyleBackColor = true;
            this.btn_ChoiceExamination.Click += new System.EventHandler(this.btn_ChoiceExamination_Click);
            // 
            // DoctorRealizePhysicalExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 425);
            this.Controls.Add(this.btn_ChoiceExamination);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_ExaminationName);
            this.Controls.Add(this.txt_ExaminationCode);
            this.Controls.Add(this.txt_IDExamination);
            this.Controls.Add(this.txt_ExaminationResult);
            this.Controls.Add(this.lbl_ExaminationResult);
            this.Controls.Add(this.lbl_ExaminationName);
            this.Controls.Add(this.lbl_ExaminationCode);
            this.Controls.Add(this.lbl_IDExamination);
            this.Name = "DoctorRealizePhysicalExamination";
            this.Text = "Wykonaj badanie fizykalne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IDExamination;
        private System.Windows.Forms.Label lbl_ExaminationCode;
        private System.Windows.Forms.Label lbl_ExaminationName;
        private System.Windows.Forms.Label lbl_ExaminationResult;
        private System.Windows.Forms.TextBox txt_ExaminationResult;
        private System.Windows.Forms.TextBox txt_IDExamination;
        private System.Windows.Forms.TextBox txt_ExaminationCode;
        private System.Windows.Forms.TextBox txt_ExaminationName;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_ChoiceExamination;
    }
}