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
    public partial class DoctorPhysicalExamination : Form
    {
        int idVisit;
        DoctorManageVisit parentWindow;

        public DoctorPhysicalExamination()
        {
            InitializeComponent();
        }

        public DoctorPhysicalExamination(DoctorManageVisit dMv1)
        {
            this.parentWindow = dMv1;
            InitializeComponent();
        }

        public void setVisitId(int idVis)
        {
            this.idVisit = idVis;
        }

        private void btn_New_Click(object sender, EventArgs e)
        { 
            DoctorRealizePhysicalExamination doctorRealizePhysicalExamination = new DoctorRealizePhysicalExamination(this);
            doctorRealizePhysicalExamination.setIdVisit(idVisit);
            doctorRealizePhysicalExamination.Show();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            int examId = 0;
            int numberOfRow = dgv_PhysicalExamination.CurrentCell.RowIndex;
            examId = Int32.Parse(dgv_PhysicalExamination.Rows[numberOfRow].Cells[0].Value.ToString());
            if (examId == 0)
            {
                MessageBox.Show("Wybierz Badanie");
            }
            else
            {
                DoctorRealizePhysicalExamination doctorRealizePhysicalExamination = new DoctorRealizePhysicalExamination(this);
                doctorRealizePhysicalExamination.setIdVisit(idVisit);

                doctorRealizePhysicalExamination.setIdExam(examId);
                doctorRealizePhysicalExamination.Show();
            }

            
        }

        public void showActualData()
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Badanie bad in context.Badanies
                           from Slownik_badan slo in context.Slownik_badans
                           where idVisit == bad.ID_wiz && slo.Kod == bad.Kod
                           && slo.Typ == 1
                           select new
                           {
                             bad.ID_bad,
                             slo.Nazwa,
                             bad.Dt_zle,
                             bad.Status,
                             bad.Wynik,
                             bad.Dt_wyk_anul,
                             bad.Dt_zatw_anul
                           };

            dgv_PhysicalExamination.DataSource = sourcess;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorPhysicalExamination_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                MessageBox.Show("'Nowe badanie' otwiera okno z wyborem nowego badania fizykalnego.\n" +
                    "'Edytuj badanie' pokazuje i pozwala na edycję szczegółów badania.\n" +
                    "'Powrót' - wyjście bez zapisu"
                    , "Pomoc - Obsługa badań fizykalnych");
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
