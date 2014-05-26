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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_RegistrationDate = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.dgv_ListOfVisits = new System.Windows.Forms.DataGridView();
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
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_CancelVisit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizytaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbl_RegistrationDate);
            this.groupBox1.Controls.Add(this.lbl_State);
            this.groupBox1.Controls.Add(this.lbl_LastName);
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(156, 160);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(111, 40);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Szukaj";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(356, 38);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lbl_RegistrationDate
            // 
            this.lbl_RegistrationDate.AutoSize = true;
            this.lbl_RegistrationDate.Location = new System.Drawing.Point(353, 16);
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
            this.dgv_ListOfVisits.AutoGenerateColumns = false;
            this.dgv_ListOfVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOfVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgv_ListOfVisits.DataSource = this.wizytaBindingSource;
            this.dgv_ListOfVisits.Location = new System.Drawing.Point(12, 249);
            this.dgv_ListOfVisits.MultiSelect = false;
            this.dgv_ListOfVisits.Name = "dgv_ListOfVisits";
            this.dgv_ListOfVisits.ReadOnly = true;
            this.dgv_ListOfVisits.Size = new System.Drawing.Size(587, 207);
            this.dgv_ListOfVisits.TabIndex = 1;
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
            // 
            // ShowManageVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 535);
            this.Controls.Add(this.btn_CancelVisit);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.dgv_ListOfVisits);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowManageVisits";
            this.Text = "Zarządzaj wizytami";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizytaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_RegistrationDate;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dgv_ListOfVisits;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_CancelVisit;
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