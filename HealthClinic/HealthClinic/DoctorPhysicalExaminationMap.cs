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
        DataClasses1DataContext context = new DataClasses1DataContext();

        private DoctorRealizePhysicalExamination parent;
        private IQueryable<Slownik_badan> listOfSlownik;
        public DoctorPhysicalExaminationMap(DoctorRealizePhysicalExamination parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void DoctorPhysicalExaminationMap_Load(object sender, EventArgs e)
        {
            showActualData();

        }
        public void showActualData()
        {

            var sourcess = from Slownik_badan kon in context.Slownik_badans select kon;

            dataGridView1.DataSource = sourcess;
            context.SubmitChanges();

        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            int codeId = 0;
            int numberOfRow = dataGridView1.CurrentCell.RowIndex;
            codeId = Int32.Parse(dataGridView1.Rows[numberOfRow].Cells[0].Value.ToString());
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
    }
}
