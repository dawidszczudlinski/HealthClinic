﻿namespace HealthClinic
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_RegistrationDate = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.visits = new System.Windows.Forms.DataGridView();
            this.col_ID_visit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RegistrationData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_CancelVisit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visits)).BeginInit();
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
            // visits
            // 
            this.visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID_visit,
            this.col_Name,
            this.col_LastName,
            this.col_RegistrationData,
            this.col_State});
            this.visits.Location = new System.Drawing.Point(12, 249);
            this.visits.Name = "visits";
            this.visits.Size = new System.Drawing.Size(587, 207);
            this.visits.TabIndex = 1;
            // 
            // col_ID_visit
            // 
            this.col_ID_visit.HeaderText = "ID wizyty";
            this.col_ID_visit.Name = "col_ID_visit";
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
            // col_RegistrationData
            // 
            this.col_RegistrationData.HeaderText = "Data rejestracji";
            this.col_RegistrationData.Name = "col_RegistrationData";
            // 
            // col_State
            // 
            this.col_State.HeaderText = "Stan";
            this.col_State.Name = "col_State";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(488, 483);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(111, 40);
            this.btn_Confirm.TabIndex = 9;
            this.btn_Confirm.Text = "OK";
            this.btn_Confirm.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.visits);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowManageVisits";
            this.Text = "Zarządzaj wizytami";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visits)).EndInit();
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
        private System.Windows.Forms.DataGridView visits;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_CancelVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_visit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RegistrationData;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_State;
    }
}