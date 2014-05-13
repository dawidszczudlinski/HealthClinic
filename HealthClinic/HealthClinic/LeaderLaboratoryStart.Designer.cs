namespace HealthClinic
{
    partial class LeaderLaboratoryStart
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
            this.lbl_State = new System.Windows.Forms.Label();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_ServicePatient = new System.Windows.Forms.Button();
            this.btn_ShowExamination = new System.Windows.Forms.Button();
            this.visits = new System.Windows.Forms.DataGridView();
            this.col_ID_examination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExaminationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExaminationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RunTestData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.visits)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(24, 16);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(32, 13);
            this.lbl_State.TabIndex = 11;
            this.lbl_State.Text = "Stan:";
            // 
            // cmb_State
            // 
            this.cmb_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.Items.AddRange(new object[] {
            "Rej"});
            this.cmb_State.Location = new System.Drawing.Point(78, 16);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(67, 21);
            this.cmb_State.TabIndex = 10;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(204, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 28);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Szukaj";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_ServicePatient
            // 
            this.btn_ServicePatient.Location = new System.Drawing.Point(625, 277);
            this.btn_ServicePatient.Name = "btn_ServicePatient";
            this.btn_ServicePatient.Size = new System.Drawing.Size(96, 50);
            this.btn_ServicePatient.TabIndex = 14;
            this.btn_ServicePatient.Text = "Obsługa";
            this.btn_ServicePatient.UseVisualStyleBackColor = true;
            this.btn_ServicePatient.Click += new System.EventHandler(this.btn_ServicePatient_Click);
            // 
            // btn_ShowExamination
            // 
            this.btn_ShowExamination.Location = new System.Drawing.Point(503, 277);
            this.btn_ShowExamination.Name = "btn_ShowExamination";
            this.btn_ShowExamination.Size = new System.Drawing.Size(96, 50);
            this.btn_ShowExamination.TabIndex = 13;
            this.btn_ShowExamination.Text = "Pokaż";
            this.btn_ShowExamination.UseVisualStyleBackColor = true;
            this.btn_ShowExamination.Click += new System.EventHandler(this.btn_ShowExamination_Click);
            // 
            // visits
            // 
            this.visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID_examination,
            this.col_ExaminationCode,
            this.col_ExaminationName,
            this.col_Name,
            this.col_LastName,
            this.col_RunTestData,
            this.col_State});
            this.visits.Location = new System.Drawing.Point(12, 60);
            this.visits.Name = "visits";
            this.visits.RowHeadersVisible = false;
            this.visits.Size = new System.Drawing.Size(709, 196);
            this.visits.TabIndex = 15;
            // 
            // col_ID_examination
            // 
            this.col_ID_examination.HeaderText = "ID badania";
            this.col_ID_examination.Name = "col_ID_examination";
            // 
            // col_ExaminationCode
            // 
            this.col_ExaminationCode.HeaderText = "Kod badania";
            this.col_ExaminationCode.Name = "col_ExaminationCode";
            // 
            // col_ExaminationName
            // 
            this.col_ExaminationName.HeaderText = "Nazwa badania";
            this.col_ExaminationName.Name = "col_ExaminationName";
            // 
            // col_Name
            // 
            this.col_Name.HeaderText = "Imie";
            this.col_Name.Name = "col_Name";
            // 
            // col_LastName
            // 
            this.col_LastName.HeaderText = "Nazwisko";
            this.col_LastName.Name = "col_LastName";
            // 
            // col_RunTestData
            // 
            this.col_RunTestData.HeaderText = "Data zlecenia";
            this.col_RunTestData.Name = "col_RunTestData";
            // 
            // col_State
            // 
            this.col_State.HeaderText = "Stan";
            this.col_State.Name = "col_State";
            // 
            // LeaderLaboratoryStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 353);
            this.Controls.Add(this.visits);
            this.Controls.Add(this.btn_ServicePatient);
            this.Controls.Add(this.btn_ShowExamination);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.cmb_State);
            this.Controls.Add(this.btn_Search);
            this.Name = "LeaderLaboratoryStart";
            this.Text = "Wybierz badanie";
            ((System.ComponentModel.ISupportInitialize)(this.visits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ServicePatient;
        private System.Windows.Forms.Button btn_ShowExamination;
        private System.Windows.Forms.DataGridView visits;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_examination;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExaminationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExaminationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RunTestData;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_State;
    }
}