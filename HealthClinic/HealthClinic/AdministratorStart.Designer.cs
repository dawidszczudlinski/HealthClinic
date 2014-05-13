namespace HealthClinic
{
    partial class AdministratorStart
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
            this.btn_ManageAccounts = new System.Windows.Forms.Button();
            this.btn_ManageExamination = new System.Windows.Forms.Button();
            this.btn_ManageReceptionist = new System.Windows.Forms.Button();
            this.btn_ManageDoctors = new System.Windows.Forms.Button();
            this.btn_ManagePatient = new System.Windows.Forms.Button();
            this.btn_ManageLeaderLaboratory = new System.Windows.Forms.Button();
            this.btn_ManageLaboratoraryAssistant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ManageAccounts
            // 
            this.btn_ManageAccounts.Location = new System.Drawing.Point(22, 27);
            this.btn_ManageAccounts.Name = "btn_ManageAccounts";
            this.btn_ManageAccounts.Size = new System.Drawing.Size(100, 50);
            this.btn_ManageAccounts.TabIndex = 0;
            this.btn_ManageAccounts.Text = "Zarządzaj kontami";
            this.btn_ManageAccounts.UseVisualStyleBackColor = true;
            this.btn_ManageAccounts.Click += new System.EventHandler(this.btn_ManageAccounts_Click);
            // 
            // btn_ManageExamination
            // 
            this.btn_ManageExamination.Location = new System.Drawing.Point(133, 27);
            this.btn_ManageExamination.Name = "btn_ManageExamination";
            this.btn_ManageExamination.Size = new System.Drawing.Size(100, 50);
            this.btn_ManageExamination.TabIndex = 1;
            this.btn_ManageExamination.Text = "Zarządzaj badaniami";
            this.btn_ManageExamination.UseVisualStyleBackColor = true;
            this.btn_ManageExamination.Click += new System.EventHandler(this.btn_ManageExamination_Click);
            // 
            // btn_ManageReceptionist
            // 
            this.btn_ManageReceptionist.Location = new System.Drawing.Point(22, 93);
            this.btn_ManageReceptionist.Name = "btn_ManageReceptionist";
            this.btn_ManageReceptionist.Size = new System.Drawing.Size(100, 50);
            this.btn_ManageReceptionist.TabIndex = 2;
            this.btn_ManageReceptionist.Text = "Zarządzaj rejestratorami";
            this.btn_ManageReceptionist.UseVisualStyleBackColor = true;
            this.btn_ManageReceptionist.Click += new System.EventHandler(this.btn_ManageReceptionist_Click);
            // 
            // btn_ManageDoctors
            // 
            this.btn_ManageDoctors.Location = new System.Drawing.Point(133, 93);
            this.btn_ManageDoctors.Name = "btn_ManageDoctors";
            this.btn_ManageDoctors.Size = new System.Drawing.Size(100, 50);
            this.btn_ManageDoctors.TabIndex = 3;
            this.btn_ManageDoctors.Text = "Zarządzaj lekarzami";
            this.btn_ManageDoctors.UseVisualStyleBackColor = true;
            this.btn_ManageDoctors.Click += new System.EventHandler(this.btn_ManageDoctors_Click);
            // 
            // btn_ManagePatient
            // 
            this.btn_ManagePatient.Location = new System.Drawing.Point(22, 225);
            this.btn_ManagePatient.Name = "btn_ManagePatient";
            this.btn_ManagePatient.Size = new System.Drawing.Size(100, 50);
            this.btn_ManagePatient.TabIndex = 4;
            this.btn_ManagePatient.Text = "Zarządzaj pacjentami";
            this.btn_ManagePatient.UseVisualStyleBackColor = true;
            this.btn_ManagePatient.Click += new System.EventHandler(this.btn_ManagePatient_Click);
            // 
            // btn_ManageLeaderLaboratory
            // 
            this.btn_ManageLeaderLaboratory.Location = new System.Drawing.Point(133, 158);
            this.btn_ManageLeaderLaboratory.Name = "btn_ManageLeaderLaboratory";
            this.btn_ManageLeaderLaboratory.Size = new System.Drawing.Size(100, 50);
            this.btn_ManageLeaderLaboratory.TabIndex = 5;
            this.btn_ManageLeaderLaboratory.Text = "Zarządzaj kierownikami laboratoriów";
            this.btn_ManageLeaderLaboratory.UseVisualStyleBackColor = true;
            this.btn_ManageLeaderLaboratory.Click += new System.EventHandler(this.btn_ManageLeaderLaboratory_Click);
            // 
            // btn_ManageLaboratoraryAssistant
            // 
            this.btn_ManageLaboratoraryAssistant.Location = new System.Drawing.Point(22, 158);
            this.btn_ManageLaboratoraryAssistant.Name = "btn_ManageLaboratoraryAssistant";
            this.btn_ManageLaboratoraryAssistant.Size = new System.Drawing.Size(100, 50);
            this.btn_ManageLaboratoraryAssistant.TabIndex = 6;
            this.btn_ManageLaboratoraryAssistant.Text = "Zarządzaj laborantami";
            this.btn_ManageLaboratoraryAssistant.UseVisualStyleBackColor = true;
            this.btn_ManageLaboratoraryAssistant.Click += new System.EventHandler(this.btn_ManageLaboratoraryAssistant_Click);
            // 
            // AdministratorStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 300);
            this.Controls.Add(this.btn_ManageLaboratoraryAssistant);
            this.Controls.Add(this.btn_ManageLeaderLaboratory);
            this.Controls.Add(this.btn_ManagePatient);
            this.Controls.Add(this.btn_ManageDoctors);
            this.Controls.Add(this.btn_ManageReceptionist);
            this.Controls.Add(this.btn_ManageExamination);
            this.Controls.Add(this.btn_ManageAccounts);
            this.Name = "AdministratorStart";
            this.Text = "Panel Administratora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ManageAccounts;
        private System.Windows.Forms.Button btn_ManageExamination;
        private System.Windows.Forms.Button btn_ManageReceptionist;
        private System.Windows.Forms.Button btn_ManageDoctors;
        private System.Windows.Forms.Button btn_ManagePatient;
        private System.Windows.Forms.Button btn_ManageLeaderLaboratory;
        private System.Windows.Forms.Button btn_ManageLaboratoraryAssistant;
    }
}