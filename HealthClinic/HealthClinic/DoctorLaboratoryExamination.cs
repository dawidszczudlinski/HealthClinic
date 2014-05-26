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
    public partial class DoctorLaboratoryExamination : Form
    {
        public DoctorLaboratoryExamination()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            DoctorManageLaboratoryExamination doctorManageLaboratoryExamination = new DoctorManageLaboratoryExamination();
            doctorManageLaboratoryExamination.showDoctorWindow();
            doctorManageLaboratoryExamination.Show();
        }
    }
}