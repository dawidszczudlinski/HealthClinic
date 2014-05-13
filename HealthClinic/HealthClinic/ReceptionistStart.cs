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
    }
}
