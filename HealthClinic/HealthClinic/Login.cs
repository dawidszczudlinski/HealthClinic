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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            String login = txt_Login.Text;
            String password = txt_Password.Text;
            var sourcess = from Konto kon in context.Kontos where kon.Login == login select kon;
            try
            {
                Konto currentAccount = sourcess.First();
                if (currentAccount.Haslo == password && currentAccount.Dt_wygas > DateTime.Today)
                {
                    CurrentAccount.setAccount(currentAccount);
                    switch (currentAccount.rola)
                    {
                        case "adm":
                            //MessageBox.Show("Admin.");
                            AdministratorStart administratorStart = new AdministratorStart();
                            this.Hide();
                            administratorStart.ShowDialog();
                            this.Close();
                            break;
                        case "rej":
                            //MessageBox.Show("Rejestrator.");
                            ReceptionistStart receptionistStart = new ReceptionistStart();
                            this.Hide();
                            receptionistStart.ShowDialog();
                            this.Close();
                            break;
                        case "dok":
                            //MessageBox.Show("Doktor.");
                            DoctorStart doctorStart = new DoctorStart();
                            this.Hide();
                            doctorStart.ShowDialog();
                            this.Close();
                            break;
                        case "lab":
                            //MessageBox.Show("Laborant.");
                            LaboratoryAssistantStart laboratoryAssistantStart = new LaboratoryAssistantStart();
                            this.Hide();
                            laboratoryAssistantStart.ShowDialog();
                            this.Close();
                            break;
                        case "klab":
                            //MessageBox.Show("Kierownik laboratorium.");
                            LeaderLaboratoryStart leaderLaboratoryStart = new LeaderLaboratoryStart();
                            this.Hide();
                            leaderLaboratoryStart.ShowDialog();
                            this.Close();
                            break;
                        default:
                            MessageBox.Show("Niezidentyfikowana rola.","Złe dane");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Błąd logowania.", "Złe dane");
                }
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show("Nie znaleziono użytkownika o podanym loginie.", "Złe dane");
            }
            catch (Exception exc2)
            {
                MessageBox.Show("Logowanie nie udane", "Złe dane");
            } 
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
