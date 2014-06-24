namespace HealthClinic
{
    partial class LaboratoryAssistantStart
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
            this.lbl_RegistrationDate = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Pesel = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_Filtr = new System.Windows.Forms.Label();
            this.lbl_Pesel = new System.Windows.Forms.Label();
            this.lbl_Imie = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.dgv_ListOfVisits = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_ServicePatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfVisits)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(19, 127);
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
            "Zle",
            "Wyk",
            "Anu_l"});
            this.cmb_State.Location = new System.Drawing.Point(117, 119);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(67, 21);
            this.cmb_State.TabIndex = 3;
            // 
            // lbl_RegistrationDate
            // 
            this.lbl_RegistrationDate.AutoSize = true;
            this.lbl_RegistrationDate.Location = new System.Drawing.Point(320, 29);
            this.lbl_RegistrationDate.Name = "lbl_RegistrationDate";
            this.lbl_RegistrationDate.Size = new System.Drawing.Size(80, 13);
            this.lbl_RegistrationDate.TabIndex = 8;
            this.lbl_RegistrationDate.Text = "Data rejestracji:";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(169, 163);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 50);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Szukaj";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Pesel
            // 
            this.txt_Pesel.Location = new System.Drawing.Point(117, 85);
            this.txt_Pesel.Name = "txt_Pesel";
            this.txt_Pesel.Size = new System.Drawing.Size(148, 20);
            this.txt_Pesel.TabIndex = 6;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(117, 59);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(148, 20);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(117, 29);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(148, 20);
            this.txt_LastName.TabIndex = 4;
            // 
            // lbl_Filtr
            // 
            this.lbl_Filtr.AutoSize = true;
            this.lbl_Filtr.Location = new System.Drawing.Point(19, 15);
            this.lbl_Filtr.Name = "lbl_Filtr";
            this.lbl_Filtr.Size = new System.Drawing.Size(23, 13);
            this.lbl_Filtr.TabIndex = 3;
            this.lbl_Filtr.Text = "Filtr";
            // 
            // lbl_Pesel
            // 
            this.lbl_Pesel.AutoSize = true;
            this.lbl_Pesel.Location = new System.Drawing.Point(19, 92);
            this.lbl_Pesel.Name = "lbl_Pesel";
            this.lbl_Pesel.Size = new System.Drawing.Size(44, 13);
            this.lbl_Pesel.TabIndex = 2;
            this.lbl_Pesel.Text = "PESEL:";
            // 
            // lbl_Imie
            // 
            this.lbl_Imie.AutoSize = true;
            this.lbl_Imie.Location = new System.Drawing.Point(19, 66);
            this.lbl_Imie.Name = "lbl_Imie";
            this.lbl_Imie.Size = new System.Drawing.Size(29, 13);
            this.lbl_Imie.TabIndex = 1;
            this.lbl_Imie.Text = "Imie:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(19, 36);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(56, 13);
            this.lbl_LastName.TabIndex = 0;
            this.lbl_LastName.Text = "Nazwisko:";
            // 
            // dgv_ListOfVisits
            // 
            this.dgv_ListOfVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOfVisits.Location = new System.Drawing.Point(12, 249);
            this.dgv_ListOfVisits.MultiSelect = false;
            this.dgv_ListOfVisits.Name = "dgv_ListOfVisits";
            this.dgv_ListOfVisits.ReadOnly = true;
            this.dgv_ListOfVisits.Size = new System.Drawing.Size(709, 196);
            this.dgv_ListOfVisits.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_Date);
            this.groupBox1.Controls.Add(this.lbl_State);
            this.groupBox1.Controls.Add(this.cmb_State);
            this.groupBox1.Controls.Add(this.lbl_RegistrationDate);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_Pesel);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_LastName);
            this.groupBox1.Controls.Add(this.lbl_Filtr);
            this.groupBox1.Controls.Add(this.lbl_Pesel);
            this.groupBox1.Controls.Add(this.lbl_Imie);
            this.groupBox1.Controls.Add(this.lbl_LastName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 231);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(308, 66);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.ShowCheckBox = true;
            this.dtp_Date.Size = new System.Drawing.Size(200, 20);
            this.dtp_Date.TabIndex = 4;
            // 
            // btn_ServicePatient
            // 
            this.btn_ServicePatient.Location = new System.Drawing.Point(533, 458);
            this.btn_ServicePatient.Name = "btn_ServicePatient";
            this.btn_ServicePatient.Size = new System.Drawing.Size(96, 50);
            this.btn_ServicePatient.TabIndex = 8;
            this.btn_ServicePatient.Text = "Obsługa";
            this.btn_ServicePatient.UseVisualStyleBackColor = true;
            this.btn_ServicePatient.Click += new System.EventHandler(this.btn_ServicePatient_Click);
            // 
            // LaboratoryAssistantStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 520);
            this.Controls.Add(this.btn_ServicePatient);
            this.Controls.Add(this.dgv_ListOfVisits);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LaboratoryAssistantStart";
            this.Text = "Wybierz badanie";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaboratoryAssistantStart_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfVisits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.Label lbl_RegistrationDate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Pesel;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_Filtr;
        private System.Windows.Forms.Label lbl_Pesel;
        private System.Windows.Forms.Label lbl_Imie;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.DataGridView dgv_ListOfVisits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ServicePatient;
        private System.Windows.Forms.DateTimePicker dtp_Date;

    }
}