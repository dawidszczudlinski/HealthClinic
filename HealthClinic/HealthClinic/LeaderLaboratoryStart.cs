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
    public partial class LeaderLaboratoryStart : Form
    {
        public LeaderLaboratoryStart()
        {
            InitializeComponent();
        }

        private void btn_ShowExamination_Click(object sender, EventArgs e)
        {
            DoctorManageLaboratoryExamination doctorManageLaboratoryExamination = new DoctorManageLaboratoryExamination();
            doctorManageLaboratoryExamination.showLeaderWindow();
            doctorManageLaboratoryExamination.Show();
        }

        private void btn_ServicePatient_Click(object sender, EventArgs e)
        {
            DoctorManageLaboratoryExamination doctorManageLaboratoryExamination = new DoctorManageLaboratoryExamination();
            doctorManageLaboratoryExamination.showLeaderWindow();
            doctorManageLaboratoryExamination.Show();
        }
    }
}
