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
    public partial class AdministratorAddEditLeaderLaboratory : Form
    {
        private AdministratorManageLeaderLaboratory parentWindow;

        private Boolean isEdit;
        private Kierownik_Laboratorium leaderToEdit, leaderToCreate;
        DataClasses1DataContext context = new DataClasses1DataContext();

        public AdministratorAddEditLeaderLaboratory(AdministratorManageLeaderLaboratory window)
        {
            InitializeComponent();
            parentWindow = window;
            isEdit = false;
        }

        public AdministratorAddEditLeaderLaboratory(AdministratorManageLeaderLaboratory window, int leaderID)
        {
            var sourcess = from Kierownik_Laboratorium klab in context.Kierownik_Laboratoriums where klab.ID_Klab == leaderID select klab;
            leaderToEdit = sourcess.First();

            InitializeComponent();
            parentWindow = window;
            isEdit = true;

            txt_Address.Text = leaderToEdit.Adres;
            txt_FirstName.Text = leaderToEdit.Imie;
            txt_LastName.Text = leaderToEdit.Nazwisko;
            txt_PESEL.Text = leaderToEdit.PESEL;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                leaderToEdit.Imie = txt_FirstName.Text;
                leaderToEdit.Nazwisko = txt_LastName.Text;
                leaderToEdit.PESEL = txt_PESEL.Text;
                leaderToEdit.Adres = txt_Address.Text;
            }
            else
            {
                leaderToCreate = new Kierownik_Laboratorium();
                leaderToCreate.Imie = txt_FirstName.Text;
                leaderToCreate.Nazwisko = txt_LastName.Text;
                leaderToCreate.PESEL = txt_PESEL.Text;
                leaderToCreate.Adres = txt_Address.Text;
                context.Kierownik_Laboratoriums.InsertOnSubmit(leaderToCreate);
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
