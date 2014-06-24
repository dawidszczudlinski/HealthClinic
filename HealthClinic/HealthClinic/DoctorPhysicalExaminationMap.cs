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
    public partial class DoctorPhysicalExaminationMap : Form
    {
        private DoctorRealizePhysicalExamination parentWindow;

        public DoctorPhysicalExaminationMap(DoctorRealizePhysicalExamination parent)
        {
            this.parentWindow = parent;
            InitializeComponent();
            showActualData();
        }

        public void showActualData()
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Slownik_badan slo in context.Slownik_badans 
                           where slo.Typ == 1
                           select slo;

            dgv_ListOfExaminations.DataSource = sourcess;
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            int codeId = 0;
            int numberOfRow = dgv_ListOfExaminations.CurrentCell.RowIndex;
            codeId = Int32.Parse(dgv_ListOfExaminations.Rows[numberOfRow].Cells[0].Value.ToString());
            if (codeId == 0)
            {
                MessageBox.Show("Wybierz Badanie");
            }
            else
            {
                DataClasses2DataContext context = new DataClasses2DataContext();
                var sourcess = from Slownik_badan sl in context.Slownik_badans
                               where sl.Kod == codeId
                               select sl;

                Slownik_badan slownik = sourcess.First();
                parentWindow.setExaminationType(slownik.Kod);
                this.Close();
            }
        }

        private void DoctorPhysicalExaminationMap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                MessageBox.Show("Lista prezentuje dostępne w systemie badania fizykalne.\n\n" +
                    "Po wybraniu z listy badania kliknij 'Zatwierdź'.\n" +
                    "Aby wyjść bez zapisu naciśnij 'Powrót'."
                    , "Pomoc - Wybór badania fizykalnego");
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
