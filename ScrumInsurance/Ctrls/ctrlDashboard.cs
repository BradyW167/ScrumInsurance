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
    public partial class ctrlDashboard : ScrumUserControl
    {
        public ctrlDashboard()
        {
            InitializeComponent();
        }

        private void ctrlDashboard_Load(object sender, EventArgs e)
        {
            lblUser.Text = Session.Username;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            swapCtrlMain(new ctrlLogin());
            removeDash();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLanding_Click(object sender, EventArgs e)
        {
            if (Session.Role == "client")
            {
                swapCtrlMain(new ctrlLandingClient());
            }
            else if (Session.Role == "claim-manager")
            {
                swapCtrlMain(new ctrlLandingCManager());
            }
            else if (Session.Role == "admin")
            {
                swapCtrlMain(new ctrlLandingCManager());
            }

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            swapCtrlMain(new ctrlEditProfile(Session));
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            swapCtrlMain(new ctrlInbox());
        }
    }
}
