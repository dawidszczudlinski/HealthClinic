namespace HealthClinic
{
    partial class RegisterVisit
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Pesel = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_Filtr = new System.Windows.Forms.Label();
            this.lbl_Pesel = new System.Windows.Forms.Label();
            this.lbl_Imie = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.dgv_ListOfPatients = new System.Windows.Forms.DataGridView();
            this.iDpacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrubezpieczeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacjentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Visit = new System.Windows.Forms.Button();
            this.Zakończ = new System.Windows.Forms.Button();
            this.btn_AddPatient = new System.Windows.Forms.Button();
            this.btn_EditPatient = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_Pesel);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_LastName);
            this.groupBox1.Controls.Add(this.lbl_Filtr);
            this.groupBox1.Controls.Add(this.lbl_Pesel);
            this.groupBox1.Controls.Add(this.lbl_Imie);
            this.groupBox1.Controls.Add(this.lbl_LastName);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(304, 58);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 50);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Szukaj";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Pesel
            // 
            this.txt_Pesel.Location = new System.Drawing.Point(117, 100);
            this.txt_Pesel.Name = "txt_Pesel";
            this.txt_Pesel.Size = new System.Drawing.Size(148, 20);
            this.txt_Pesel.TabIndex = 2;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(117, 74);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(148, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(117, 44);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(148, 20);
            this.txt_LastName.TabIndex = 0;
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
            this.lbl_Pesel.Location = new System.Drawing.Point(19, 107);
            this.lbl_Pesel.Name = "lbl_Pesel";
            this.lbl_Pesel.Size = new System.Drawing.Size(44, 13);
            this.lbl_Pesel.TabIndex = 2;
            this.lbl_Pesel.Text = "PESEL:";
            // 
            // lbl_Imie
            // 
            this.lbl_Imie.AutoSize = true;
            this.lbl_Imie.Location = new System.Drawing.Point(19, 81);
            this.lbl_Imie.Name = "lbl_Imie";
            this.lbl_Imie.Size = new System.Drawing.Size(29, 13);
            this.lbl_Imie.TabIndex = 1;
            this.lbl_Imie.Text = "Imie:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(19, 51);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(56, 13);
            this.lbl_LastName.TabIndex = 0;
            this.lbl_LastName.Text = "Nazwisko:";
            // 
            // dgv_ListOfPatients
            // 
            this.dgv_ListOfPatients.AutoGenerateColumns = false;
            this.dgv_ListOfPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOfPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpacDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.nrubezpieczeniaDataGridViewTextBoxColumn});
            this.dgv_ListOfPatients.DataSource = this.pacjentBindingSource;
            this.dgv_ListOfPatients.Location = new System.Drawing.Point(12, 191);
            this.dgv_ListOfPatients.MultiSelect = false;
            this.dgv_ListOfPatients.Name = "dgv_ListOfPatients";
            this.dgv_ListOfPatients.ReadOnly = true;
            this.dgv_ListOfPatients.Size = new System.Drawing.Size(663, 153);
            this.dgv_ListOfPatients.TabIndex = 10;
            // 
            // iDpacDataGridViewTextBoxColumn
            // 
            this.iDpacDataGridViewTextBoxColumn.DataPropertyName = "ID_pac";
            this.iDpacDataGridViewTextBoxColumn.HeaderText = "ID_pac";
            this.iDpacDataGridViewTextBoxColumn.Name = "iDpacDataGridViewTextBoxColumn";
            this.iDpacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            this.pESELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrubezpieczeniaDataGridViewTextBoxColumn
            // 
            this.nrubezpieczeniaDataGridViewTextBoxColumn.DataPropertyName = "Nr_ubezpieczenia";
            this.nrubezpieczeniaDataGridViewTextBoxColumn.HeaderText = "Nr_ubezpieczenia";
            this.nrubezpieczeniaDataGridViewTextBoxColumn.Name = "nrubezpieczeniaDataGridViewTextBoxColumn";
            this.nrubezpieczeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacjentBindingSource
            // 
            this.pacjentBindingSource.DataSource = typeof(HealthClinic.Pacjent);
            // 
            // btn_Visit
            // 
            this.btn_Visit.Location = new System.Drawing.Point(497, 378);
            this.btn_Visit.Name = "btn_Visit";
            this.btn_Visit.Size = new System.Drawing.Size(135, 45);
            this.btn_Visit.TabIndex = 8;
            this.btn_Visit.Text = "Wizyta";
            this.btn_Visit.UseVisualStyleBackColor = true;
            this.btn_Visit.Click += new System.EventHandler(this.btn_Visit_Click);
            // 
            // Zakończ
            // 
            this.Zakończ.Location = new System.Drawing.Point(339, 378);
            this.Zakończ.Name = "Zakończ";
            this.Zakończ.Size = new System.Drawing.Size(135, 45);
            this.Zakończ.TabIndex = 7;
            this.Zakończ.Text = "Zakończ";
            this.Zakończ.UseVisualStyleBackColor = true;
            this.Zakończ.Click += new System.EventHandler(this.Zakończ_Click);
            // 
            // btn_AddPatient
            // 
            this.btn_AddPatient.Location = new System.Drawing.Point(12, 378);
            this.btn_AddPatient.Name = "btn_AddPatient";
            this.btn_AddPatient.Size = new System.Drawing.Size(135, 45);
            this.btn_AddPatient.TabIndex = 5;
            this.btn_AddPatient.Text = "Dodaj pacjenta";
            this.btn_AddPatient.UseVisualStyleBackColor = true;
            this.btn_AddPatient.Click += new System.EventHandler(this.btn_AddPatient_Click);
            // 
            // btn_EditPatient
            // 
            this.btn_EditPatient.Location = new System.Drawing.Point(165, 378);
            this.btn_EditPatient.Name = "btn_EditPatient";
            this.btn_EditPatient.Size = new System.Drawing.Size(135, 45);
            this.btn_EditPatient.TabIndex = 6;
            this.btn_EditPatient.Text = "Edytuj pacjenta";
            this.btn_EditPatient.UseVisualStyleBackColor = true;
            this.btn_EditPatient.Click += new System.EventHandler(this.btn_EditPatient_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Olek\\Desktop\\HealthClinic\\HealthClinic\\HealthClinic\\Pomoc\\Pomoc.chm";
            // 
            // RegisterVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 435);
            this.Controls.Add(this.btn_EditPatient);
            this.Controls.Add(this.btn_AddPatient);
            this.Controls.Add(this.Zakończ);
            this.Controls.Add(this.btn_Visit);
            this.Controls.Add(this.dgv_ListOfPatients);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "RegisterVisit";
            this.Text = "Zarejestruj Wizytę";
            this.Load += new System.EventHandler(this.RegisterVisit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterVisit_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Filtr;
        private System.Windows.Forms.Label lbl_Pesel;
        private System.Windows.Forms.Label lbl_Imie;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.TextBox txt_Pesel;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_ListOfPatients;
        private System.Windows.Forms.Button btn_Visit;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrubezpieczeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pacjentBindingSource;
        private System.Windows.Forms.Button Zakończ;
        private System.Windows.Forms.Button btn_AddPatient;
        private System.Windows.Forms.Button btn_EditPatient;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}