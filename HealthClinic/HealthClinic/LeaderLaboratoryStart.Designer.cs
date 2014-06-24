namespace HealthClinic
{
    partial class LeaderLaboratoryStart
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_ServicePatient = new System.Windows.Forms.Button();
            this.dgv_ListOfVisits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(24, 16);
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
            "Wyk",
            "Anu_L",
            "Anu_K",
            "Zatw"});
            this.cmb_State.Location = new System.Drawing.Point(78, 16);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(67, 21);
            this.cmb_State.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(204, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 28);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Szukaj";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_ServicePatient
            // 
            this.btn_ServicePatient.Location = new System.Drawing.Point(625, 277);
            this.btn_ServicePatient.Name = "btn_ServicePatient";
            this.btn_ServicePatient.Size = new System.Drawing.Size(96, 50);
            this.btn_ServicePatient.TabIndex = 1;
            this.btn_ServicePatient.Text = "Obsługa";
            this.btn_ServicePatient.UseVisualStyleBackColor = true;
            this.btn_ServicePatient.Click += new System.EventHandler(this.btn_ServicePatient_Click);
            // 
            // dgv_ListOfVisits
            // 
            this.dgv_ListOfVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListOfVisits.Location = new System.Drawing.Point(12, 60);
            this.dgv_ListOfVisits.MultiSelect = false;
            this.dgv_ListOfVisits.Name = "dgv_ListOfVisits";
            this.dgv_ListOfVisits.ReadOnly = true;
            this.dgv_ListOfVisits.RowHeadersVisible = false;
            this.dgv_ListOfVisits.Size = new System.Drawing.Size(709, 196);
            this.dgv_ListOfVisits.TabIndex = 0;
            // 
            // LeaderLaboratoryStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 353);
            this.Controls.Add(this.dgv_ListOfVisits);
            this.Controls.Add(this.btn_ServicePatient);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.cmb_State);
            this.Controls.Add(this.btn_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LeaderLaboratoryStart";
            this.Text = "Wybierz badanie";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LeaderLaboratoryStart_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListOfVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ServicePatient;
        private System.Windows.Forms.DataGridView dgv_ListOfVisits;
    }
}