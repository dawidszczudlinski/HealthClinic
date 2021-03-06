﻿using System;
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
            DataClasses2DataContext context = new DataClasses2DataContext();

            listOfPatients = from Pacjent pac in context.Pacjents select pac;

            dgv_ListOfPatients.DataSource = listOfPatients;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {        
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Pacjent pac in context.Pacjents select pac;

            if (txt_LastName.TextLength != 0)
                sourcess = sourcess.Where(p => p.Nazwisko.Contains(txt_LastName.Text));
            if (txt_Name.TextLength != 0)
                sourcess = sourcess.Where(p => p.Imie.Contains(txt_Name.Text));
            if (txt_Pesel.TextLength != 0)
                sourcess = sourcess.Where(p => p.PESEL.Contains(txt_Pesel.Text));
            dgv_ListOfPatients.DataSource = sourcess;
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

        private void RegisterVisit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, "rej1.htm");
                //MessageBox.Show("Aby wyszukać pacjenta w bazie danych wpisz jego nazwisko, imię, PESEL. Dane nie muszą być pełne.\n\n" +
                //    "Na liście pojawiają się wszyscy pacjenci spełniający warunki filtru. Jeśli pola 'Nazwisko', 'Imię', 'PESEL' są puste, pokazani są wszyscy pacjenci.\n\n" +
                //    "Pacjenta może usunąć z bazy tylko administrator.\n\n" +
                //    "Aby dodać nowego pacjenta naciśnij 'Dodaj pacjenta'.\n" +
                //    "Aby zmienić dane pacjenta naciśnij 'Edytuj pacjenta'.\n" +
                //    "Aby zapisać pacjenta na wizytę naciśnij 'Wizyta'.\n" +
                //    "Aby zakończyć rejestrację naciśnij 'Zakończ' lub X w prawym górnym rogu.\n",
                //    "Pomoc - Okno wyboru pacjenta");
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
