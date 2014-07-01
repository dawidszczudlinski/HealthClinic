namespace HealthClinic
{
    partial class DoctorManageLaboratoryExamination
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
            this.tab_ManageExamination = new System.Windows.Forms.TabControl();
            this.tab_Doctor = new System.Windows.Forms.TabPage();
            this.btn_DoctorClose = new System.Windows.Forms.Button();
            this.btn_ChoiceLaboratoryExamination = new System.Windows.Forms.Button();
            this.btn_DoctorRunTest = new System.Windows.Forms.Button();
            this.txt_DoctorComment = new System.Windows.Forms.TextBox();
            this.txt_DoctorExaminationName = new System.Windows.Forms.TextBox();
            this.txt_DoctorExaminationCode = new System.Windows.Forms.TextBox();
            this.txt_DoctorExaminationID = new System.Windows.Forms.TextBox();
            this.lbl_ExaminationComment = new System.Windows.Forms.Label();
            this.lbl_ExaminationName = new System.Windows.Forms.Label();
            this.lbl_ExaminationCode = new System.Windows.Forms.Label();
            this.lbl_IDExamination = new System.Windows.Forms.Label();
            this.tab_LaboratoryAssistant = new System.Windows.Forms.TabPage();
            this.btn_LabAssisnantClose = new System.Windows.Forms.Button();
            this.btn_LabAssistantCancel = new System.Windows.Forms.Button();
            this.txt_LabResult = new System.Windows.Forms.TextBox();
            this.lbl_LabResult = new System.Windows.Forms.Label();
            this.btn_LabAssistantRealize = new System.Windows.Forms.Button();
            this.txt_LabExaminationName = new System.Windows.Forms.TextBox();
            this.txt_LabExaminationCode = new System.Windows.Forms.TextBox();
            this.txt_LabIDExamination = new System.Windows.Forms.TextBox();
            this.lbl_LabExaminationName = new System.Windows.Forms.Label();
            this.lbl_LabExaminationCode = new System.Windows.Forms.Label();
            this.lbl_LabIDExamination = new System.Windows.Forms.Label();
            this.tab_LaboratoryLeader = new System.Windows.Forms.TabPage();
            this.btn_LeaderClose = new System.Windows.Forms.Button();
            this.btn_LeaderCancel = new System.Windows.Forms.Button();
            this.txt_LeaderExaminationDescription = new System.Windows.Forms.TextBox();
            this.lbl_LeaderExaminationDescription = new System.Windows.Forms.Label();
            this.btn_LeaderConfirm = new System.Windows.Forms.Button();
            this.txt_LeaderExaminationName = new System.Windows.Forms.TextBox();
            this.txt_LeaderExaminationCode = new System.Windows.Forms.TextBox();
            this.txt_LeaderIDExamination = new System.Windows.Forms.TextBox();
            this.lbl_LeaderExaminationName = new System.Windows.Forms.Label();
            this.lbl_LeaderExaminationCode = new System.Windows.Forms.Label();
            this.lbl_LeaderIDExamination = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tab_ManageExamination.SuspendLayout();
            this.tab_Doctor.SuspendLayout();
            this.tab_LaboratoryAssistant.SuspendLayout();
            this.tab_LaboratoryLeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_ManageExamination
            // 
            this.tab_ManageExamination.Controls.Add(this.tab_Doctor);
            this.tab_ManageExamination.Controls.Add(this.tab_LaboratoryAssistant);
            this.tab_ManageExamination.Controls.Add(this.tab_LaboratoryLeader);
            this.tab_ManageExamination.Location = new System.Drawing.Point(12, 12);
            this.tab_ManageExamination.Name = "tab_ManageExamination";
            this.tab_ManageExamination.SelectedIndex = 0;
            this.tab_ManageExamination.Size = new System.Drawing.Size(449, 392);
            this.tab_ManageExamination.TabIndex = 9;
            // 
            // tab_Doctor
            // 
            this.tab_Doctor.Controls.Add(this.btn_DoctorClose);
            this.tab_Doctor.Controls.Add(this.btn_ChoiceLaboratoryExamination);
            this.tab_Doctor.Controls.Add(this.btn_DoctorRunTest);
            this.tab_Doctor.Controls.Add(this.txt_DoctorComment);
            this.tab_Doctor.Controls.Add(this.txt_DoctorExaminationName);
            this.tab_Doctor.Controls.Add(this.txt_DoctorExaminationCode);
            this.tab_Doctor.Controls.Add(this.txt_DoctorExaminationID);
            this.tab_Doctor.Controls.Add(this.lbl_ExaminationComment);
            this.tab_Doctor.Controls.Add(this.lbl_ExaminationName);
            this.tab_Doctor.Controls.Add(this.lbl_ExaminationCode);
            this.tab_Doctor.Controls.Add(this.lbl_IDExamination);
            this.tab_Doctor.Location = new System.Drawing.Point(4, 22);
            this.tab_Doctor.Name = "tab_Doctor";
            this.tab_Doctor.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Doctor.Size = new System.Drawing.Size(441, 366);
            this.tab_Doctor.TabIndex = 0;
            this.tab_Doctor.Text = "Lekarz";
            this.tab_Doctor.UseVisualStyleBackColor = true;
            // 
            // btn_DoctorClose
            // 
            this.btn_DoctorClose.Location = new System.Drawing.Point(320, 301);
            this.btn_DoctorClose.Name = "btn_DoctorClose";
            this.btn_DoctorClose.Size = new System.Drawing.Size(102, 41);
            this.btn_DoctorClose.TabIndex = 2;
            this.btn_DoctorClose.Text = "Powrót";
            this.btn_DoctorClose.UseVisualStyleBackColor = true;
            this.btn_DoctorClose.Click += new System.EventHandler(this.btn_DoctorClose_Click);
            // 
            // btn_ChoiceLaboratoryExamination
            // 
            this.btn_ChoiceLaboratoryExamination.Location = new System.Drawing.Point(323, 41);
            this.btn_ChoiceLaboratoryExamination.Name = "btn_ChoiceLaboratoryExamination";
            this.btn_ChoiceLaboratoryExamination.Size = new System.Drawing.Size(99, 36);
            this.btn_ChoiceLaboratoryExamination.TabIndex = 0;
            this.btn_ChoiceLaboratoryExamination.Text = "Wybierz badanie";
            this.btn_ChoiceLaboratoryExamination.UseVisualStyleBackColor = true;
            this.btn_ChoiceLaboratoryExamination.Click += new System.EventHandler(this.btn_ChoiceLaboratoryExamination_Click);
            // 
            // btn_DoctorRunTest
            // 
            this.btn_DoctorRunTest.Location = new System.Drawing.Point(172, 301);
            this.btn_DoctorRunTest.Name = "btn_DoctorRunTest";
            this.btn_DoctorRunTest.Size = new System.Drawing.Size(102, 41);
            this.btn_DoctorRunTest.TabIndex = 1;
            this.btn_DoctorRunTest.Text = "Zleć";
            this.btn_DoctorRunTest.UseVisualStyleBackColor = true;
            this.btn_DoctorRunTest.Click += new System.EventHandler(this.btn_DoctorRunTest_Click);
            // 
            // txt_DoctorComment
            // 
            this.txt_DoctorComment.Location = new System.Drawing.Point(27, 159);
            this.txt_DoctorComment.Multiline = true;
            this.txt_DoctorComment.Name = "txt_DoctorComment";
            this.txt_DoctorComment.Size = new System.Drawing.Size(395, 120);
            this.txt_DoctorComment.TabIndex = 7;
            // 
            // txt_DoctorExaminationName
            // 
            this.txt_DoctorExaminationName.Location = new System.Drawing.Point(135, 98);
            this.txt_DoctorExaminationName.Name = "txt_DoctorExaminationName";
            this.txt_DoctorExaminationName.ReadOnly = true;
            this.txt_DoctorExaminationName.Size = new System.Drawing.Size(178, 20);
            this.txt_DoctorExaminationName.TabIndex = 6;
            // 
            // txt_DoctorExaminationCode
            // 
            this.txt_DoctorExaminationCode.Location = new System.Drawing.Point(135, 57);
            this.txt_DoctorExaminationCode.Name = "txt_DoctorExaminationCode";
            this.txt_DoctorExaminationCode.ReadOnly = true;
            this.txt_DoctorExaminationCode.Size = new System.Drawing.Size(100, 20);
            this.txt_DoctorExaminationCode.TabIndex = 5;
            // 
            // txt_DoctorExaminationID
            // 
            this.txt_DoctorExaminationID.Location = new System.Drawing.Point(135, 18);
            this.txt_DoctorExaminationID.Name = "txt_DoctorExaminationID";
            this.txt_DoctorExaminationID.ReadOnly = true;
            this.txt_DoctorExaminationID.Size = new System.Drawing.Size(100, 20);
            this.txt_DoctorExaminationID.TabIndex = 4;
            // 
            // lbl_ExaminationComment
            // 
            this.lbl_ExaminationComment.AutoSize = true;
            this.lbl_ExaminationComment.Location = new System.Drawing.Point(24, 133);
            this.lbl_ExaminationComment.Name = "lbl_ExaminationComment";
            this.lbl_ExaminationComment.Size = new System.Drawing.Size(40, 13);
            this.lbl_ExaminationComment.TabIndex = 3;
            this.lbl_ExaminationComment.Text = "Uwagi:";
            // 
            // lbl_ExaminationName
            // 
            this.lbl_ExaminationName.AutoSize = true;
            this.lbl_ExaminationName.Location = new System.Drawing.Point(24, 105);
            this.lbl_ExaminationName.Name = "lbl_ExaminationName";
            this.lbl_ExaminationName.Size = new System.Drawing.Size(84, 13);
            this.lbl_ExaminationName.TabIndex = 2;
            this.lbl_ExaminationName.Text = "Nazwa badania:";
            // 
            // lbl_ExaminationCode
            // 
            this.lbl_ExaminationCode.AutoSize = true;
            this.lbl_ExaminationCode.Location = new System.Drawing.Point(24, 64);
            this.lbl_ExaminationCode.Name = "lbl_ExaminationCode";
            this.lbl_ExaminationCode.Size = new System.Drawing.Size(70, 13);
            this.lbl_ExaminationCode.TabIndex = 1;
            this.lbl_ExaminationCode.Text = "Kod badania:";
            // 
            // lbl_IDExamination
            // 
            this.lbl_IDExamination.AutoSize = true;
            this.lbl_IDExamination.Location = new System.Drawing.Point(24, 25);
            this.lbl_IDExamination.Name = "lbl_IDExamination";
            this.lbl_IDExamination.Size = new System.Drawing.Size(62, 13);
            this.lbl_IDExamination.TabIndex = 0;
            this.lbl_IDExamination.Text = "ID badania:";
            // 
            // tab_LaboratoryAssistant
            // 
            this.tab_LaboratoryAssistant.Controls.Add(this.btn_LabAssisnantClose);
            this.tab_LaboratoryAssistant.Controls.Add(this.btn_LabAssistantCancel);
            this.tab_LaboratoryAssistant.Controls.Add(this.txt_LabResult);
            this.tab_LaboratoryAssistant.Controls.Add(this.lbl_LabResult);
            this.tab_LaboratoryAssistant.Controls.Add(this.btn_LabAssistantRealize);
            this.tab_LaboratoryAssistant.Controls.Add(this.txt_LabExaminationName);
            this.tab_LaboratoryAssistant.Controls.Add(this.txt_LabExaminationCode);
            this.tab_LaboratoryAssistant.Controls.Add(this.txt_LabIDExamination);
            this.tab_LaboratoryAssistant.Controls.Add(this.lbl_LabExaminationName);
            this.tab_LaboratoryAssistant.Controls.Add(this.lbl_LabExaminationCode);
            this.tab_LaboratoryAssistant.Controls.Add(this.lbl_LabIDExamination);
            this.tab_LaboratoryAssistant.Location = new System.Drawing.Point(4, 22);
            this.tab_LaboratoryAssistant.Name = "tab_LaboratoryAssistant";
            this.tab_LaboratoryAssistant.Padding = new System.Windows.Forms.Padding(3);
            this.tab_LaboratoryAssistant.Size = new System.Drawing.Size(441, 366);
            this.tab_LaboratoryAssistant.TabIndex = 1;
            this.tab_LaboratoryAssistant.Text = "Laborant";
            this.tab_LaboratoryAssistant.UseVisualStyleBackColor = true;
            // 
            // btn_LabAssisnantClose
            // 
            this.btn_LabAssisnantClose.Location = new System.Drawing.Point(318, 303);
            this.btn_LabAssisnantClose.Name = "btn_LabAssisnantClose";
            this.btn_LabAssisnantClose.Size = new System.Drawing.Size(102, 41);
            this.btn_LabAssisnantClose.TabIndex = 2;
            this.btn_LabAssisnantClose.Text = "Powrót";
            this.btn_LabAssisnantClose.UseVisualStyleBackColor = true;
            this.btn_LabAssisnantClose.Click += new System.EventHandler(this.btn_LabAssisnantClose_Click);
            // 
            // btn_LabAssistantCancel
            // 
            this.btn_LabAssistantCancel.Location = new System.Drawing.Point(172, 303);
            this.btn_LabAssistantCancel.Name = "btn_LabAssistantCancel";
            this.btn_LabAssistantCancel.Size = new System.Drawing.Size(102, 41);
            this.btn_LabAssistantCancel.TabIndex = 1;
            this.btn_LabAssistantCancel.Text = "Anuluj";
            this.btn_LabAssistantCancel.UseVisualStyleBackColor = true;
            this.btn_LabAssistantCancel.Click += new System.EventHandler(this.btn_LabAssistantCancel_Click);
            // 
            // txt_LabResult
            // 
            this.txt_LabResult.Location = new System.Drawing.Point(25, 159);
            this.txt_LabResult.Multiline = true;
            this.txt_LabResult.Name = "txt_LabResult";
            this.txt_LabResult.Size = new System.Drawing.Size(395, 120);
            this.txt_LabResult.TabIndex = 4;
            // 
            // lbl_LabResult
            // 
            this.lbl_LabResult.AutoSize = true;
            this.lbl_LabResult.Location = new System.Drawing.Point(22, 133);
            this.lbl_LabResult.Name = "lbl_LabResult";
            this.lbl_LabResult.Size = new System.Drawing.Size(40, 13);
            this.lbl_LabResult.TabIndex = 15;
            this.lbl_LabResult.Text = "Wynik:";
            // 
            // btn_LabAssistantRealize
            // 
            this.btn_LabAssistantRealize.Location = new System.Drawing.Point(25, 303);
            this.btn_LabAssistantRealize.Name = "btn_LabAssistantRealize";
            this.btn_LabAssistantRealize.Size = new System.Drawing.Size(102, 41);
            this.btn_LabAssistantRealize.TabIndex = 3;
            this.btn_LabAssistantRealize.Text = "Wykonaj";
            this.btn_LabAssistantRealize.UseVisualStyleBackColor = true;
            this.btn_LabAssistantRealize.Click += new System.EventHandler(this.btn_LabAssistantRealize_Click);
            // 
            // txt_LabExaminationName
            // 
            this.txt_LabExaminationName.Location = new System.Drawing.Point(133, 102);
            this.txt_LabExaminationName.Name = "txt_LabExaminationName";
            this.txt_LabExaminationName.ReadOnly = true;
            this.txt_LabExaminationName.Size = new System.Drawing.Size(178, 20);
            this.txt_LabExaminationName.TabIndex = 14;
            // 
            // txt_LabExaminationCode
            // 
            this.txt_LabExaminationCode.Location = new System.Drawing.Point(133, 61);
            this.txt_LabExaminationCode.Name = "txt_LabExaminationCode";
            this.txt_LabExaminationCode.ReadOnly = true;
            this.txt_LabExaminationCode.Size = new System.Drawing.Size(100, 20);
            this.txt_LabExaminationCode.TabIndex = 13;
            // 
            // txt_LabIDExamination
            // 
            this.txt_LabIDExamination.Location = new System.Drawing.Point(133, 22);
            this.txt_LabIDExamination.Name = "txt_LabIDExamination";
            this.txt_LabIDExamination.ReadOnly = true;
            this.txt_LabIDExamination.Size = new System.Drawing.Size(100, 20);
            this.txt_LabIDExamination.TabIndex = 12;
            // 
            // lbl_LabExaminationName
            // 
            this.lbl_LabExaminationName.AutoSize = true;
            this.lbl_LabExaminationName.Location = new System.Drawing.Point(22, 109);
            this.lbl_LabExaminationName.Name = "lbl_LabExaminationName";
            this.lbl_LabExaminationName.Size = new System.Drawing.Size(84, 13);
            this.lbl_LabExaminationName.TabIndex = 11;
            this.lbl_LabExaminationName.Text = "Nazwa badania:";
            // 
            // lbl_LabExaminationCode
            // 
            this.lbl_LabExaminationCode.AutoSize = true;
            this.lbl_LabExaminationCode.Location = new System.Drawing.Point(22, 68);
            this.lbl_LabExaminationCode.Name = "lbl_LabExaminationCode";
            this.lbl_LabExaminationCode.Size = new System.Drawing.Size(70, 13);
            this.lbl_LabExaminationCode.TabIndex = 10;
            this.lbl_LabExaminationCode.Text = "Kod badania:";
            // 
            // lbl_LabIDExamination
            // 
            this.lbl_LabIDExamination.AutoSize = true;
            this.lbl_LabIDExamination.Location = new System.Drawing.Point(22, 29);
            this.lbl_LabIDExamination.Name = "lbl_LabIDExamination";
            this.lbl_LabIDExamination.Size = new System.Drawing.Size(62, 13);
            this.lbl_LabIDExamination.TabIndex = 9;
            this.lbl_LabIDExamination.Text = "ID badania:";
            // 
            // tab_LaboratoryLeader
            // 
            this.tab_LaboratoryLeader.Controls.Add(this.btn_LeaderClose);
            this.tab_LaboratoryLeader.Controls.Add(this.btn_LeaderCancel);
            this.tab_LaboratoryLeader.Controls.Add(this.txt_LeaderExaminationDescription);
            this.tab_LaboratoryLeader.Controls.Add(this.lbl_LeaderExaminationDescription);
            this.tab_LaboratoryLeader.Controls.Add(this.btn_LeaderConfirm);
            this.tab_LaboratoryLeader.Controls.Add(this.txt_LeaderExaminationName);
            this.tab_LaboratoryLeader.Controls.Add(this.txt_LeaderExaminationCode);
            this.tab_LaboratoryLeader.Controls.Add(this.txt_LeaderIDExamination);
            this.tab_LaboratoryLeader.Controls.Add(this.lbl_LeaderExaminationName);
            this.tab_LaboratoryLeader.Controls.Add(this.lbl_LeaderExaminationCode);
            this.tab_LaboratoryLeader.Controls.Add(this.lbl_LeaderIDExamination);
            this.tab_LaboratoryLeader.Location = new System.Drawing.Point(4, 22);
            this.tab_LaboratoryLeader.Name = "tab_LaboratoryLeader";
            this.tab_LaboratoryLeader.Padding = new System.Windows.Forms.Padding(3);
            this.tab_LaboratoryLeader.Size = new System.Drawing.Size(441, 366);
            this.tab_LaboratoryLeader.TabIndex = 2;
            this.tab_LaboratoryLeader.Text = "Kierownik Laboratorium";
            this.tab_LaboratoryLeader.UseVisualStyleBackColor = true;
            // 
            // btn_LeaderClose
            // 
            this.btn_LeaderClose.Location = new System.Drawing.Point(317, 297);
            this.btn_LeaderClose.Name = "btn_LeaderClose";
            this.btn_LeaderClose.Size = new System.Drawing.Size(102, 41);
            this.btn_LeaderClose.TabIndex = 8;
            this.btn_LeaderClose.Text = "Powrót";
            this.btn_LeaderClose.UseVisualStyleBackColor = true;
            this.btn_LeaderClose.Click += new System.EventHandler(this.btn_LeaderClose_Click);
            // 
            // btn_LeaderCancel
            // 
            this.btn_LeaderCancel.Location = new System.Drawing.Point(170, 297);
            this.btn_LeaderCancel.Name = "btn_LeaderCancel";
            this.btn_LeaderCancel.Size = new System.Drawing.Size(102, 41);
            this.btn_LeaderCancel.TabIndex = 7;
            this.btn_LeaderCancel.Text = "Anuluj";
            this.btn_LeaderCancel.UseVisualStyleBackColor = true;
            this.btn_LeaderCancel.Click += new System.EventHandler(this.btn_LeaderCancel_Click);
            // 
            // txt_LeaderExaminationDescription
            // 
            this.txt_LeaderExaminationDescription.Location = new System.Drawing.Point(24, 151);
            this.txt_LeaderExaminationDescription.Multiline = true;
            this.txt_LeaderExaminationDescription.Name = "txt_LeaderExaminationDescription";
            this.txt_LeaderExaminationDescription.Size = new System.Drawing.Size(395, 120);
            this.txt_LeaderExaminationDescription.TabIndex = 24;
            // 
            // lbl_LeaderExaminationDescription
            // 
            this.lbl_LeaderExaminationDescription.AutoSize = true;
            this.lbl_LeaderExaminationDescription.Location = new System.Drawing.Point(21, 125);
            this.lbl_LeaderExaminationDescription.Name = "lbl_LeaderExaminationDescription";
            this.lbl_LeaderExaminationDescription.Size = new System.Drawing.Size(31, 13);
            this.lbl_LeaderExaminationDescription.TabIndex = 23;
            this.lbl_LeaderExaminationDescription.Text = "Opis:";
            // 
            // btn_LeaderConfirm
            // 
            this.btn_LeaderConfirm.Location = new System.Drawing.Point(24, 297);
            this.btn_LeaderConfirm.Name = "btn_LeaderConfirm";
            this.btn_LeaderConfirm.Size = new System.Drawing.Size(102, 41);
            this.btn_LeaderConfirm.TabIndex = 6;
            this.btn_LeaderConfirm.Text = "Zatwierdź";
            this.btn_LeaderConfirm.UseVisualStyleBackColor = true;
            this.btn_LeaderConfirm.Click += new System.EventHandler(this.btn_LeaderConfirm_Click);
            // 
            // txt_LeaderExaminationName
            // 
            this.txt_LeaderExaminationName.Location = new System.Drawing.Point(132, 94);
            this.txt_LeaderExaminationName.Name = "txt_LeaderExaminationName";
            this.txt_LeaderExaminationName.ReadOnly = true;
            this.txt_LeaderExaminationName.Size = new System.Drawing.Size(178, 20);
            this.txt_LeaderExaminationName.TabIndex = 22;
            // 
            // txt_LeaderExaminationCode
            // 
            this.txt_LeaderExaminationCode.Location = new System.Drawing.Point(132, 53);
            this.txt_LeaderExaminationCode.Name = "txt_LeaderExaminationCode";
            this.txt_LeaderExaminationCode.ReadOnly = true;
            this.txt_LeaderExaminationCode.Size = new System.Drawing.Size(100, 20);
            this.txt_LeaderExaminationCode.TabIndex = 21;
            // 
            // txt_LeaderIDExamination
            // 
            this.txt_LeaderIDExamination.Location = new System.Drawing.Point(132, 14);
            this.txt_LeaderIDExamination.Name = "txt_LeaderIDExamination";
            this.txt_LeaderIDExamination.ReadOnly = true;
            this.txt_LeaderIDExamination.Size = new System.Drawing.Size(100, 20);
            this.txt_LeaderIDExamination.TabIndex = 20;
            // 
            // lbl_LeaderExaminationName
            // 
            this.lbl_LeaderExaminationName.AutoSize = true;
            this.lbl_LeaderExaminationName.Location = new System.Drawing.Point(21, 101);
            this.lbl_LeaderExaminationName.Name = "lbl_LeaderExaminationName";
            this.lbl_LeaderExaminationName.Size = new System.Drawing.Size(84, 13);
            this.lbl_LeaderExaminationName.TabIndex = 19;
            this.lbl_LeaderExaminationName.Text = "Nazwa badania:";
            // 
            // lbl_LeaderExaminationCode
            // 
            this.lbl_LeaderExaminationCode.AutoSize = true;
            this.lbl_LeaderExaminationCode.Location = new System.Drawing.Point(21, 60);
            this.lbl_LeaderExaminationCode.Name = "lbl_LeaderExaminationCode";
            this.lbl_LeaderExaminationCode.Size = new System.Drawing.Size(70, 13);
            this.lbl_LeaderExaminationCode.TabIndex = 18;
            this.lbl_LeaderExaminationCode.Text = "Kod badania:";
            // 
            // lbl_LeaderIDExamination
            // 
            this.lbl_LeaderIDExamination.AutoSize = true;
            this.lbl_LeaderIDExamination.Location = new System.Drawing.Point(21, 21);
            this.lbl_LeaderIDExamination.Name = "lbl_LeaderIDExamination";
            this.lbl_LeaderIDExamination.Size = new System.Drawing.Size(62, 13);
            this.lbl_LeaderIDExamination.TabIndex = 17;
            this.lbl_LeaderIDExamination.Text = "ID badania:";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Olek\\Desktop\\HealthClinic\\HealthClinic\\HealthClinic\\Pomoc\\Pomoc.chm";
            // 
            // DoctorManageLaboratoryExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 425);
            this.Controls.Add(this.tab_ManageExamination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DoctorManageLaboratoryExamination";
            this.Text = "Wykonaj badanie laboratoryjne";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoctorManageLaboratoryExamination_KeyDown);
            this.tab_ManageExamination.ResumeLayout(false);
            this.tab_Doctor.ResumeLayout(false);
            this.tab_Doctor.PerformLayout();
            this.tab_LaboratoryAssistant.ResumeLayout(false);
            this.tab_LaboratoryAssistant.PerformLayout();
            this.tab_LaboratoryLeader.ResumeLayout(false);
            this.tab_LaboratoryLeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_ManageExamination;
        private System.Windows.Forms.TabPage tab_Doctor;
        private System.Windows.Forms.TabPage tab_LaboratoryAssistant;
        private System.Windows.Forms.TabPage tab_LaboratoryLeader;
        private System.Windows.Forms.Button btn_DoctorRunTest;
        private System.Windows.Forms.Button btn_DoctorClose;
        private System.Windows.Forms.Label lbl_ExaminationComment;
        private System.Windows.Forms.Label lbl_ExaminationName;
        private System.Windows.Forms.Label lbl_ExaminationCode;
        private System.Windows.Forms.Label lbl_IDExamination;
        private System.Windows.Forms.TextBox txt_DoctorComment;
        private System.Windows.Forms.TextBox txt_DoctorExaminationName;
        private System.Windows.Forms.TextBox txt_DoctorExaminationCode;
        private System.Windows.Forms.TextBox txt_DoctorExaminationID;
        private System.Windows.Forms.Button btn_ChoiceLaboratoryExamination;
        private System.Windows.Forms.TextBox txt_LabExaminationName;
        private System.Windows.Forms.TextBox txt_LabExaminationCode;
        private System.Windows.Forms.TextBox txt_LabIDExamination;
        private System.Windows.Forms.Label lbl_LabExaminationName;
        private System.Windows.Forms.Label lbl_LabExaminationCode;
        private System.Windows.Forms.Label lbl_LabIDExamination;
        private System.Windows.Forms.TextBox txt_LabResult;
        private System.Windows.Forms.Label lbl_LabResult;
        private System.Windows.Forms.Button btn_LabAssisnantClose;
        private System.Windows.Forms.Button btn_LabAssistantRealize;
        private System.Windows.Forms.Button btn_LabAssistantCancel;
        private System.Windows.Forms.TextBox txt_LeaderExaminationDescription;
        private System.Windows.Forms.Label lbl_LeaderExaminationDescription;
        private System.Windows.Forms.TextBox txt_LeaderExaminationName;
        private System.Windows.Forms.TextBox txt_LeaderExaminationCode;
        private System.Windows.Forms.TextBox txt_LeaderIDExamination;
        private System.Windows.Forms.Label lbl_LeaderExaminationName;
        private System.Windows.Forms.Label lbl_LeaderExaminationCode;
        private System.Windows.Forms.Label lbl_LeaderIDExamination;
        private System.Windows.Forms.Button btn_LeaderCancel;
        private System.Windows.Forms.Button btn_LeaderClose;
        private System.Windows.Forms.Button btn_LeaderConfirm;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}