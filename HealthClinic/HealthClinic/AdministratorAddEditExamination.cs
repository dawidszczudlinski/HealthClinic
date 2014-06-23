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

        DataClasses2DataContext context = new DataClasses2DataContext();

        public AdministratorAddEditExamination(AdministratorManageExamination window)
        {
            InitializeComponent();
            parentWindow = window;
            isEdit = false;
            cmb_ExaminationType.SelectedIndex = 0;
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
            if (examinationToEdit.Typ == 1)
            {
                cmb_ExaminationType.SelectedItem = "Fizykalne";
            }
            else
            {
                cmb_ExaminationType.SelectedItem = "Laboratoryjne";
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                examinationToEdit.Nazwa = txt_ExaminationName.Text;
                examinationToEdit.Opis = txt_ExaminationDescription.Text;
                if (cmb_ExaminationType.SelectedItem == "Fizykalne")
                    examinationToEdit.Typ = 1;
                else
                    examinationToEdit.Typ = 2;
            }
            else
            {
                examinationToCreate = new Slownik_badan();
                examinationToCreate.Nazwa = txt_ExaminationName.Text;
                examinationToCreate.Opis = txt_ExaminationDescription.Text;
                if (cmb_ExaminationType.SelectedItem == "Fizykalne")
                    examinationToCreate.Typ = 1;
                else
                    examinationToCreate.Typ = 2;
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
