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
    public partial class LeaderLaboratoryStart : Form
    {
        public LeaderLaboratoryStart()
        {
            InitializeComponent();
        }
        private void btn_ServicePatient_Click(object sender, EventArgs e)
        {
            int idExamination = 0;
            int numberOfRow = dgv_ListOfVisits.CurrentCell.RowIndex;
            idExamination = Int32.Parse(dgv_ListOfVisits.Rows[numberOfRow].Cells[0].Value.ToString());
            if (idExamination == 0)
            {
                MessageBox.Show("Wybierz Badanie");
            }
            else
            {
                DataClasses2DataContext context = new DataClasses2DataContext();
                var sourcess = from Badanie bad in context.Badanies
                               where bad.ID_bad == idExamination
                               select bad;

                Badanie examination = sourcess.First();
                DoctorManageLaboratoryExamination doctorManageLaboratoryExamination = new DoctorManageLaboratoryExamination(this);
                doctorManageLaboratoryExamination.showLeaderWindow();
                doctorManageLaboratoryExamination.setVisitId(examination.ID_wiz);
                doctorManageLaboratoryExamination.setExaminationId(examination.ID_bad);
                doctorManageLaboratoryExamination.Show();
            }
        }

        public void showActualData()
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Badanie bad in context.Badanies
                           from Wizyta wiz in context.Wizytas
                           from Pacjent pac in context.Pacjents
                           from Slownik_badan slo in context.Slownik_badans
                           where wiz.ID_wiz == bad.ID_wiz &&
                                 bad.Kod == slo.Kod &&
                                 pac.ID_pac == wiz.ID_pac &&
                                 slo.Typ == 2
                           select new
                           {
                               bad.ID_bad,
                               slo.Kod,
                               slo.Nazwa,
                               pac.Imie,
                               pac.Nazwisko,
                               pac.PESEL,
                               bad.Dt_zle,
                               bad.Status
                           };
            if (cmb_State.Text != "")
                sourcess = sourcess.Where(p => p.Status.Contains(cmb_State.Text));

            dgv_ListOfVisits.DataSource = sourcess;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.showActualData();
        }

        private void LeaderLaboratoryStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                MessageBox.Show("Lista zawiera wszystkie badania laboratoryjnek które można zaakceptować lub odrzucić."
                    , "Pomoc - Okno główne kierownika laboratorium");
        }
    }
}
