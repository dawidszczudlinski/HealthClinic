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
        private DoctorManageVisit parentWindow;
        int idVisit;

        public DoctorLaboratoryExamination()
        {
            InitializeComponent();
        }
        public DoctorLaboratoryExamination(DoctorManageVisit dMv1)
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
            DoctorManageLaboratoryExamination doctorManageLaboratoryExamination = new DoctorManageLaboratoryExamination(this,false);
            doctorManageLaboratoryExamination.showDoctorWindow();
            doctorManageLaboratoryExamination.setVisitId(this.idVisit);
            doctorManageLaboratoryExamination.Show();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            int badId = 0;
            int numberOfRow = dgv_LaboratoryExamination.CurrentCell.RowIndex;
            badId = Int32.Parse(dgv_LaboratoryExamination.Rows[numberOfRow].Cells[0].Value.ToString());
            if (badId == 0)
            {
                MessageBox.Show("Wybierz Badanie");
            }
            else
            {
                DataClasses2DataContext context = new DataClasses2DataContext();
                var sourcess = from Badanie bad in context.Badanies
                               where bad.ID_bad == badId
                               select bad;
                Badanie examination = sourcess.First();

                DoctorManageLaboratoryExamination doctorManageLaboratoryExamination = new DoctorManageLaboratoryExamination(this, true);
                doctorManageLaboratoryExamination.showDoctorWindow();
                doctorManageLaboratoryExamination.setVisitId(this.idVisit);
                doctorManageLaboratoryExamination.setExaminationId(examination.ID_bad);
                doctorManageLaboratoryExamination.Show();
            }
        }

        public void showActualData()
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Badanie bad in context.Badanies
                           from Slownik_badan slo in context.Slownik_badans
                           where idVisit == bad.ID_wiz && slo.Kod == bad.Kod
                           && slo.Typ == 2
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

            dgv_LaboratoryExamination.DataSource = sourcess;
        }
        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorLaboratoryExamination_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                MessageBox.Show("Na liście znajdują się wszystkie badania laboratoryjne związane z daną wizytą" +
                    "Aby pokazać szczegóły badania naciśnij 'Pokaż badanie'.\n\n" +
                    "Aby zlecić nowe badanie naciśnij 'Nowe badanie'.\n" +
                    "Aby wyjść naciśnij 'Powrót'."
                    , "Pomoc - Badania laboratoryjne");
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
