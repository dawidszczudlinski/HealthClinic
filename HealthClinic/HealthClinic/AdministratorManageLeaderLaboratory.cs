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
    public partial class AdministratorManageLeaderLaboratory : Form
    {
        public AdministratorManageLeaderLaboratory()
        {
            InitializeComponent();
            showActualData();
        }

        public void showActualData()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var sourcess = from Kierownik_Laboratorium klab in context.Kierownik_Laboratoriums select klab;

            dgv_ListOfLeaders.DataSource = sourcess;
        }

        private void btn_AddLeader_Click(object sender, EventArgs e)
        {
            AdministratorAddEditLeaderLaboratory administratorAddEditLeaderLaboratory = new AdministratorAddEditLeaderLaboratory(this);
            administratorAddEditLeaderLaboratory.Show();
        }

        private void btn_EditLeader_Click(object sender, EventArgs e)
        {
            Kierownik_Laboratorium editableLeader = (Kierownik_Laboratorium)dgv_ListOfLeaders.CurrentRow.DataBoundItem;

            AdministratorAddEditLeaderLaboratory administratorAddEditLeaderLaboratory = new AdministratorAddEditLeaderLaboratory(this, editableLeader.ID_Klab);
            administratorAddEditLeaderLaboratory.Show();
        }

        private void btn_DeleteLeader_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            Kierownik_Laboratorium leaderToDelete = (Kierownik_Laboratorium)dgv_ListOfLeaders.CurrentRow.DataBoundItem;
            context.Kierownik_Laboratoriums.DeleteOnSubmit(leaderToDelete);
            context.SubmitChanges();
            showActualData();
        }
    }
}
