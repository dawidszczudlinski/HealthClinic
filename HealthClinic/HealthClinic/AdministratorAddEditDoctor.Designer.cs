namespace HealthClinic
{
    partial class AdministratorAddEditDoctor
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
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_PESEL = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_PESEL = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txt_Npwz = new System.Windows.Forms.TextBox();
            this.lbl_Npwz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(146, 207);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(99, 43);
            this.btn_Cancel.TabIndex = 29;
            this.btn_Cancel.Text = "Anuluj";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(25, 207);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(99, 43);
            this.btn_OK.TabIndex = 28;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(86, 138);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(159, 20);
            this.txt_Address.TabIndex = 27;
            // 
            // txt_PESEL
            // 
            this.txt_PESEL.Location = new System.Drawing.Point(86, 102);
            this.txt_PESEL.MaxLength = 11;
            this.txt_PESEL.Name = "txt_PESEL";
            this.txt_PESEL.Size = new System.Drawing.Size(159, 20);
            this.txt_PESEL.TabIndex = 26;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(86, 59);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(159, 20);
            this.txt_LastName.TabIndex = 25;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(86, 17);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(159, 20);
            this.txt_FirstName.TabIndex = 24;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(22, 141);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(37, 13);
            this.lbl_Address.TabIndex = 23;
            this.lbl_Address.Text = "Adres:";
            // 
            // lbl_PESEL
            // 
            this.lbl_PESEL.AutoSize = true;
            this.lbl_PESEL.Location = new System.Drawing.Point(22, 105);
            this.lbl_PESEL.Name = "lbl_PESEL";
            this.lbl_PESEL.Size = new System.Drawing.Size(44, 13);
            this.lbl_PESEL.TabIndex = 22;
            this.lbl_PESEL.Text = "PESEL:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(22, 62);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(56, 13);
            this.lbl_LastName.TabIndex = 21;
            this.lbl_LastName.Text = "Nazwisko:";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(22, 20);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(29, 13);
            this.lbl_FirstName.TabIndex = 20;
            this.lbl_FirstName.Text = "Imie:";
            // 
            // txt_Npwz
            // 
            this.txt_Npwz.Location = new System.Drawing.Point(86, 173);
            this.txt_Npwz.Name = "txt_Npwz";
            this.txt_Npwz.Size = new System.Drawing.Size(159, 20);
            this.txt_Npwz.TabIndex = 31;
            // 
            // lbl_Npwz
            // 
            this.lbl_Npwz.AutoSize = true;
            this.lbl_Npwz.Location = new System.Drawing.Point(22, 176);
            this.lbl_Npwz.Name = "lbl_Npwz";
            this.lbl_Npwz.Size = new System.Drawing.Size(37, 13);
            this.lbl_Npwz.TabIndex = 30;
            this.lbl_Npwz.Text = "Npwz:";
            // 
            // AdministratorAddEditDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txt_Npwz);
            this.Controls.Add(this.lbl_Npwz);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_PESEL);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_PESEL);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_FirstName);
            this.Name = "AdministratorAddEditDoctor";
            this.Text = "Zarządzaj lekarzami";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_PESEL;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_PESEL;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox txt_Npwz;
        private System.Windows.Forms.Label lbl_Npwz;
    }
}