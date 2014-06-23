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
    public partial class ManageVisit : Form
    {
        private Wizyta wizyt;
        private Pacjent patient = null;
        private Lekarz doctor = null;
        DataClasses2DataContext context = new DataClasses2DataContext();

        public ManageVisit()
        {
            InitializeComponent();
            dtp_Data.Value = DateTime.Today;
        }
        
        public void chooseDoctor(Lekarz doctor)
        {
            txt_Doctor.Text = doctor.Imie + " " + doctor.Nazwisko;
            this.doctor = doctor;
            
        }

        public void setPatient(Pacjent patient)
        {
            txt_Name.Text = patient.Imie;
            txt_LastName.Text = patient.Nazwisko;
            txt_Pesel.Text = patient.PESEL;
            this.patient = patient;
        }

        private void btn_ChooseDoctor_Click(object sender, EventArgs e)
        {
            SelectionOfDoctor selectionOfDoctor = new SelectionOfDoctor(this);
            DateTime date = dtp_Data.Value.Date;
            selectionOfDoctor.setDate(date);
            selectionOfDoctor.Show();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            wizyt = new Wizyta();
            wizyt.Dt_rej = dtp_Data.Value.Date;
            wizyt.Status = "rej";
            
            wizyt.Dt_zak = null;
            wizyt.Opis = "";
            wizyt.Diagnoza = "";
            wizyt.ID_pac = patient.ID_pac;
            wizyt.ID_rej = CurrentAccount.getAccount().ID;
            wizyt.ID_lek = doctor.ID_lek;
            try
            {
                context.Wizytas.InsertOnSubmit(wizyt);
                context.SubmitChanges();
            }
            catch (Exception exc)
            {
                MessageBox.Show("blad: " + exc.Message);
            }          
            this.Close();  
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

    }
}
