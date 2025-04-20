using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet.Messages;

namespace ScrumInsurance
{
    public partial class ctrlClaimViewer : ScrumUserControl
    {
        private object[] claimDetails;
        private string role;

        public ctrlClaimViewer(DatabaseController dbController, int claim_id, Session session)
        {
            InitializeComponent();
            DBController = dbController;
            role = session.UserAccount.Role;

            // Queries the database for input claim
            Claim claim = DBController.GetClaim(claim_id);

            lblAmount.Text = claim.Amount.ToString();
            lblStatusType.Text = claim.Status.ToString();
            rtxDetails.Text = claim.Content.ToString();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (role.Equals("claim_manager"))
            {
                DBController.UpdateClaim(claimDetails[4], "Financing");
            }
            else if (role.Equals("finance_manager"))
            {
                DBController.UpdateClaim(claimDetails[4], "Approved");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            DBController.UpdateClaim(claimDetails[4], "Rejected");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }
    }
}
