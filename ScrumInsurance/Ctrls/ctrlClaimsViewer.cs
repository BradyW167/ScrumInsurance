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

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlClaimViewer : ScrumUserControl
    {
        Claim Claim { get; set; }

        public ctrlClaimViewer(ScrumUserControl oldCtrl, long claim_id) : base(oldCtrl)
        {
            InitializeComponent();
            string role = Session.UserAccount.Role;

            // Stores queried claim matching input claim_id in class property
            Claim = DBController.GetClaim(claim_id);

            // Stores status of the input claim
            string status = Claim.Status.ToString();

            // Set the status label text
            lblStatusType.Text = status;

            // Set the label's color based on the status
            if (status == "Pending")
            {
                lblStatusType.ForeColor = Color.Olive;
            }
            else if (status == "Financing")
            {
                lblStatusType.ForeColor = Color.SeaGreen;
            }
            else if (status == "Approved")
            {
                lblStatusType.ForeColor = Color.Green;
            }
            else if (status == "Rejected")
            {
                lblStatusType.ForeColor = Color.Red;
            }

            // Set the claim amount label
            lblAmount.Text = Claim.Amount.ToString();
            
            // Set the claim content text
            rtxDetails.Text = Claim.Content.ToString();

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (Session.UserAccount.Role.Equals("claim_manager"))
            {
                if(DBController.UpdateClaim(Claim.ID, "Status", "Financing") == true) 
                {
                    lblStatusType.Text = "Financing";
                    lblStatusType.ForeColor = Color.SeaGreen;
                }
                
            }
            else if (Session.UserAccount.Role.Equals("finance_manager"))
            {
                DBController.UpdateClaim(Claim.ID, "Status", "Approved");
                lblStatusType.Text = "Approved";
                lblStatusType.ForeColor = Color.Green;
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            DBController.UpdateClaim(Claim.ID, "Status", "Rejected");
            lblStatusType.Text = "Rejected";
            lblStatusType.ForeColor = Color.Red;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            // Gets the ID of the finance manager with the least claims assigned
            long financer_id = DBController.GetLeastClaimsManagerID(false);
            
            DBController.UpdateClaim(Claim.ID, "finance_manager_id", financer_id);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlClaimsList(this));
        }
    }
}
