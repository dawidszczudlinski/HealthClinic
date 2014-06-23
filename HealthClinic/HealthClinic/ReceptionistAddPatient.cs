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
    public partial class ReceptionistAddPatient : Form
    {
        private RegisterVisit parentWindow;
        private Pacjent patientToCreate, patientToEdit;
        private bool isEdit;
        DataClasses2DataContext context = new DataClasses2DataContext();
        public ReceptionistAddPatient(RegisterVisit window)
        {
            InitializeComponent();
            parentWindow = window;
            patientToCreate = null;
            isEdit = false;
        }

        public ReceptionistAddPatient(RegisterVisit window, Pacjent patient)
        {
            InitializeComponent();
            parentWindow = window;
            patientToCreate = null;
            isEdit = true;

            var sourcess = from Pacjent pac in context.Pacjents where 
                               pac.ID_pac == patient.ID_pac select pac;
         
            
            patientToEdit = sourcess.First();
            txt_Name.Text = patientToEdit.Imie;
            txt_LastName.Text = patientToEdit.Nazwisko;
            txt_Pesel.Text = patientToEdit.PESEL;
            txt_AssuranceNumber.Text = patientToEdit.Nr_ubezpieczenia;
            txt_Addres.Text = patientToEdit.Adres;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                patientToEdit.Imie = txt_Name.Text;
                patientToEdit.Nazwisko = txt_LastName.Text;
                patientToEdit.PESEL = txt_Pesel.Text;
                patientToEdit.Nr_ubezpieczenia = txt_AssuranceNumber.Text;
                patientToEdit.Adres = txt_Addres.Text;
            }
            else
            {
                patientToCreate = new Pacjent();
                patientToCreate.Imie = txt_Name.Text;
                patientToCreate.Nazwisko = txt_LastName.Text;
                patientToCreate.PESEL = txt_Pesel.Text;
                patientToCreate.Nr_ubezpieczenia = txt_AssuranceNumber.Text;
                patientToCreate.Adres = txt_Addres.Text;
                context.Pacjents.InsertOnSubmit(patientToCreate);
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
