namespace HealthClinic
{
    partial class DoctorStart
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
            this.dgv_visits = new System.Windows.Forms.DataGridView();
            this.btn_ChoiceVisit = new System.Windows.Forms.Button();
            this.lbl_Filtr = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_RegistrationDate = new System.Windows.Forms.Label();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.lbl_State = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visits)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_visits
            // 
            this.dgv_visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_visits.Location = new System.Drawing.Point(21, 262);
            this.dgv_visits.MultiSelect = false;
            this.dgv_visits.Name = "dgv_visits";
            this.dgv_visits.ReadOnly = true;
            this.dgv_visits.Size = new System.Drawing.Size(546, 192);
            this.dgv_visits.TabIndex = 2;
            // 
            // btn_ChoiceVisit
            // 
            this.btn_ChoiceVisit.Location = new System.Drawing.Point(439, 460);
            this.btn_ChoiceVisit.Name = "btn_ChoiceVisit";
            this.btn_ChoiceVisit.Size = new System.Drawing.Size(96, 50);
            this.btn_ChoiceVisit.TabIndex = 8;
            this.btn_ChoiceVisit.Text = "Wybierz wizytę";
            this.btn_ChoiceVisit.UseVisualStyleBackColor = true;
            this.btn_ChoiceVisit.Click += new System.EventHandler(this.btn_ChoiceVisit_Click);
            // 
            // lbl_Filtr
            // 
            this.lbl_Filtr.AutoSize = true;
            this.lbl_Filtr.Location = new System.Drawing.Point(196, 26);
            this.lbl_Filtr.Name = "lbl_Filtr";
            this.lbl_Filtr.Size = new System.Drawing.Size(23, 13);
            this.lbl_Filtr.TabIndex = 3;
            this.lbl_Filtr.Text = "Filtr";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(217, 163);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 48);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Szukaj";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_RegistrationDate
            // 
            this.lbl_RegistrationDate.AutoSize = true;
            this.lbl_RegistrationDate.Location = new System.Drawing.Point(303, 59);
            this.lbl_RegistrationDate.Name = "lbl_RegistrationDate";
            this.lbl_RegistrationDate.Size = new System.Drawing.Size(80, 13);
            this.lbl_RegistrationDate.TabIndex = 8;
            this.lbl_RegistrationDate.Text = "Data rejestracji:";
            // 
            // cmb_State
            // 
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.Items.AddRange(new object[] {
            "",
            "rej",
            "rozp",
            "zak",
            "odw"});
            this.cmb_State.Location = new System.Drawing.Point(91, 76);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(92, 21);
            this.cmb_State.TabIndex = 10;
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(34, 84);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(32, 13);
            this.lbl_State.TabIndex = 11;
            this.lbl_State.Text = "Stan:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_Date);
            this.groupBox1.Controls.Add(this.lbl_State);
            this.groupBox1.Controls.Add(this.cmb_State);
            this.groupBox1.Controls.Add(this.lbl_RegistrationDate);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.lbl_Filtr);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(297, 86);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.ShowCheckBox = true;
            this.dtp_Date.Size = new System.Drawing.Size(200, 20);
            this.dtp_Date.TabIndex = 13;
            // 
            // DoctorStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 531);
            this.Controls.Add(this.dgv_visits);
            this.Controls.Add(this.btn_ChoiceVisit);
            this.Controls.Add(this.groupBox1);
            this.Name = "DoctorStart";
            this.Text = "Wybierz wizytę";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_visits;
        private System.Windows.Forms.Button btn_ChoiceVisit;
        private System.Windows.Forms.Label lbl_Filtr;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_RegistrationDate;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_Date;

    }
}