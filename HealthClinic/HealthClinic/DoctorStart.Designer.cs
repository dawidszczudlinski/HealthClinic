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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_State = new System.Windows.Forms.Label();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbl_RegistrationDate = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Pesel = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_Filtr = new System.Windows.Forms.Label();
            this.lbl_Pesel = new System.Windows.Forms.Label();
            this.lbl_Imie = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.visits = new System.Windows.Forms.DataGridView();
            this.iDwizDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtrejDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtzakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnozaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDpacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDrejDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDlekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lekarzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacjentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rejestratorkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wizytaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_ChoiceVisit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizytaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_State);
            this.groupBox1.Controls.Add(this.cmb_State);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.lbl_RegistrationDate);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_Pesel);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_LastName);
            this.groupBox1.Controls.Add(this.lbl_Filtr);
            this.groupBox1.Controls.Add(this.lbl_Pesel);
            this.groupBox1.Controls.Add(this.lbl_Imie);
            this.groupBox1.Controls.Add(this.lbl_LastName);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
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
            "Rej"});
            this.cmb_State.Location = new System.Drawing.Point(117, 119);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(67, 21);
            this.cmb_State.TabIndex = 10;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(323, 51);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
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
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Szukaj";
            this.btn_Search.UseVisualStyleBackColor = true;
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
            // visits
            // 
            this.visits.AutoGenerateColumns = false;
            this.visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDwizDataGridViewTextBoxColumn,
            this.dtrejDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dtzakDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.diagnozaDataGridViewTextBoxColumn,
            this.iDpacDataGridViewTextBoxColumn,
            this.iDrejDataGridViewTextBoxColumn,
            this.iDlekDataGridViewTextBoxColumn,
            this.lekarzDataGridViewTextBoxColumn,
            this.pacjentDataGridViewTextBoxColumn,
            this.rejestratorkaDataGridViewTextBoxColumn});
            this.visits.DataSource = this.wizytaBindingSource;
            this.visits.Location = new System.Drawing.Point(21, 249);
            this.visits.MultiSelect = false;
            this.visits.Name = "visits";
            this.visits.ReadOnly = true;
            this.visits.RowHeadersVisible = false;
            this.visits.Size = new System.Drawing.Size(514, 196);
            this.visits.TabIndex = 2;
            // 
            // iDwizDataGridViewTextBoxColumn
            // 
            this.iDwizDataGridViewTextBoxColumn.DataPropertyName = "ID_wiz";
            this.iDwizDataGridViewTextBoxColumn.HeaderText = "ID_wiz";
            this.iDwizDataGridViewTextBoxColumn.Name = "iDwizDataGridViewTextBoxColumn";
            this.iDwizDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtrejDataGridViewTextBoxColumn
            // 
            this.dtrejDataGridViewTextBoxColumn.DataPropertyName = "Dt_rej";
            this.dtrejDataGridViewTextBoxColumn.HeaderText = "Dt_rej";
            this.dtrejDataGridViewTextBoxColumn.Name = "dtrejDataGridViewTextBoxColumn";
            this.dtrejDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtzakDataGridViewTextBoxColumn
            // 
            this.dtzakDataGridViewTextBoxColumn.DataPropertyName = "Dt_zak";
            this.dtzakDataGridViewTextBoxColumn.HeaderText = "Dt_zak";
            this.dtzakDataGridViewTextBoxColumn.Name = "dtzakDataGridViewTextBoxColumn";
            this.dtzakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diagnozaDataGridViewTextBoxColumn
            // 
            this.diagnozaDataGridViewTextBoxColumn.DataPropertyName = "Diagnoza";
            this.diagnozaDataGridViewTextBoxColumn.HeaderText = "Diagnoza";
            this.diagnozaDataGridViewTextBoxColumn.Name = "diagnozaDataGridViewTextBoxColumn";
            this.diagnozaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDpacDataGridViewTextBoxColumn
            // 
            this.iDpacDataGridViewTextBoxColumn.DataPropertyName = "ID_pac";
            this.iDpacDataGridViewTextBoxColumn.HeaderText = "ID_pac";
            this.iDpacDataGridViewTextBoxColumn.Name = "iDpacDataGridViewTextBoxColumn";
            this.iDpacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDrejDataGridViewTextBoxColumn
            // 
            this.iDrejDataGridViewTextBoxColumn.DataPropertyName = "ID_rej";
            this.iDrejDataGridViewTextBoxColumn.HeaderText = "ID_rej";
            this.iDrejDataGridViewTextBoxColumn.Name = "iDrejDataGridViewTextBoxColumn";
            this.iDrejDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDlekDataGridViewTextBoxColumn
            // 
            this.iDlekDataGridViewTextBoxColumn.DataPropertyName = "ID_lek";
            this.iDlekDataGridViewTextBoxColumn.HeaderText = "ID_lek";
            this.iDlekDataGridViewTextBoxColumn.Name = "iDlekDataGridViewTextBoxColumn";
            this.iDlekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lekarzDataGridViewTextBoxColumn
            // 
            this.lekarzDataGridViewTextBoxColumn.DataPropertyName = "Lekarz";
            this.lekarzDataGridViewTextBoxColumn.HeaderText = "Lekarz";
            this.lekarzDataGridViewTextBoxColumn.Name = "lekarzDataGridViewTextBoxColumn";
            this.lekarzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacjentDataGridViewTextBoxColumn
            // 
            this.pacjentDataGridViewTextBoxColumn.DataPropertyName = "Pacjent";
            this.pacjentDataGridViewTextBoxColumn.HeaderText = "Pacjent";
            this.pacjentDataGridViewTextBoxColumn.Name = "pacjentDataGridViewTextBoxColumn";
            this.pacjentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rejestratorkaDataGridViewTextBoxColumn
            // 
            this.rejestratorkaDataGridViewTextBoxColumn.DataPropertyName = "Rejestratorka";
            this.rejestratorkaDataGridViewTextBoxColumn.HeaderText = "Rejestratorka";
            this.rejestratorkaDataGridViewTextBoxColumn.Name = "rejestratorkaDataGridViewTextBoxColumn";
            this.rejestratorkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wizytaBindingSource
            // 
            this.wizytaBindingSource.DataSource = typeof(HealthClinic.Wizyta);
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
            // DoctorStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 531);
            this.Controls.Add(this.btn_ChoiceVisit);
            this.Controls.Add(this.visits);
            this.Controls.Add(this.groupBox1);
            this.Name = "DoctorStart";
            this.Text = "Wybierz wizytę";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizytaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Pesel;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_Filtr;
        private System.Windows.Forms.Label lbl_Pesel;
        private System.Windows.Forms.Label lbl_Imie;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_RegistrationDate;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.DataGridView visits;
        private System.Windows.Forms.Button btn_ChoiceVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDwizDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtrejDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtzakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnozaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDrejDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDlekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lekarzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacjentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rejestratorkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wizytaBindingSource;

    }
}