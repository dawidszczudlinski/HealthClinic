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
    public partial class DoctorManageVisit : Form
    {
        public DoctorManageVisit()
        {
            InitializeComponent();
        }

        private void btn_PhysicalExamination_Click(object sender, EventArgs e)
        {
            DoctorPhysicalExamination doctorPhysicalExamination = new DoctorPhysicalExamination();
            doctorPhysicalExamination.Show();
        }

        private void btn_LaboratoryExamination_Click(object sender, EventArgs e)
        {
            DoctorLaboratoryExamination doctorLaboratoryExamination = new DoctorLaboratoryExamination();
            doctorLaboratoryExamination.Show();
        }
    }
}
