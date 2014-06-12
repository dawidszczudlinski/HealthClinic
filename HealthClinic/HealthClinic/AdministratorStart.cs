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
    public partial class AdministratorStart : Form
    {
        public AdministratorStart()
        {
            InitializeComponent();
        }

        private void btn_ManageAccounts_Click(object sender, EventArgs e)
        {
            AdministratorManageAccounts administratorManageAccounts = new AdministratorManageAccounts();
            administratorManageAccounts.Show();
        }

        private void btn_ManageExamination_Click(object sender, EventArgs e)
        {
            AdministratorManageExamination administratorManageExamination = new AdministratorManageExamination();
            administratorManageExamination.Show();
        }

        private void btn_ManageReceptionist_Click(object sender, EventArgs e)
        {
            AdministratorManageReceptionist administratorManageReceptionist = new AdministratorManageReceptionist();
            administratorManageReceptionist.Show();
        }

        private void btn_ManageDoctors_Click(object sender, EventArgs e)
        {
            AdministratorManageDoctors administratorManageDoctors = new AdministratorManageDoctors();
            administratorManageDoctors.Show();
        }

        private void btn_ManageLaboratoraryAssistant_Click(object sender, EventArgs e)
        {
            AdministratorManageLaboratoryAssistant administratorManageLaboratoryAssistant = new AdministratorManageLaboratoryAssistant();
            administratorManageLaboratoryAssistant.Show();
        }

        private void btn_ManageLeaderLaboratory_Click(object sender, EventArgs e)
        {
            AdministratorManageLeaderLaboratory administratorManageLeaderLaboratory = new AdministratorManageLeaderLaboratory();
            administratorManageLeaderLaboratory.Show();
        }
    }
}
