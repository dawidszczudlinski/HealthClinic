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
        private Slownik_badan sl;
        DataClasses1DataContext context = new DataClasses1DataContext();
        private Badanie badanie;
        private Konto konto;
        private DoctorLaboratoryExamination dMv;
        private LaboratoryAssistantStart lAs;
       private LeaderLaboratoryStart lLs;
        public DoctorManageLaboratoryExamination()
        {
            InitializeComponent();
        }
        public DoctorManageLaboratoryExamination( LaboratoryAssistantStart lAs1)
        {
            this.lAs = lAs1;
            InitializeComponent();
        }
        public DoctorManageLaboratoryExamination(LeaderLaboratoryStart lLs1)
        {
            this.lLs = lLs1;
            InitializeComponent();
        }
        public DoctorManageLaboratoryExamination(DoctorLaboratoryExamination dMv1)
        {
            this.dMv = dMv1;
            InitializeComponent();
        }
       
        private void btn_ChoiceLaboratoryExamination_Click(object sender, EventArgs e)
        {
            DoctorLaboratoryExaminationMap doctorLaboratoryExaminationMap = new DoctorLaboratoryExaminationMap(this);
            doctorLaboratoryExaminationMap.Show();
        }
        public void chooseCode(Slownik_badan sl)
        {
            textBox2.Text = sl.Kod.ToString();
            textBox3.Text = sl.Nazwa;
            
            this.sl = sl;

        }
        private void btn_LeaderConfirm_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Przycisk btn_LeaderConfirm");
            badanie.Opis =txt_LeaderExaminationDescription.Text;
            badanie.Dt_zatw_anul = DateTime.Now;
            badanie.ID_Klab = 1;

             this.context.SubmitChanges();
            lLs.showActualData();
            this.Close();
        }

        private void btn_LeaderCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przycisk btn_LeaderCancel");
        }

        private void btn_LeaderClose_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Przycisk btn_LeaderClose");
            this.Close();
        }

        private void btn_DoctorRunTest_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Przycisk btn_DoctorRunTest");
            badanie = new Badanie();
            badanie.Dt_zle = DateTime.Now;
            badanie.ID_wiz = dMv.idV1();
            badanie.Dt_wyk_anul = null;
            badanie.Opis = null;
            badanie.Wynik = null;
            badanie.Kod = Convert.ToInt32(textBox2.Text);
            badanie.ID_bad = Convert.ToInt32(textBox1.Text);
            badanie.Uwagi = textBox4.Text;
            badanie.ID_lab = null;
            badanie.ID_Klab = null;
            badanie.Status = "Zle";
            context.Badanies.InsertOnSubmit(badanie);
            context.SubmitChanges();
            dMv.showActualData();
            this.Close();
        }

        private void btn_DoctorClose_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Przycisk btn_DoctorClose");
            this.Close();
        }

        private void btn_LabAssistantRealize_Click(object sender, EventArgs e)
        {
          

            badanie.Wynik = txt_LabResult.Text;
             badanie.ID_lab = 1;
            badanie.Dt_wyk_anul = DateTime.Now;
            badanie.Status = "wT";
           this.context.SubmitChanges();
            lAs.showActualData();
            this.Close();  
        }

        private void btn_LabAssistantCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przycisk btn_LabAssistantCancel");
        }

        private void btn_LabAssisnantClose_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Przycisk btn_LabAssistantClose");
            this.Close();
        }
        public void setVisit(Badanie visit)
        {
            txt_LabIDExamination.Text = visit.ID_bad.ToString();
            txt_LabExaminationCode.Text = visit.Kod.ToString();
            txt_LeaderIDExamination.Text = visit.ID_bad.ToString();
            txt_LeaderExaminationCode.Text = visit.Kod.ToString();
            var sourcess = from Slownik_badan sl in context.Slownik_badans
                           select new
                           {
                               sl.Kod,
                               sl.Nazwa,
                               counter =
                                   (from Badanie  wiz in context.Badanies
                                    where wiz.Kod == sl.Kod
                                    select sl).Count()
                           };

            foreach (var paci in sourcess)
            {
                txt_LabExaminationName.Text = paci.Nazwa;
                txt_LeaderExaminationName.Text = paci.Nazwa;

            }

            this.badanie = visit;

        }
        public void showDoctorWindow()
        {
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
    }
}
