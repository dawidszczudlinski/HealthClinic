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
    public partial class ManageVisit : Form
    {
        public ManageVisit()
        {
            InitializeComponent();
        }

        private void btn_ChooseDoctor_Click(object sender, EventArgs e)
        {
            SelectionOfDoctor selectionOfDoctor = new SelectionOfDoctor();
            selectionOfDoctor.Show();
        }
    }
}
