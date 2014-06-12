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
    public partial class ShowManageVisits : Form
    {
        private DataClasses1DataContext context = new DataClasses1DataContext();
        private string lastName;
        private string name;
        private Wizyta visit;
        private IQueryable<Wizyta> listOfVisits;
        private IQueryable<Pacjent> listOfPatients;
        private string state;
        public ShowManageVisits()
        {
            InitializeComponent();

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var sourcess = from Wizyta wiz in context.Wizytas
                           from Pacjent pac in context.Pacjents
                           from Lekarz lek in context.Lekarzs
                           where lek.ID_lek == wiz.ID_lek &&
                                 wiz.ID_pac == pac.ID_pac
                           select new
                           {
                               wiz.ID_wiz,
                               wiz.Dt_rej,
                               wiz.Status,
                               imiePacjenta = pac.Imie,
                               nazwiskoPacjenta = pac.Nazwisko,
                               imieLekarza = lek.Imie,
                               nazwiskoLekarza = lek.Nazwisko
                           };
            dgv_ListOfVisits.DataSource = sourcess;
        }
      
        private void btn_Search_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var sourcess = from Wizyta wiz in context.Wizytas
                           from Pacjent pac in context.Pacjents
                           from Lekarz lek in context.Lekarzs
                           where lek.ID_lek == wiz.ID_lek &&
                                 wiz.ID_pac == pac.ID_pac
                           select new
                           {
                               wiz.ID_wiz,
                               wiz.Dt_rej,
                               wiz.Status,
                               imiePacjenta = pac.Imie,
                               nazwiskoPacjenta = pac.Nazwisko,
                               imieLekarza = lek.Imie,
                               nazwiskoLekarza = lek.Nazwisko
                           };
            if (txt_LastName.Text != "")
                sourcess = sourcess.Where(p => p.nazwiskoPacjenta.Contains(txt_LastName.Text));
            if (txt_Name.Text != "")
                sourcess = sourcess.Where(p => p.imiePacjenta.Contains(txt_Name.Text));
            if (cmb_State.Text != "")
                sourcess = sourcess.Where(p => p.Status.Contains(cmb_State.Text));
            if (dtp_Date.Checked == true)
                sourcess = sourcess.Where(p => p.Dt_rej == dtp_Date.Value);
            dgv_ListOfVisits.DataSource = sourcess;
            /*
            var sourcess = from Wizyta wiz in context.Wizytas
                           from Pacjent pac in context.Pacjents
                           from Lekarz lek in context.Lekarzs
                           where lek.ID_lek == wiz.ID_lek &&
                                 wiz.ID_pac == pac.ID_pac
                           select new 
                           { wiz.ID_wiz, wiz.Dt_rej, wiz.Status, 
                             imiePacjenta = pac.Imie, 
                             nazwiskoPacjenta = pac.Nazwisko,
                             imieLekarza = lek.Imie,
                             nazwiskoLekarza = lek.Nazwisko
                           };

            dgv_ListOfVisits.DataSource = sourcess;*/
            
           /*int command = 0;
           state = cmb_State.Text;
           lastName = txt_LastName.Text;
           name = txt_Name.Text;

           if (dtp_Date.Checked == true)
               command += 8;
           if (!("".Equals(state.ToString())))
               command += 4;
           if(!("".Equals(lastName)))
               command += 2;
           if (!("".Equals(name)))
               command += 1;*/

            /*
             * 
             *  0 	wszystko
                1	N
                2	L
                3	N + L
                4	S
                5	S + N
                6	S + L
                7	S + N + L
                8	D
                9	D + N
                10	D + L
                11	D + N + L
                12	D + S
                13	D + S + N
                14	D + S + L
                15	D + S + N + L
             
             
            switch (command)
            {
                case 0:
                    listOfVisits = from Wizyta wiz in context.Wizytas select wiz;
                    break;
                case 1:
                    //listOfVisits = from Wizyta wiz in context.Wizytas where name = wiz.na select wiz;
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                default:
                    break;
            }
            dgv_ListOfVisits.DataSource = listOfVisits;
              */
           
        }

        private void btn_CancelVisit_Click(object sender, EventArgs e)
        {
            int numberOfRow = dgv_ListOfVisits.CurrentCell.RowIndex;
            int wizId = Int32.Parse(dgv_ListOfVisits.Rows[numberOfRow].Cells[0].Value.ToString());

            DataClasses1DataContext context = new DataClasses1DataContext();
            var sourcess = from Wizyta wiz in context.Wizytas where wiz.ID_wiz == wizId select wiz;
            sourcess.First().Status = "odw";
            context.SubmitChanges();

            var sourcess2 = from Wizyta wiz in context.Wizytas
                           from Pacjent pac in context.Pacjents
                           from Lekarz lek in context.Lekarzs
                           where lek.ID_lek == wiz.ID_lek &&
                                 wiz.ID_pac == pac.ID_pac
                           select new
                           {
                               wiz.ID_wiz,
                               wiz.Dt_rej,
                               wiz.Status,
                               imiePacjenta = pac.Imie,
                               nazwiskoPacjenta = pac.Nazwisko,
                               imieLekarza = lek.Imie,
                               nazwiskoLekarza = lek.Nazwisko
                           };

            dgv_ListOfVisits.DataSource = sourcess2;
        }
    }
}
