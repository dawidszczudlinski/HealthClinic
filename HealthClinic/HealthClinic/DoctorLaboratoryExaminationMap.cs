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
    public partial class DoctorLaboratoryExaminationMap : Form
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        private DoctorManageLaboratoryExamination parent;
        private IQueryable<Slownik_badan> listOfSlownik;
        public DoctorLaboratoryExaminationMap(DoctorManageLaboratoryExamination parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void DoctorLaboratoryExaminationMap_Load(object sender, EventArgs e)
        {
            showActualData();

        }
        public void showActualData()
        {

            var sourcess = from Slownik_badan kon in context.Slownik_badans select kon;

            dgv_LaboratoryExamination.DataSource = sourcess;
            context.SubmitChanges();

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int codeId = 0;
            int numberOfRow = dgv_LaboratoryExamination.CurrentCell.RowIndex;
            codeId = Int32.Parse(dgv_LaboratoryExamination.Rows[numberOfRow].Cells[0].Value.ToString());
            if (codeId == 0)
            {
                MessageBox.Show("Wybierz Badanie");
            }
            else
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                var sourcess = from Slownik_badan sl in context.Slownik_badans
                               where sl.Kod == codeId
                               select sl;

                Slownik_badan slownik = sourcess.First();
                parent.chooseCode(slownik);
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
