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
    public partial class RegisterVisit : Form
    {
        public RegisterVisit()
        {
            InitializeComponent();
        }

        private void btn_Visit_Click(object sender, EventArgs e)
        {
            ManageVisit manageVisit = new ManageVisit();
            manageVisit.Show();
        }
    }
}
