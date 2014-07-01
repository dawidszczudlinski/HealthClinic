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
    public partial class Raport : Form
    {
        int patient;

        public Raport(int p)
        {
            InitializeComponent();
            patient = p;
        }

        private void Raport_Load(object sender, EventArgs e)
        {
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // TODO: This line of code loads data into the 'DataSetRaport.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetRaport.DataTable1, patient);

            this.reportViewer1.RefreshReport();
        }

        private void Raport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, "");
        }
    }
}
