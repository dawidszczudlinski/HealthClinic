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
    public partial class AdministratorManageAccounts : Form
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        public AdministratorManageAccounts()
        {
            InitializeComponent();
        }


        private void AdministratorManageAccounts_Load(object sender, EventArgs e)
        {
            showActualData();
        }

        public void showActualData()
        {
           
            var sourcess = from Konto kon in context.Kontos select kon;

            dgv_ListOfAccounts.DataSource = sourcess;
        }

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            AdministratorAddEditAccount administratorAddEditAccount = new AdministratorAddEditAccount(this);
            administratorAddEditAccount.Show();
        }

        private void btn_EditAccount_Click(object sender, EventArgs e)
        {
            Konto editableAccount = (Konto)dgv_ListOfAccounts.CurrentRow.DataBoundItem;
            
            AdministratorAddEditAccount administratorAddEditAccount = new AdministratorAddEditAccount(this,editableAccount.Login);
            administratorAddEditAccount.Show();
        }

        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            Konto accountToDelete = (Konto)dgv_ListOfAccounts.CurrentRow.DataBoundItem;
            accountToDelete.Dt_wygas = DateTime.Today;
            context.SubmitChanges();
            showActualData();
        }
    }
}
