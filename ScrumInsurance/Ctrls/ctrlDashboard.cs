using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlDashboard : ScrumUserControl
    {
        public ctrlDashboard(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();
        }

        private void ctrlDashboard_Load(object sender, EventArgs e)
        {
            lblUser.Text = Session.UserAccount.Username;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlLogin(this));
            RemoveCtrlFooter();
            RemoveCtrlDash();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLanding_Click(object sender, EventArgs e)
        {
            if (Session.UserAccount.Role == "client")
            {
                SwapCtrlMain(new ctrlLandingClient(this));
            }
            else if (Session.UserAccount.Role == "claim_manager")
            {
                SwapCtrlMain(new ctrlLandingCManager(this));
            }
            else if (Session.UserAccount.Role == "admin")
            {
                SwapCtrlMain(new ctrlLandingCManager(this));
            }

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlEditProfile(this));
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlInbox(this));
        }
    }
}
