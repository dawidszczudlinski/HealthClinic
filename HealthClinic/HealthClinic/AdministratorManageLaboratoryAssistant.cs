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
    public partial class AdministratorManageLaboratoryAssistant : Form
    {
        public AdministratorManageLaboratoryAssistant()
        {
            InitializeComponent();
            showActualData();
        }

        public void showActualData()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var sourcess = from Laborant lab in context.Laborants select lab;

            dgv_ListOfLaborants.DataSource = sourcess;
        }

        private void btn_AddLaborant_Click(object sender, EventArgs e)
        {
            AdministratorAddEditLaboratoryAssistant administratorAddEditLaboratoryAssistant = new AdministratorAddEditLaboratoryAssistant(this);
            administratorAddEditLaboratoryAssistant.Show();
        }

        private void btn_EditLaborant_Click(object sender, EventArgs e)
        {
            Laborant editableLaborant = (Laborant)dgv_ListOfLaborants.CurrentRow.DataBoundItem;

            AdministratorAddEditLaboratoryAssistant administratorAddEditLaboratoryAssistant = new AdministratorAddEditLaboratoryAssistant(this, editableLaborant.ID_lab);
            administratorAddEditLaboratoryAssistant.Show();
        }

        private void btn_DeleteLaborant_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            Laborant laborantToDelete = (Laborant)dgv_ListOfLaborants.CurrentRow.DataBoundItem;
            context.Laborants.DeleteOnSubmit(laborantToDelete);
            context.SubmitChanges();
            showActualData();
        }
    }
}
