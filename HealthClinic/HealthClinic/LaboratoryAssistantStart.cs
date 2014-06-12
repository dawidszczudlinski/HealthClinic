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
    public partial class LaboratoryAssistantStart : Form
    {
        private static string text;
        DataClasses1DataContext context = new DataClasses1DataContext();
        private static string combo;
        private IQueryable<Badanie> listOfBadanies;
        public LaboratoryAssistantStart()
        {
            InitializeComponent();
        }

        private void btn_ShowExamination_Click(object sender, EventArgs e)
        {
            DoctorManageLaboratoryExamination doctorManageLaboratoryExamination = new DoctorManageLaboratoryExamination();
            doctorManageLaboratoryExamination.showLaboratoryAssistantWindow();
            doctorManageLaboratoryExamination.Show();
        }

        private void btn_ServicePatient_Click(object sender, EventArgs e)
        {
            Badanie visit = (Badanie)dgv_ListOfVisits.CurrentRow.DataBoundItem;
           
            if (visit != null)
            {
            DoctorManageLaboratoryExamination doctorManageLaboratoryExamination = new DoctorManageLaboratoryExamination(this);
           
            doctorManageLaboratoryExamination.setVisit(visit);
            doctorManageLaboratoryExamination.showLaboratoryAssistantWindow();
            doctorManageLaboratoryExamination.Show();
            }
            else
            {
                MessageBox.Show("Wybierz Badanie");
            }
        }

        private void LaboratoryAssistantStart_Load(object sender, EventArgs e)
        {
            showActualData();

        }
        public void showActualData()
        {

            var sourcess = from Badanie ba in context.Badanies select ba;
            dgv_ListOfVisits.DataSource = sourcess;
            context.SubmitChanges();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int command = 0;
            text = dateTimePicker2.Text;
            combo = cmb_State.Text;
            // MessageBox.Show(dateTimePicker2.Text);
            if (cmb_State != null)
                command += 2;
            if (!("".Equals(text)))
                command += 1;

            switch (command)
            {
                case 1:
                    listOfBadanies = from Badanie ba in context.Badanies where Convert.ToDateTime(text) == ba.Dt_zle select ba;
                    break;
                case 3:
                    listOfBadanies = from Badanie ba in context.Badanies where combo == ba.Status && Convert.ToDateTime(text) == ba.Dt_zle select ba;
                    break;
                // name
            }
            dgv_ListOfVisits.DataSource = listOfBadanies;
        }
    }
}
