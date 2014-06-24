namespace HealthClinic
{
    partial class ReceptionistAddPatient
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
            this.txt_Addres = new System.Windows.Forms.TextBox();
            this.txt_Pesel = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Addres = new System.Windows.Forms.Label();
            this.lbl_Pesel = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_AssuranceNumber = new System.Windows.Forms.TextBox();
            this.lbl_AssuranceNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(205, 240);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(99, 43);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Anuluj";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(85, 240);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(99, 43);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_Addres
            // 
            this.txt_Addres.Location = new System.Drawing.Point(92, 158);
            this.txt_Addres.Name = "txt_Addres";
            this.txt_Addres.Size = new System.Drawing.Size(212, 20);
            this.txt_Addres.TabIndex = 4;
            // 
            // txt_Pesel
            // 
            this.txt_Pesel.Location = new System.Drawing.Point(92, 122);
            this.txt_Pesel.Name = "txt_Pesel";
            this.txt_Pesel.Size = new System.Drawing.Size(212, 20);
            this.txt_Pesel.TabIndex = 3;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(92, 37);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(212, 20);
            this.txt_Name.TabIndex = 0;
            // 
            // lbl_Addres
            // 
            this.lbl_Addres.AutoSize = true;
            this.lbl_Addres.Location = new System.Drawing.Point(28, 161);
            this.lbl_Addres.Name = "lbl_Addres";
            this.lbl_Addres.Size = new System.Drawing.Size(37, 13);
            this.lbl_Addres.TabIndex = 17;
            this.lbl_Addres.Text = "Adres:";
            // 
            // lbl_Pesel
            // 
            this.lbl_Pesel.AutoSize = true;
            this.lbl_Pesel.Location = new System.Drawing.Point(28, 125);
            this.lbl_Pesel.Name = "lbl_Pesel";
            this.lbl_Pesel.Size = new System.Drawing.Size(36, 13);
            this.lbl_Pesel.TabIndex = 16;
            this.lbl_Pesel.Text = "Pesel:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(28, 82);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(56, 13);
            this.lbl_LastName.TabIndex = 15;
            this.lbl_LastName.Text = "Nazwisko:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(28, 40);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(29, 13);
            this.lbl_Name.TabIndex = 14;
            this.lbl_Name.Text = "Imie:";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(92, 75);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(212, 20);
            this.txt_LastName.TabIndex = 1;
            // 
            // txt_AssuranceNumber
            // 
            this.txt_AssuranceNumber.Location = new System.Drawing.Point(145, 199);
            this.txt_AssuranceNumber.Name = "txt_AssuranceNumber";
            this.txt_AssuranceNumber.Size = new System.Drawing.Size(159, 20);
            this.txt_AssuranceNumber.TabIndex = 5;
            // 
            // lbl_AssuranceNumber
            // 
            this.lbl_AssuranceNumber.AutoSize = true;
            this.lbl_AssuranceNumber.Location = new System.Drawing.Point(27, 202);
            this.lbl_AssuranceNumber.Name = "lbl_AssuranceNumber";
            this.lbl_AssuranceNumber.Size = new System.Drawing.Size(112, 13);
            this.lbl_AssuranceNumber.TabIndex = 23;
            this.lbl_AssuranceNumber.Text = "Numer ubezpieczenia:";
            // 
            // ReceptionistAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 324);
            this.Controls.Add(this.txt_AssuranceNumber);
            this.Controls.Add(this.lbl_AssuranceNumber);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_Addres);
            this.Controls.Add(this.txt_Pesel);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Addres);
            this.Controls.Add(this.lbl_Pesel);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ReceptionistAddPatient";
            this.Text = "Dodaj pacjenta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReceptionistAddPatient_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox txt_Addres;
        private System.Windows.Forms.TextBox txt_Pesel;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Addres;
        private System.Windows.Forms.Label lbl_Pesel;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_AssuranceNumber;
        private System.Windows.Forms.Label lbl_AssuranceNumber;
    }
}