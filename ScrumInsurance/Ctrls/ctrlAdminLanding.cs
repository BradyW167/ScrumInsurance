﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance
{
    public partial class ctrlAdminLanding : ScrumUserControl
    {
        // private string[] args_ = null;

        public ctrlAdminLanding()
        {
            InitializeComponent();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmitUser_Click(object sender, EventArgs e)
        {
            string[] row = Session.DBController.validateLogin("test", "admin12345");
            dgUserinfo.Rows.Add(row);
        }
    }
}
