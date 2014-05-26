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
        private Pacjent patient = null;
        public ManageVisit()
        {
            InitializeComponent();
        }

        public void chooseDoctor(Lekarz doctor)
        {
            txt_Doctor.Text = doctor.Imie + " " + doctor.Nazwisko;
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
            DateTime date = calendar.SelectionStart;
            selectionOfDoctor.setDate(date);
            selectionOfDoctor.Show();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }

    }
}
