using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthClinic
{
    
    public partial class DoctorManageLaboratoryExamination : Form
    {
        private DoctorLaboratoryExamination windowDoctor;
        private LaboratoryAssistantStart windowLaboratory;
        private LeaderLaboratoryStart windowLeader;

        private int role;
        private int idVisit;
        private int idExam;
        private bool isEdit;
        int examinationCode;

        public DoctorManageLaboratoryExamination()
        {
            InitializeComponent();
        }

        public DoctorManageLaboratoryExamination(LaboratoryAssistantStart lAs1)
        {
            role = 1;
            this.windowLaboratory = lAs1;
            InitializeComponent();
        }

        public DoctorManageLaboratoryExamination(LeaderLaboratoryStart lLs1)
        {
            role = 2;
            this.windowLeader = lLs1;
            InitializeComponent();
        }

        public DoctorManageLaboratoryExamination(DoctorLaboratoryExamination dMv1, bool edit)
        {
            role = 0;
            this.isEdit = edit;
            this.windowDoctor = dMv1;
            InitializeComponent();
        }
       
        private void btn_ChoiceLaboratoryExamination_Click(object sender, EventArgs e)
        {
            DoctorLaboratoryExaminationMap doctorLaboratoryExaminationMap = new DoctorLaboratoryExaminationMap(this);
            doctorLaboratoryExaminationMap.Show();
        }

        private void btn_DoctorRunTest_Click(object sender, EventArgs e)
        {
            DataClasses2DataContext context = new DataClasses2DataContext();
            if (isEdit == false)
            {
                Badanie badanie = new Badanie();

                badanie.Dt_zle = DateTime.Now;
                badanie.Dt_wyk_anul = null;
                badanie.Dt_zatw_anul = null;

                badanie.Opis = null;
                badanie.Wynik = null;
                badanie.Uwagi = txt_DoctorComment.Text;

                badanie.Kod = Int32.Parse(txt_DoctorExaminationCode.Text);

                badanie.ID_lab = null;
                badanie.ID_Klab = null;
                badanie.ID_wiz = this.idVisit;

                badanie.Status = "Zle";


                context.Badanies.InsertOnSubmit(badanie);
            }
            else
            {
                var sourcess = from Badanie bad in context.Badanies
                               where bad.ID_bad == this.idExam
                               select bad;

                Badanie badanie = sourcess.First();

                badanie.Dt_zle = DateTime.Now;
                badanie.Uwagi = txt_DoctorComment.Text;
                badanie.Kod = Int32.Parse(txt_DoctorExaminationCode.Text);
                badanie.Status = "Zle";
            }
            
            context.SubmitChanges();
            windowDoctor.showActualData();
            this.Close();
        }

        private void btn_DoctorClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_LabAssistantRealize_Click(object sender, EventArgs e)
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Badanie bad in context.Badanies
                           where bad.ID_bad == this.idExam
                           select bad;

            Badanie badanie = sourcess.First();
            badanie.Wynik = txt_LabResult.Text;
            badanie.ID_lab = CurrentAccount.getAccount().ID;
            badanie.Dt_wyk_anul = DateTime.Now;
            badanie.Status = "Wyk";

            context.SubmitChanges();

            windowLaboratory.showActualData();

            this.Close();
        }

        private void btn_LabAssistantCancel_Click(object sender, EventArgs e)
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Badanie bad in context.Badanies
                           where bad.ID_bad == this.idExam
                           select bad;

            Badanie badanie = sourcess.First();
            badanie.Wynik = txt_LabResult.Text;
            badanie.ID_lab = CurrentAccount.getAccount().ID;
            badanie.Dt_wyk_anul = DateTime.Now;
            badanie.Status = "Anu_l";

            context.SubmitChanges();

            windowLaboratory.showActualData();

            this.Close();
        }

        private void btn_LabAssisnantClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_LeaderConfirm_Click(object sender, EventArgs e)
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Badanie bad in context.Badanies
                           where bad.ID_bad == this.idExam
                           select bad;

            Badanie badanie = sourcess.First();
            badanie.Opis = txt_LeaderExaminationDescription.Text;
            badanie.ID_Klab = CurrentAccount.getAccount().ID;
            badanie.Dt_zatw_anul = DateTime.Now;
            badanie.Status = "Zatw";

            context.SubmitChanges();

            windowLeader.showActualData();

            this.Close();
        }

        private void btn_LeaderCancel_Click(object sender, EventArgs e)
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Badanie bad in context.Badanies
                           where bad.ID_bad == this.idExam
                           select bad;

            Badanie badanie = sourcess.First();
            badanie.Opis = txt_LeaderExaminationDescription.Text;
            badanie.ID_Klab = CurrentAccount.getAccount().ID;
            badanie.Dt_zatw_anul = DateTime.Now;
            badanie.Status = "Anu_k";

            context.SubmitChanges();

            windowLeader.showActualData();

            this.Close();
        }

        private void btn_LeaderClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setVisitId(int idVis)
        {
            this.idVisit = idVis;
        }

        public void setExaminationId(int examId)
        {
            this.idExam = examId;

            this.showActualData();
        }

        public void showActualData()
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Badanie bad in context.Badanies
                           where bad.ID_bad == this.idExam
                           select bad;

            Badanie badanie = sourcess.First();

            this.setExaminationType(badanie.Kod);
            txt_DoctorExaminationID.Text = this.idExam.ToString();
            txt_LabIDExamination.Text = this.idExam.ToString();
            txt_LeaderIDExamination.Text = this.idExam.ToString();

            switch (this.role)
            {
                case 2:
                    txt_LeaderExaminationDescription.Text = badanie.Opis;
                    goto case 1;
                case 1:
                    txt_LabResult.Text = badanie.Wynik;
                    goto case 0;
                case 0:
                    txt_DoctorComment.Text = badanie.Uwagi;
                    break;
            }
        }

        public void setExaminationType(int examination)
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            examinationCode = examination;

            var sourcess2 = from Slownik_badan slo in context.Slownik_badans
                            where slo.Kod == examinationCode
                            select slo;
            Slownik_badan examinationType = sourcess2.First();

            txt_DoctorExaminationCode.Text = examinationType.Kod.ToString();
            txt_DoctorExaminationName.Text = examinationType.Nazwa;

            txt_LabExaminationCode.Text = examinationType.Kod.ToString();
            txt_LabExaminationName.Text = examinationType.Nazwa;

            txt_LeaderExaminationCode.Text = examinationType.Kod.ToString();
            txt_LeaderExaminationName.Text = examinationType.Nazwa;
        }
       
        public void showDoctorWindow()
        {
            txt_LabResult.ReadOnly = true;
            txt_DoctorComment.ReadOnly = false;
            txt_LeaderExaminationDescription.ReadOnly = true;

            btn_ChoiceLaboratoryExamination.Enabled = true;
            btn_DoctorClose.Visible = true;
            btn_DoctorRunTest.Visible = true;
            btn_LabAssisnantClose.Visible = false;
            btn_LabAssistantCancel.Visible = false;
            btn_LabAssistantRealize.Visible = false;
            btn_LeaderCancel.Visible = false;
            btn_LeaderClose.Visible = false;
            btn_LeaderConfirm.Visible = false;
            tab_ManageExamination.SelectedIndex = 0;
        }

        public void showLaboratoryAssistantWindow()
        {
            txt_LabResult.ReadOnly = false;
            txt_DoctorComment.ReadOnly = true;
            txt_LeaderExaminationDescription.ReadOnly = true;

            btn_ChoiceLaboratoryExamination.Enabled = false;
            btn_DoctorClose.Visible = false;
            btn_DoctorRunTest.Visible = false;
            btn_LabAssisnantClose.Visible = true;
            btn_LabAssistantCancel.Visible = true;
            btn_LabAssistantRealize.Visible = true;
            btn_LeaderCancel.Visible = false;
            btn_LeaderClose.Visible = false;
            btn_LeaderConfirm.Visible = false;
            tab_ManageExamination.SelectedIndex = 1;
        }

        public void showLeaderWindow()
        {
            txt_LabResult.ReadOnly = true;
            txt_DoctorComment.ReadOnly = true;
            txt_LeaderExaminationDescription.ReadOnly = false;

            btn_ChoiceLaboratoryExamination.Enabled = false;
            btn_DoctorClose.Visible = false;
            btn_DoctorRunTest.Visible = false;
            btn_LabAssisnantClose.Visible = false;
            btn_LabAssistantCancel.Visible = false;
            btn_LabAssistantRealize.Visible = false;
            btn_LeaderCancel.Visible = true;
            btn_LeaderClose.Visible = true;
            btn_LeaderConfirm.Visible = true;
            tab_ManageExamination.SelectedIndex = 2;
        }

        private void DoctorManageLaboratoryExamination_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, "");
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
