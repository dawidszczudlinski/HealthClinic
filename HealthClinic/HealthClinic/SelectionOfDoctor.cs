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
    public partial class SelectionOfDoctor : Form
    {
        private ManageVisit parent;
        public SelectionOfDoctor(ManageVisit parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        public void setDate(DateTime date)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var sourcess = from Lekarz lek in context.Lekarzs
                           select new { lek.ID_lek, lek.Imie, lek.Nazwisko, counter = 
                           (from Wizyta wiz in context.Wizytas 
                            where wiz.ID_lek == lek.ID_lek &&
                            wiz.Dt_rej == date
                            select wiz).Count()
                           };
            int counter = 0;
            foreach (var doctor in sourcess)
            {
                dgv_ListOfDoctors.Rows.Add();
                dgv_ListOfDoctors.Rows[counter].Cells[0].Value = doctor.ID_lek;
                dgv_ListOfDoctors.Rows[counter].Cells[1].Value = doctor.Imie;
                dgv_ListOfDoctors.Rows[counter].Cells[2].Value = doctor.Nazwisko;
                dgv_ListOfDoctors.Rows[counter++].Cells[3].Value = doctor.counter;
            }
        }

        private void btn_Choice_Click(object sender, EventArgs e)
        {
            int doctorId = 0;
            int numberOfRow = dgv_ListOfDoctors.CurrentCell.RowIndex;
            doctorId = Int32.Parse(dgv_ListOfDoctors.Rows[numberOfRow].Cells[0].Value.ToString());
            
            if (doctorId == 0)
            {
                MessageBox.Show("Wybierz lekarza");
            }
            else
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                var sourcess = from Lekarz lek in context.Lekarzs
                               where lek.ID_lek == doctorId
                               select lek;

                Lekarz doctor = sourcess.First();
                parent.chooseDoctor(doctor);
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
