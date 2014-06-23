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

    public partial class DoctorManageVisit : Form
    {
        private DoctorStart parentWindow;
        private Wizyta visit;
        public DoctorManageVisit(DoctorStart dS)
        {
            InitializeComponent();
            parentWindow = dS;
        }


        public void setVisit(Wizyta visitToManage)
        {
            DataClasses2DataContext context = new DataClasses2DataContext();
            this.visit = visitToManage;

            var sourcess = from Pacjent pac in context.Pacjents
                           where pac.ID_pac == visit.ID_pac
                           select pac;

            txt_IDVisit.Text = visit.ID_wiz.ToString();
            txt_LastName.Text = sourcess.First().Nazwisko;
            txt_Name.Text = sourcess.First().Imie;
            txt_Description.Text = visit.Opis;
            txt_Diagnosis.Text = visit.Diagnoza;
        }

        public Wizyta getVisit()
        {
            return visit;
        }

        private void btn_PhysicalExamination_Click(object sender, EventArgs e)
        {
            DoctorPhysicalExamination doctorPhysicalExamination = new DoctorPhysicalExamination(this);
            doctorPhysicalExamination.setVisitId(visit.ID_wiz);
            doctorPhysicalExamination.Show();
            doctorPhysicalExamination.showActualData();
        }

        private void btn_LaboratoryExamination_Click(object sender, EventArgs e)
        {
            DoctorLaboratoryExamination doctorLaboratoryExamination = new DoctorLaboratoryExamination();
            doctorLaboratoryExamination.setVisitId(visit.ID_wiz);
            doctorLaboratoryExamination.Show();
            doctorLaboratoryExamination.showActualData();
        }


        private void btn_Finish_Click(object sender, EventArgs e)
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Wizyta wiz in context.Wizytas
                           where wiz.ID_wiz == visit.ID_wiz
                           select wiz;

            visit = sourcess.First();
            visit.Opis = txt_Description.Text;
            visit.Diagnoza = txt_Diagnosis.Text;
            visit.Dt_zak = DateTime.Now;
            visit.Status = "zak";
            context.SubmitChanges();

            this.Close();
            parentWindow.showData();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Wizyta wiz in context.Wizytas
                           where wiz.ID_wiz == visit.ID_wiz
                           select wiz;

            visit = sourcess.First();
            visit.Opis = txt_Description.Text;
            visit.Diagnoza = txt_Diagnosis.Text;
            visit.Dt_zak = DateTime.Now;
            visit.Status = "odw";
            context.SubmitChanges();

            this.Close();
            parentWindow.showData();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Wizyta wiz in context.Wizytas
                           where wiz.ID_wiz == visit.ID_wiz
                           select wiz;

            visit = sourcess.First();
            visit.Status = "rozp";
            context.SubmitChanges();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            parentWindow.showData();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {

        }
    }
}
