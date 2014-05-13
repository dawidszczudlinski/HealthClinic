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
        public DoctorStart()
        {
            InitializeComponent();
        }

        private void btn_ChoiceVisit_Click(object sender, EventArgs e)
        {
            DoctorManageVisit doctorManageVisit = new DoctorManageVisit();
            doctorManageVisit.Show();
        }
    }
}
