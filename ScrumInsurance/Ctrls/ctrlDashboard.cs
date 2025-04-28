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

            // Set the username label
            lblUser.Text = Session.UserAccount.Username;

            if (Session.UserAccount.Role == "admin")
            {
                btnClaims.Visible = false;
            }
            else
            {
                btnClaims.Visible = true;
            }

            // Anchor this to the top of the screen
            this.Anchor = AnchorStyles.None;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            PnlMain.BackColor = ColorTranslator.FromHtml("#131042");

            // Clear user session
            Session.UserAccount = null;

            RemoveCtrlFooter();
            RemoveCtrlDash();
            SwapCtrlMain(new ctrlLogin(this));
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
            else if (Session.UserAccount.Role == "finance_manager")
            {
                SwapCtrlMain(new ctrlLandingFManager(this));
            }
            else if (Session.UserAccount.Role == "admin")
            {
                SwapCtrlMain(new ctrlLandingAdmin(this));
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlEditProfile(this));
        }

        private void btnClaims_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlClaimsList(this));
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlInbox(this));
        }
    }
}
