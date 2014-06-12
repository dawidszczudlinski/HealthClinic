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
    public partial class RegisterVisit : Form
    {
        private static string name;
        private static string pesel;
        private static string lastName;
        private IQueryable<Pacjent> listOfPatients;

        public RegisterVisit()
        {
            InitializeComponent();

        }

        private void btn_Visit_Click(object sender, EventArgs e)
        {
            try
            {
                Pacjent patient = (Pacjent)dgv_ListOfPatients.CurrentRow.DataBoundItem;

                if (patient != null)
                {
                    ManageVisit manageVisit = new ManageVisit();
                    manageVisit.setPatient(patient);
                    manageVisit.Show();
                }
                else
                {
                    MessageBox.Show("Wybierz Pacjenta");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystapił błąd przy wyborze pacjenta");
            }
            
        }

        private void RegisterVisit_Load(object sender, EventArgs e)
        {
            showActualData();
        }

        public void showActualData()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            listOfPatients = from Pacjent pac in context.Pacjents select pac;

            dgv_ListOfPatients.DataSource = listOfPatients;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {        
            DataClasses1DataContext context = new DataClasses1DataContext();
            int command = 0;
            lastName = txt_LastName.Text;
            name = txt_Name.Text;
            pesel = txt_Pesel.Text;
            if (!("".Equals(lastName)))
                command += 4;
            if (!("".Equals(name)))
                command += 2;
            if (!("".Equals(pesel)))
                command += 1;

            switch (command)
            {
                    // nothing
                case 0:
                    listOfPatients = from Pacjent pac in context.Pacjents select pac;
                    break;
                    // pesel
                case 1:
                    listOfPatients = from Pacjent pac in context.Pacjents where pesel == pac.PESEL select pac;
                    break;
                    // name
                case 2:
                    listOfPatients = from Pacjent pac in context.Pacjents where name == pac.Imie select pac;
                    break;
                    // name + pesel
                case 3:
                    listOfPatients = from Pacjent pac in context.Pacjents where name == pac.Imie && pesel == pac.PESEL select pac;
                    break;
                    // lastName
                case 4:
                    listOfPatients = from Pacjent pac in context.Pacjents where lastName == pac.Nazwisko select pac;
                    break;
                    // lastName + pesel
                case 5:
                    listOfPatients = from Pacjent pac in context.Pacjents where lastName == pac.Nazwisko && pesel == pac.PESEL select pac;
                    break;
                    // lastName + name
                case 6:
                    listOfPatients = from Pacjent pac in context.Pacjents where lastName == pac.Nazwisko && name == pac.Imie select pac;
                    break;
                    // lastName + name + pesel
                case 7:
                    listOfPatients = from Pacjent pac in context.Pacjents where lastName == pac.Nazwisko && name == pac.Imie && pesel == pac.PESEL select pac;
                    break;
                    // error
                default:
                    listOfPatients = null;
                    MessageBox.Show("Błąd");
                    break;
            }
            dgv_ListOfPatients.DataSource = listOfPatients;
        }

        private void Zakończ_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            ReceptionistAddPatient receptionistAddPatient = new ReceptionistAddPatient(this);
            receptionistAddPatient.Show();
        }

        private void btn_EditPatient_Click(object sender, EventArgs e)
        {
            Pacjent editablePatient = (Pacjent)dgv_ListOfPatients.CurrentRow.DataBoundItem;
            
            ReceptionistAddPatient receptionistAddPatient = new ReceptionistAddPatient(this, editablePatient);
            receptionistAddPatient.Show();
        }
    }
}
