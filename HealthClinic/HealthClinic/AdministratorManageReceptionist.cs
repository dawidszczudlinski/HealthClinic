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
    public partial class AdministratorManageReceptionist : Form
    {
        public AdministratorManageReceptionist()
        {
            InitializeComponent();
            showActualData();
        }

        public void showActualData()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var sourcess = from Rejestratorka rej in context.Rejestratorkas select rej;

            dgv_ListOfReceptionists.DataSource = sourcess;
        }

        private void btn_AddReceptionist_Click(object sender, EventArgs e)
        {
            AdministratorAddEditReceptionist administratorAddEditReceptionist = new AdministratorAddEditReceptionist(this);
            administratorAddEditReceptionist.Show();
        }

        private void btn_EditReceptionist_Click(object sender, EventArgs e)
        {
            Rejestratorka editableReceptionist = (Rejestratorka)dgv_ListOfReceptionists.CurrentRow.DataBoundItem;

            AdministratorAddEditReceptionist administratorAddEditReceptionist = new AdministratorAddEditReceptionist(this, editableReceptionist.ID_rej);
            administratorAddEditReceptionist.Show();
        }

        private void btn_DeleteReceptionist_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            Rejestratorka receptionistToDelete = (Rejestratorka)dgv_ListOfReceptionists.CurrentRow.DataBoundItem;
            context.Rejestratorkas.DeleteOnSubmit(receptionistToDelete);
            context.SubmitChanges();
            showActualData();
        }
    }
}
