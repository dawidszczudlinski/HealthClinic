namespace HealthClinic
{
    partial class ManageVisit
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
            this.txt_Pesel = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Pesel = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Hour = new System.Windows.Forms.Label();
            this.lbl_Doctor = new System.Windows.Forms.Label();
            this.txt_Doctor = new System.Windows.Forms.TextBox();
            this.btn_ChooseDoctor = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.cb_Hour = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Minute = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Pesel);
            this.groupBox1.Controls.Add(this.txt_LastName);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.lbl_Pesel);
            this.groupBox1.Controls.Add(this.lbl_LastName);
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_Pesel
            // 
            this.txt_Pesel.Location = new System.Drawing.Point(101, 81);
            this.txt_Pesel.Name = "txt_Pesel";
            this.txt_Pesel.ReadOnly = true;
            this.txt_Pesel.Size = new System.Drawing.Size(166, 20);
            this.txt_Pesel.TabIndex = 5;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(101, 51);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.ReadOnly = true;
            this.txt_LastName.Size = new System.Drawing.Size(166, 20);
            this.txt_LastName.TabIndex = 4;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(101, 18);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(166, 20);
            this.txt_Name.TabIndex = 3;
            // 
            // lbl_Pesel
            // 
            this.lbl_Pesel.AutoSize = true;
            this.lbl_Pesel.Location = new System.Drawing.Point(19, 88);
            this.lbl_Pesel.Name = "lbl_Pesel";
            this.lbl_Pesel.Size = new System.Drawing.Size(44, 13);
            this.lbl_Pesel.TabIndex = 2;
            this.lbl_Pesel.Text = "PESEL:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(19, 58);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(56, 13);
            this.lbl_LastName.TabIndex = 1;
            this.lbl_LastName.Text = "Nazwisko:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(19, 25);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(29, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Imie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kalendarz:";
            // 
            // lbl_Hour
            // 
            this.lbl_Hour.AutoSize = true;
            this.lbl_Hour.Location = new System.Drawing.Point(249, 184);
            this.lbl_Hour.Name = "lbl_Hour";
            this.lbl_Hour.Size = new System.Drawing.Size(80, 13);
            this.lbl_Hour.TabIndex = 4;
            this.lbl_Hour.Text = "Godzina wizyty:";
            // 
            // lbl_Doctor
            // 
            this.lbl_Doctor.AutoSize = true;
            this.lbl_Doctor.Location = new System.Drawing.Point(249, 252);
            this.lbl_Doctor.Name = "lbl_Doctor";
            this.lbl_Doctor.Size = new System.Drawing.Size(42, 13);
            this.lbl_Doctor.TabIndex = 7;
            this.lbl_Doctor.Text = "Lekarz:";
            // 
            // txt_Doctor
            // 
            this.txt_Doctor.Location = new System.Drawing.Point(256, 277);
            this.txt_Doctor.Name = "txt_Doctor";
            this.txt_Doctor.ReadOnly = true;
            this.txt_Doctor.Size = new System.Drawing.Size(100, 20);
            this.txt_Doctor.TabIndex = 8;
            // 
            // btn_ChooseDoctor
            // 
            this.btn_ChooseDoctor.Location = new System.Drawing.Point(252, 345);
            this.btn_ChooseDoctor.Name = "btn_ChooseDoctor";
            this.btn_ChooseDoctor.Size = new System.Drawing.Size(100, 34);
            this.btn_ChooseDoctor.TabIndex = 9;
            this.btn_ChooseDoctor.Text = "Wybierz lekarza";
            this.btn_ChooseDoctor.UseVisualStyleBackColor = true;
            this.btn_ChooseDoctor.Click += new System.EventHandler(this.btn_ChooseDoctor_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(56, 412);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(104, 45);
            this.btn_Confirm.TabIndex = 10;
            this.btn_Confirm.Text = "Zatwierdź";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(200, 412);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(104, 45);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Powrót";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // dtp_Data
            // 
            this.dtp_Data.CustomFormat = "";
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Data.Location = new System.Drawing.Point(24, 252);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(200, 20);
            this.dtp_Data.TabIndex = 12;
            this.dtp_Data.Value = new System.DateTime(2014, 5, 30, 0, 0, 0, 0);
            // 
            // cb_Hour
            // 
            this.cb_Hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Hour.FormattingEnabled = true;
            this.cb_Hour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cb_Hour.Location = new System.Drawing.Point(252, 212);
            this.cb_Hour.Name = "cb_Hour";
            this.cb_Hour.Size = new System.Drawing.Size(39, 21);
            this.cb_Hour.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(297, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // cb_Minute
            // 
            this.cb_Minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Minute.FormattingEnabled = true;
            this.cb_Minute.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cb_Minute.Location = new System.Drawing.Point(317, 212);
            this.cb_Minute.Name = "cb_Minute";
            this.cb_Minute.Size = new System.Drawing.Size(39, 21);
            this.cb_Minute.TabIndex = 5;
            // 
            // ManageVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 501);
            this.Controls.Add(this.dtp_Data);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_ChooseDoctor);
            this.Controls.Add(this.txt_Doctor);
            this.Controls.Add(this.lbl_Doctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Minute);
            this.Controls.Add(this.lbl_Hour);
            this.Controls.Add(this.cb_Hour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageVisit";
            this.Text = "Zarządzaj wizytą";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManageVisit_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Pesel;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Pesel;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Hour;
        private System.Windows.Forms.Label lbl_Doctor;
        private System.Windows.Forms.TextBox txt_Doctor;
        private System.Windows.Forms.Button btn_ChooseDoctor;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DateTimePicker dtp_Data;
        private System.Windows.Forms.ComboBox cb_Hour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Minute;
    }
}