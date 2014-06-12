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
        private DoctorPhysicalExamination dMv;
      
        private Slownik_badan sl;
        private Wizyta wizyt;
        private Badanie badanie;
        int iDwiz;
        DataClasses1DataContext context = new DataClasses1DataContext();

        public DoctorRealizePhysicalExamination()
        {
            InitializeComponent();
            
        }
        public DoctorRealizePhysicalExamination(DoctorPhysicalExamination dMv1)
        {
            this.dMv = dMv1;
            InitializeComponent();

        }
        private void btn_ChoiceExamination_Click(object sender, EventArgs e)
        {
            DoctorPhysicalExaminationMap doctorPhysicalExaminationMap = new DoctorPhysicalExaminationMap(this);
            doctorPhysicalExaminationMap.Show();
        }
        public void chooseCode(Slownik_badan sl)
        {
            txt_ExaminationCode.Text = sl.Kod.ToString();
            txt_ExaminationName.Text = sl.Nazwa;
            this.sl = sl;

        }

        private void btn_OK_Click(object sender, EventArgs e)  
        {
            
           
            badanie = new Badanie();
            badanie.Dt_zle = DateTime.Now;
            badanie.ID_wiz = dMv.idV1(); 
            badanie.Dt_wyk_anul = null;
            badanie.Opis = null;
            badanie.Wynik = null;
            badanie.Uwagi = null;
            badanie.Dt_zatw_anul = null;
            badanie.ID_lab = null;
            badanie.ID_Klab = null;
            badanie.Status = "Zle";
            badanie.Kod = sl.Kod;
            
            context.Badanies.InsertOnSubmit(badanie);
            context.SubmitChanges();

            dMv.showActualData();
            this.Close();  
           
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
