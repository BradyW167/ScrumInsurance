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
    public partial class ctrlLandingFManager : ScrumUserControl
    {
        public ctrlLandingFManager(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();

            lblWelcome.Text = $"Welcome, Financial Manager {Session.UserAccount.Username}";

            lblClaimID.Text = "";
            lblClaimDate.Text = "";
            lblClaimStatus.Text = "";

            lblNumClaims.Text = "";
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlLogin(this));
        }

        private void btnClaimsList_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlClaimsList(this));
        }

        private void btnViewClaim_Click(object sender, EventArgs e)
        {

        }

        private void btnMessageClient_Click(object sender, EventArgs e)
        {

        }

        private void btnMessageCM_Click(object sender, EventArgs e)
        {

        }
    }
}
