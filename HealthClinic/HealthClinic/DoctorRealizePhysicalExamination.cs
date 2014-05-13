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
    public partial class DoctorRealizePhysicalExamination : Form
    {
        public DoctorRealizePhysicalExamination()
        {
            InitializeComponent();
        }

        private void btn_ChoiceExamination_Click(object sender, EventArgs e)
        {
            DoctorPhysicalExaminationMap doctorPhysicalExaminationMap = new DoctorPhysicalExaminationMap();
            doctorPhysicalExaminationMap.Show();
        }
    }
}
