using System;
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
            lblUser.Text = Session.UserAccount.Username;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlLogin());
            removeDash();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLanding_Click(object sender, EventArgs e)
        {
            if (Session.UserAccount.Role == "client")
            {
                SwapCtrlMain(new ctrlLandingClient());
            }
            else if (Session.UserAccount.Role == "claim_manager")
            {
                SwapCtrlMain(new ctrlLandingCManager());
            }
            else if (Session.UserAccount.Role == "admin")
            {
                SwapCtrlMain(new ctrlLandingCManager());
            }

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlEditProfile());
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlInbox());
        }
    }
}
