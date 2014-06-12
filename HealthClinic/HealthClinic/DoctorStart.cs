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
    public partial class DoctorStart : Form
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        private Pacjent patient = null;
        private static string text;
        private static string combo;
        private static string name;
        private static string pesel;
        private static string lastName;
        private static string wyb;
        private IQueryable<Wizyta> listOfVisits;
        private IQueryable<Pacjent> listOfPatients;
        public DoctorStart()
        {
            InitializeComponent();
        }

        private void btn_ChoiceVisit_Click(object sender, EventArgs e)
        {
            int numberOfRow = dgv_visits.CurrentCell.RowIndex;
            int wizId = Int32.Parse(dgv_visits.Rows[numberOfRow].Cells[0].Value.ToString());

            DataClasses1DataContext context = new DataClasses1DataContext();
            var sourcess = from Wizyta wiz in context.Wizytas where wiz.ID_wiz == wizId select wiz;


            if (sourcess != null)
            {
                DoctorManageVisit doctorManageVisit = new DoctorManageVisit(this);
                doctorManageVisit.setVisit(sourcess.First());
                doctorManageVisit.Show();
            }
            else
            {
                MessageBox.Show("Wybierz Wizyte");
            }
        }

        /*public void showActualData()
        {
           
          //  listOfVisits = from Wizyta wiz in context.Wizytas select wiz;
            var sourcess = from Wizyta kon in context.Wizytas select kon;

            dgv_visits.DataSource = sourcess;
            context.SubmitChanges();
          //  visits.DataSource = listOfVisits;
        }*/
        private void btn_Search_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var sourcess = from Wizyta wiz in context.Wizytas
                           from Pacjent pac in context.Pacjents
                           where wiz.ID_lek == CurrentAccount.getAccount().ID &&
                                 wiz.ID_pac == pac.ID_pac
                           select new
                           {
                               wiz.ID_wiz,
                               wiz.Dt_rej,
                               wiz.Status,
                               imiePacjenta = pac.Imie,
                               nazwiskoPacjenta = pac.Nazwisko,
                               wiz.Dt_zak
                           };
            if (cmb_State.Text != "")
                sourcess = sourcess.Where(p => p.Status.Contains(cmb_State.Text));
            if (dtp_Date.Checked == true)
                sourcess = sourcess.Where(p => p.Dt_rej == dtp_Date.Value);
            dgv_visits.DataSource = sourcess;
            /*int command = 0;
            combo = cmb_State.Text;
            text = dateTimePicker2.Text;
           
           // MessageBox.Show(dateTimePicker2.Text);
            if (cmb_State!=null)
                command += 2;
                
            if (!("".Equals(text)))
                command += 1;

            switch (command)
            {
                case 1:
                    listOfVisits = from Wizyta wiz in context.Wizytas where Convert.ToDateTime(text) == wiz.Dt_rej select wiz;
                    break;
              case 3:
                    listOfVisits = from Wizyta wiz in context.Wizytas where combo == wiz.Status && Convert.ToDateTime(text) == wiz.Dt_rej select wiz;
                   break;
                

                // name
            }
            visits.DataSource = listOfVisits;*/
            

        }
    }
}
