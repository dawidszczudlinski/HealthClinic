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
    public partial class AdministratorAddEditAccount : Form
    {
        private AdministratorManageAccounts parentWindow;

        private Boolean isEdit;
        private Konto accountToEdit, accountToCreate;

        DataClasses1DataContext context = new DataClasses1DataContext();

        public AdministratorAddEditAccount(AdministratorManageAccounts window)
        {

              
        //      kon = 
         //   MessageBox.Show(xxx.ToString());
            


            InitializeComponent();
            parentWindow = window;
            isEdit = false;
        }

        public AdministratorAddEditAccount(AdministratorManageAccounts window,
            String login)
        {
            var sourcess = from Konto kon in context.Kontos where kon.Login == login select kon;
            accountToEdit = sourcess.First();
            
            InitializeComponent();
            parentWindow = window;
            isEdit = true;


            txt_Login.Text = accountToEdit.Login;
            txt_Password.Text = accountToEdit.Haslo;
            txt_ID.Text = accountToEdit.ID.ToString();
            txt_Role.Text = accountToEdit.rola;
            mc_Date.SetDate(accountToEdit.Dt_wygas);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            
            if (isEdit)
            {
                accountToEdit.Login = txt_Login.Text;
                accountToEdit.Haslo = txt_Password.Text;
                accountToEdit.ID = Int32.Parse(txt_ID.Text);
                accountToEdit.rola = txt_Role.Text;
                accountToEdit.Dt_wygas = mc_Date.SelectionRange.Start;
            }
            else
            {

               
                accountToCreate = new Konto();
                accountToCreate.Login = txt_Login.Text;
                accountToCreate.Haslo = txt_Password.Text;
                accountToCreate.ID = Int32.Parse(txt_ID.Text);
                accountToCreate.rola = txt_Role.Text;
                accountToCreate.Dt_wygas = mc_Date.SelectionRange.Start;
                context.Kontos.InsertOnSubmit(accountToCreate);
            }
            context.SubmitChanges();
            parentWindow.showActualData();
            this.Close();    
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
