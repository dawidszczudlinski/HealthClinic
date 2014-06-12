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
    public partial class DoctorLaboratoryExamination : Form
    {
       private DoctorManageVisit dMv;
        DataClasses1DataContext context = new DataClasses1DataContext();
        public DoctorLaboratoryExamination()
        {
            InitializeComponent();
        }
        public DoctorLaboratoryExamination(DoctorManageVisit dMv1)
        {
            this.dMv = dMv1;
            InitializeComponent();
        }
        public int idV1()
        {
            return dMv.idV();
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            DoctorManageLaboratoryExamination doctorManageLaboratoryExamination = new DoctorManageLaboratoryExamination(this);
            doctorManageLaboratoryExamination.showDoctorWindow();
            doctorManageLaboratoryExamination.Show();
        }

        private void DoctorLaboratoryExamination_Load(object sender, EventArgs e)
        {
            showActualData();
        }
        public void showActualData()
        {

            //  listOfVisits = from Wizyta wiz in context.Wizytas select wiz;
            var sourcess = from Badanie kon in context.Badanies select kon;

            dgv_PhysicalExamination.DataSource = sourcess;
            context.SubmitChanges();
            //  visits.DataSource = listOfVisits;
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {

        }
        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
