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
    public partial class AdministratorAddEditDoctor : Form
    {
        private AdministratorManageDoctors parentWindow;

        private Boolean isEdit;
        private Lekarz doctorToEdit, doctorToCreate;
        DataClasses2DataContext context = new DataClasses2DataContext();

        public AdministratorAddEditDoctor(AdministratorManageDoctors window)
        {
            InitializeComponent();
            parentWindow = window;
            isEdit = false;
        }

        public AdministratorAddEditDoctor(AdministratorManageDoctors window, int doctorID)
        {
            var sourcess = from Lekarz lek in context.Lekarzs where lek.ID_lek == doctorID select lek;
            doctorToEdit = sourcess.First();

            InitializeComponent();
            parentWindow = window;
            isEdit = true;

            txt_FirstName.Text = doctorToEdit.Imie;
            txt_LastName.Text = doctorToEdit.Nazwisko;
            txt_PESEL.Text = doctorToEdit.PESEL;
            txt_Address.Text = doctorToEdit.Adres;
            txt_Npwz.Text = doctorToEdit.npwz;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                doctorToEdit.Imie = txt_FirstName.Text;
                doctorToEdit.npwz = txt_Npwz.Text;
                doctorToEdit.Nazwisko = txt_LastName.Text;
                doctorToEdit.PESEL = txt_PESEL.Text;
                doctorToEdit.Adres = txt_Address.Text;
            }
            else
            {
                doctorToCreate = new Lekarz();
                doctorToCreate.Imie = txt_FirstName.Text;
                doctorToCreate.npwz = txt_Npwz.Text;
                doctorToCreate.Nazwisko = txt_LastName.Text;
                doctorToCreate.PESEL = txt_PESEL.Text;
                doctorToCreate.Adres = txt_Address.Text;
                context.Lekarzs.InsertOnSubmit(doctorToCreate);
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
