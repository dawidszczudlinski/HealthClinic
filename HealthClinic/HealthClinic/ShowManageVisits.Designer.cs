namespace HealthClinic
{
    partial class ShowManageVisits
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_RegistrationDate = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.dgv_ListOfVisits = new System.Windows.Forms.DataGridView();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_CancelVisit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_State);
            this.groupBox1.Controls.Add(this.dtp_Date);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_LastName);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.lbl_RegistrationDate);
            this.groupBox1.Controls.Add(this.lbl_State);
            this.groupBox1.Controls.Add(this.lbl_LastName);
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.cmb_State.Location = new System.Drawing.Point(125, 117);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(92, 21);
            this.cmb_State.TabIndex = 15;
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(337, 61);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.ShowCheckBox = true;
            this.dtp_Date.Size = new System.Drawing.Size(200, 20);
            this.dtp_Date.TabIndex = 14;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(156, 160);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(111, 40);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Szukaj";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(125, 73);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(142, 20);
            this.txt_LastName.TabIndex = 5;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(125, 39);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(142, 20);
            this.txt_Name.TabIndex = 4;
            // 
            // lbl_RegistrationDate
            // 
            this.lbl_RegistrationDate.AutoSize = true;
            this.lbl_RegistrationDate.Location = new System.Drawing.Point(392, 25);
            this.lbl_RegistrationDate.Name = "lbl_RegistrationDate";
            this.lbl_RegistrationDate.Size = new System.Drawing.Size(80, 13);
            this.lbl_RegistrationDate.TabIndex = 3;
            this.lbl_RegistrationDate.Text = "Data rejestracji:";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(35, 120);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(32, 13);
            this.lbl_State.TabIndex = 2;
            this.lbl_State.Text = "Stan:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(35, 80);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(56, 13);
            this.lbl_LastName.TabIndex = 1;
            this.lbl_LastName.Text = "Nazwisko:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(35, 46);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(29, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Imie:";
            // 
            // dgv_ListOfVisits
            // 
            this.dgv_ListOfVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOfVisits.Location = new System.Drawing.Point(12, 248);
            this.dgv_ListOfVisits.MultiSelect = false;
            this.dgv_ListOfVisits.Name = "dgv_ListOfVisits";
            this.dgv_ListOfVisits.ReadOnly = true;
            this.dgv_ListOfVisits.Size = new System.Drawing.Size(816, 207);
            this.dgv_ListOfVisits.TabIndex = 1;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(488, 483);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(111, 40);
            this.btn_Confirm.TabIndex = 9;
            this.btn_Confirm.Text = "OK";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_CancelVisit
            // 
            this.btn_CancelVisit.Location = new System.Drawing.Point(349, 483);
            this.btn_CancelVisit.Name = "btn_CancelVisit";
            this.btn_CancelVisit.Size = new System.Drawing.Size(111, 40);
            this.btn_CancelVisit.TabIndex = 10;
            this.btn_CancelVisit.Text = "Anuluj wizytę";
            this.btn_CancelVisit.UseVisualStyleBackColor = true;
            this.btn_CancelVisit.Click += new System.EventHandler(this.btn_CancelVisit_Click);
            // 
            // ShowManageVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 535);
            this.Controls.Add(this.btn_CancelVisit);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.dgv_ListOfVisits);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowManageVisits";
            this.Text = "Zarządzaj wizytami";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfVisits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_RegistrationDate;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_ListOfVisits;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_CancelVisit;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.ComboBox cmb_State;
    }
}