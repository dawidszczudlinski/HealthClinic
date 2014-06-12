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
        DataClasses1DataContext context = new DataClasses1DataContext();
        private DoctorStart parentWindow;
        int v;
        private Pacjent patient ;
        private Wizyta visit;
        private IQueryable<Wizyta> listOfVisits;
        private IQueryable<Pacjent> listOfPatients;
        public DoctorManageVisit( DoctorStart dS)
        {
            InitializeComponent();
            parentWindow = dS;
        }
         

     public void setVisit(Wizyta visit)
        {
            txt_IDVisit.Text= visit.ID_wiz.ToString();

           
            var sourcess = from Pacjent pac in context.Pacjents
                           select new
                           {
                               pac.ID_pac,
                               pac.Imie,
                               pac.Nazwisko,
                               counter =
                                   (from Wizyta wiz in context.Wizytas
                                    where wiz.ID_pac == pac.ID_pac
                                    select pac).Count()
                           };

            foreach (var paci in sourcess)
            {
                    txt_LastName.Text = paci.Nazwisko;
                    txt_Name.Text = paci.Imie;
                    
            }
       
           this.visit = visit;
        
        }
     public int idV()
     {
         return visit.ID_wiz;
     }
       
        private void btn_PhysicalExamination_Click(object sender, EventArgs e)
        {
           
            DoctorPhysicalExamination doctorPhysicalExamination = new DoctorPhysicalExamination(this);
            doctorPhysicalExamination.Show();
        }

        private void btn_LaboratoryExamination_Click(object sender, EventArgs e)
        {
            DoctorLaboratoryExamination doctorLaboratoryExamination = new DoctorLaboratoryExamination();
            doctorLaboratoryExamination.Show();
        }
       
        
        private void btn_Finish_Click(object sender, EventArgs e)
        {
            
          // var query =(from W 
            visit.ID_wiz = this.visit.ID_wiz;
            visit.Dt_rej = this.visit.Dt_rej;
            visit.Status = "zak";
            visit.Dt_zak = DateTime.Now;
            visit.Opis = txt_Description.Text;
            visit.Diagnoza = txt_Diagnosis.Text;
            visit.ID_pac = visit.ID_pac;
            visit.ID_rej = 1;
            visit.ID_lek = visit.ID_lek;
               // visit = this.visit;

            this.context.SubmitChanges();
            //this.context.
            this.Close();
           
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
