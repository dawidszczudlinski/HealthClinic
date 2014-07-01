namespace HealthClinic
{
    partial class ReceptionistStart
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
            this.btn_RegisterVisit = new System.Windows.Forms.Button();
            this.btn_ManageVisits = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btn_RegisterVisit
            // 
            this.btn_RegisterVisit.Location = new System.Drawing.Point(12, 34);
            this.btn_RegisterVisit.Name = "btn_RegisterVisit";
            this.btn_RegisterVisit.Size = new System.Drawing.Size(118, 65);
            this.btn_RegisterVisit.TabIndex = 0;
            this.btn_RegisterVisit.Text = "Zarejestruj wizytę";
            this.btn_RegisterVisit.UseVisualStyleBackColor = true;
            this.btn_RegisterVisit.Click += new System.EventHandler(this.btn_RegisterVisit_Click);
            // 
            // btn_ManageVisits
            // 
            this.btn_ManageVisits.Location = new System.Drawing.Point(151, 34);
            this.btn_ManageVisits.Name = "btn_ManageVisits";
            this.btn_ManageVisits.Size = new System.Drawing.Size(121, 65);
            this.btn_ManageVisits.TabIndex = 1;
            this.btn_ManageVisits.Text = "Zarządzaj wizytami";
            this.btn_ManageVisits.UseVisualStyleBackColor = true;
            this.btn_ManageVisits.Click += new System.EventHandler(this.btn_ManageVisits_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Olek\\Desktop\\HealthClinic\\HealthClinic\\HealthClinic\\Pomoc\\Pomoc.chm";
            // 
            // ReceptionistStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 140);
            this.Controls.Add(this.btn_ManageVisits);
            this.Controls.Add(this.btn_RegisterVisit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ReceptionistStart";
            this.Text = "Wybierz Opcje";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReceptionistStart_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RegisterVisit;
        private System.Windows.Forms.Button btn_ManageVisits;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}