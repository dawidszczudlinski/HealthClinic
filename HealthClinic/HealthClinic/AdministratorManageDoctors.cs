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
    public partial class AdministratorManageDoctors : Form
    {
        public AdministratorManageDoctors()
        {
            InitializeComponent();
            showActualData();
        }

        public void showActualData()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var sourcess = from Lekarz lek in context.Lekarzs select lek;

            dgv_ListOfDoctors.DataSource = sourcess;
        }

        private void btn_AddDoctor_Click(object sender, EventArgs e)
        {
            AdministratorAddEditDoctor administratorAddEditDoctor = new AdministratorAddEditDoctor(this);
            administratorAddEditDoctor.Show();
        }

        private void btn_EditDoctor_Click(object sender, EventArgs e)
        {
            Lekarz editableDoctor = (Lekarz)dgv_ListOfDoctors.CurrentRow.DataBoundItem;

            AdministratorAddEditDoctor administratorAddEditDoctor = new AdministratorAddEditDoctor(this, editableDoctor.ID_lek);
            administratorAddEditDoctor.Show();
        }

        private void btn_DeleteDoctor_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            Lekarz doctorToDelete = (Lekarz)dgv_ListOfDoctors.CurrentRow.DataBoundItem;
            context.Lekarzs.DeleteOnSubmit(doctorToDelete);
            context.SubmitChanges();
            showActualData();
        }
    }
}
