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
    public partial class DoctorManageLaboratoryExamination : Form
    {
        public DoctorManageLaboratoryExamination()
        {
            InitializeComponent();
        }

        private void btn_ChoiceLaboratoryExamination_Click(object sender, EventArgs e)
        {
            DoctorLaboratoryExaminationMap doctorLaboratoryExaminationMap = new DoctorLaboratoryExaminationMap();
            doctorLaboratoryExaminationMap.Show();
        }

        private void btn_LeaderConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przycisk btn_LeaderConfirm");
        }

        private void btn_LeaderCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przycisk btn_LeaderCancel");
        }

        private void btn_LeaderClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przycisk btn_LeaderClose");
        }

        private void btn_DoctorRunTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przycisk btn_DoctorRunTest");
        }

        private void btn_DoctorClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przycisk btn_DoctorClose");
        }

        private void btn_LabAssistantRealize_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przycisk btn_LabAssistantRealize");
        }

        private void btn_LabAssistantCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przycisk btn_LabAssistantCancel");
        }

        private void btn_LabAssisnantClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przycisk btn_LabAssistantClose");
        }

        public void showDoctorWindow()
        {
            btn_DoctorClose.Visible = true;
            btn_DoctorRunTest.Visible = true;
            btn_LabAssisnantClose.Visible = false;
            btn_LabAssistantCancel.Visible = false;
            btn_LabAssistantRealize.Visible = false;
            btn_LeaderCancel.Visible = false;
            btn_LeaderClose.Visible = false;
            btn_LeaderConfirm.Visible = false;
            tab_ManageExamination.SelectedIndex = 0;
        }

        public void showLaboratoryAssistantWindow()
        {
            btn_DoctorClose.Visible = false;
            btn_DoctorRunTest.Visible = false;
            btn_LabAssisnantClose.Visible = true;
            btn_LabAssistantCancel.Visible = true;
            btn_LabAssistantRealize.Visible = true;
            btn_LeaderCancel.Visible = false;
            btn_LeaderClose.Visible = false;
            btn_LeaderConfirm.Visible = false;
            tab_ManageExamination.SelectedIndex = 1;
        }

        public void showLeaderWindow()
        {
            btn_DoctorClose.Visible = false;
            btn_DoctorRunTest.Visible = false;
            btn_LabAssisnantClose.Visible = false;
            btn_LabAssistantCancel.Visible = false;
            btn_LabAssistantRealize.Visible = false;
            btn_LeaderCancel.Visible = true;
            btn_LeaderClose.Visible = true;
            btn_LeaderConfirm.Visible = true;
            tab_ManageExamination.SelectedIndex = 2;
        }
    }
}
