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
    public partial class AdministratorAddEditReceptionist : Form
    {
        private AdministratorManageReceptionist parentWindow;

        private Boolean isEdit;
        private Rejestratorka receptionistToEdit, receptionistToCreate;
        DataClasses1DataContext context = new DataClasses1DataContext();

        public AdministratorAddEditReceptionist(AdministratorManageReceptionist window)
        {
            InitializeComponent();
            parentWindow = window;
            isEdit = false;
        }

        public AdministratorAddEditReceptionist(AdministratorManageReceptionist window,
                                                int receptionistID)
        {
            var sourcess = from Rejestratorka rej in context.Rejestratorkas where rej.ID_rej == receptionistID select rej;
            receptionistToEdit = sourcess.First();

            InitializeComponent();
            parentWindow = window;
            isEdit = true;

            txt_FirstName.Text = receptionistToEdit.Imie;
            txt_LastName.Text = receptionistToEdit.Nazwisko;
            txt_PESEL.Text = receptionistToEdit.PESEL;
            txt_Address.Text = receptionistToEdit.Adres;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                receptionistToEdit.Imie = txt_FirstName.Text;
                receptionistToEdit.Nazwisko = txt_LastName.Text;
                receptionistToEdit.PESEL = txt_PESEL.Text;
                receptionistToEdit.Adres = txt_Address.Text;
            }
            else
            {
                receptionistToCreate = new Rejestratorka();
                receptionistToCreate.Imie = txt_FirstName.Text;
                receptionistToCreate.Nazwisko = txt_LastName.Text;
                receptionistToCreate.PESEL = txt_PESEL.Text;
                receptionistToCreate.Adres = txt_Address.Text;
                context.Rejestratorkas.InsertOnSubmit(receptionistToCreate);
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
