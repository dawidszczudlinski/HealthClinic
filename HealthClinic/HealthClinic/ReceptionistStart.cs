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
    public partial class ReceptionistStart : Form
    {
        public ReceptionistStart()
        {
            InitializeComponent();
        }

        private void btn_RegisterVisit_Click(object sender, EventArgs e)
        {
            RegisterVisit registerVisit = new RegisterVisit();
            registerVisit.Show();
        }

        private void btn_ManageVisits_Click(object sender, EventArgs e)
        {
            ShowManageVisits showManageVisits = new ShowManageVisits();
            showManageVisits.Show();
        }

        private void ReceptionistStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
                MessageBox.Show("Aby zarejestrować pacjenta na wizytę naciśnij 'Zarejestruj Wizytę'.\n\n" + 
                    "Aby zarządzać wizytami naciśnij 'Zarządzaj wizytami'.", "Pomoc");
        }
    }
}
