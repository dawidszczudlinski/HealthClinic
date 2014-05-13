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
    public partial class AdministratorAddEditExamination : Form
    {
        private AdministratorManageExamination parentWindow;

        private Boolean isEdit;
        private Slownik_badan examinationToEdit, examinationToCreate;

        DataClasses1DataContext context = new DataClasses1DataContext();

        public AdministratorAddEditExamination(AdministratorManageExamination window)
        {
            InitializeComponent();
            parentWindow = window;
            isEdit = false;
        }

        public AdministratorAddEditExamination(AdministratorManageExamination window,
                                                int examinationCode)
        {
            var sourcess = from Slownik_badan exam in context.Slownik_badans where exam.Kod == examinationCode select exam;
            examinationToEdit = sourcess.First();
            
            InitializeComponent();
            parentWindow = window;
            isEdit = true;

            txt_ExaminationName.Text = examinationToEdit.Nazwa;
            txt_ExaminationDescription.Text = examinationToEdit.Opis;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                examinationToEdit.Nazwa = txt_ExaminationName.Text;
                examinationToEdit.Opis = txt_ExaminationDescription.Text;
            }
            else
            {
                examinationToCreate = new Slownik_badan();
                examinationToCreate.Nazwa = txt_ExaminationName.Text;
                examinationToCreate.Opis = txt_ExaminationDescription.Text;
                context.Slownik_badans.InsertOnSubmit(examinationToCreate);
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
