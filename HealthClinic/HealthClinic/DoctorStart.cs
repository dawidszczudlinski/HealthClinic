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
        DataClasses2DataContext context = new DataClasses2DataContext();
        public DoctorStart()
        {
            InitializeComponent();
        }

        private void btn_ChoiceVisit_Click(object sender, EventArgs e)
        {
            int numberOfRow = dgv_visits.CurrentCell.RowIndex;
            int wizId = Int32.Parse(dgv_visits.Rows[numberOfRow].Cells[0].Value.ToString());

            DataClasses2DataContext context = new DataClasses2DataContext();
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

        public void showData()
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

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

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.showData();
        }

        private void DoctorStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, "");
        }
    }
}
