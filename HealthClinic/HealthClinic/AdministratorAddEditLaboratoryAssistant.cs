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
    public partial class AdministratorAddEditLaboratoryAssistant : Form
    {
        private AdministratorManageLaboratoryAssistant parentWindow;

        private Boolean isEdit;
        private Laborant laborantToEdit, laborantToCreate;
        DataClasses2DataContext context = new DataClasses2DataContext();
        
        public AdministratorAddEditLaboratoryAssistant(AdministratorManageLaboratoryAssistant window)
        {
            InitializeComponent();
            parentWindow = window;
            isEdit = false;
        }

        public AdministratorAddEditLaboratoryAssistant(AdministratorManageLaboratoryAssistant window , int laborantID)
        {
            var sourcess = from Laborant lab in context.Laborants where lab.ID_lab == laborantID select lab;
            laborantToEdit = sourcess.First();

            InitializeComponent();
            parentWindow = window;
            isEdit = true;

            txt_Address.Text = laborantToEdit.Adres;
            txt_FirstName.Text = laborantToEdit.Imie;
            txt_LastName.Text = laborantToEdit.Nazwisko;
            txt_PESEL.Text = laborantToEdit.PESEL;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                laborantToEdit.Imie = txt_FirstName.Text;
                laborantToEdit.Nazwisko = txt_LastName.Text;
                laborantToEdit.PESEL = txt_PESEL.Text;
                laborantToEdit.Adres = txt_Address.Text;
            }
            else
            {
                laborantToCreate = new Laborant();
                laborantToCreate.Imie = txt_FirstName.Text;
                laborantToCreate.Nazwisko = txt_LastName.Text;
                laborantToCreate.PESEL = txt_PESEL.Text;
                laborantToCreate.Adres = txt_Address.Text;
                context.Laborants.InsertOnSubmit(laborantToCreate);
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
