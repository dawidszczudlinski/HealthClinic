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
    public partial class DoctorRealizePhysicalExamination : Form
    {
        private DoctorPhysicalExamination parentWindow;

        int idExamination;
        int examinationCode;
        int idVisit;
        bool isEdit;

        public DoctorRealizePhysicalExamination()
        {
            InitializeComponent();
            
        }
        public DoctorRealizePhysicalExamination(DoctorPhysicalExamination dMv1)
        {
            this.parentWindow = dMv1;
            InitializeComponent();
            isEdit = false;
        }

        public void setIdExam(int idExam)
        {
            idExamination = idExam;
            isEdit = true;
            showActualData();
        }

        public void setIdVisit(int idVis)
        {
            idVisit = idVis;
        }

        public void showActualData()
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Badanie bad in context.Badanies
                           where idExamination == bad.ID_bad
                           select bad;
            Badanie exam = sourcess.First();

            var sourcess2 = from Slownik_badan slo in context.Slownik_badans
                            where exam.Kod == slo.Kod
                            select slo;
            Slownik_badan examinationType = sourcess2.First();

            txt_IDExamination.Text = exam.ID_bad.ToString();
            txt_ExaminationCode.Text = examinationType.Kod.ToString();
            txt_ExaminationName.Text = examinationType.Nazwa;
            txt_ExaminationResult.Text = exam.Wynik;
        }

        private void btn_ChoiceExamination_Click(object sender, EventArgs e)
        {
            DoctorPhysicalExaminationMap doctorPhysicalExaminationMap = new DoctorPhysicalExaminationMap(this);
            doctorPhysicalExaminationMap.Show();
        }

        public void setExaminationType(int examination)
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            examinationCode = examination;

            var sourcess2 = from Slownik_badan slo in context.Slownik_badans
                            where slo.Kod == examination
                            select slo;
            Slownik_badan examinationType = sourcess2.First();

            txt_ExaminationCode.Text = examinationType.Kod.ToString();
            txt_ExaminationName.Text = examinationType.Nazwa;
        }

        private void btn_OK_Click(object sender, EventArgs e)  
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            Badanie examination;

            if (isEdit == true)
            {
                var sourcess = from Badanie bad in context.Badanies
                               where idExamination == bad.ID_bad
                               select bad;
                examination = sourcess.First();

                examination.Wynik = txt_ExaminationResult.Text;
                examination.Dt_zle = DateTime.Now;
                examination.Dt_wyk_anul = DateTime.Now;
                examination.Dt_zatw_anul = DateTime.Now;
                examination.Kod = Int32.Parse(txt_ExaminationCode.Text);
            }
            else
            {
                examination = new Badanie();

                examination.ID_wiz = idVisit;         
                examination.Wynik = txt_ExaminationResult.Text;
                examination.Opis = null;
                examination.Uwagi = null;   
                examination.Dt_zle = DateTime.Now;
                examination.Dt_wyk_anul = DateTime.Now;
                examination.Dt_zatw_anul = DateTime.Now;
                examination.ID_lab = null;
                examination.ID_Klab = null;
                examination.Status = "Wyk";
                examination.Kod = Int32.Parse(txt_ExaminationCode.Text);
                context.Badanies.InsertOnSubmit(examination);
            }
            
            context.SubmitChanges();

            parentWindow.showActualData();
            this.Close();   
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorRealizePhysicalExamination_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, "");
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
