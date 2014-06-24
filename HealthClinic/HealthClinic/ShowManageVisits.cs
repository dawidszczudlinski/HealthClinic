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
        public ShowManageVisits()
        {
            InitializeComponent();

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

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
            DataClasses2DataContext context = new DataClasses2DataContext();

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
            
        }

        private void btn_CancelVisit_Click(object sender, EventArgs e)
        {
            int numberOfRow = dgv_ListOfVisits.CurrentCell.RowIndex;
            int wizId = Int32.Parse(dgv_ListOfVisits.Rows[numberOfRow].Cells[0].Value.ToString());

            DataClasses2DataContext context = new DataClasses2DataContext();
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

        private void ShowManageVisits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                MessageBox.Show("Aby wyszukać wizytę w bazie wpisz jego dane. Dane nie muszą być pełne.\n\n" +
                    "Aby odwołać wizytę wybierz wizytę z listy i naciśnij 'Anuluj wiytę'.\n\n"
                    , "Pomoc - Menager wizyt");
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
