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
    public partial class AdministratorManageExamination : Form
    {
        public AdministratorManageExamination()
        {
            InitializeComponent();
            showActualData();
        }

        public void showActualData()
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            var sourcess = from Slownik_badan kon in context.Slownik_badans select kon;

            dgv_ListOfExaminations.DataSource = sourcess;
        }

        private void btn_AddExamination_Click(object sender, EventArgs e)
        {
            AdministratorAddEditExamination manageExamination = new AdministratorAddEditExamination(this);
            manageExamination.Show();
        }

        private void btn_EditExamination_Click(object sender, EventArgs e)
        {
            Slownik_badan examination = (Slownik_badan)dgv_ListOfExaminations.CurrentRow.DataBoundItem;

            AdministratorAddEditExamination manageExamination = new AdministratorAddEditExamination(this,examination.Kod);
            manageExamination.Show();
        }

        private void btn_DeleteExamination_Click(object sender, EventArgs e)
        {
            DataClasses2DataContext context = new DataClasses2DataContext();

            Slownik_badan examinationToDelete = (Slownik_badan)dgv_ListOfExaminations.CurrentRow.DataBoundItem;
            context.Slownik_badans.DeleteOnSubmit(examinationToDelete);
            context.SubmitChanges();
            showActualData();
        }
    }
}
