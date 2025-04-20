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
        private int id;
        private string status;

        public ctrlClaimViewer(DatabaseController dbController, int claim_id, Session session)
        {
            InitializeComponent();
            DBController = dbController;
            role = session.UserAccount.Role;

            // Queries the database for input claim
            Claim claim = DBController.GetClaim(claim_id);
            status = claim.Status.ToString();
            lblStatusType.Text = status;
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

            lblAmount.Text = claim.Amount.ToString();
            
            rtxDetails.Text = claim.Content.ToString();
            id = claim_id;

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (role.Equals("claim_manager"))
            {
                if(DBController.UpdateClaim(id, "Status", "Financing")) 
                {
                    lblStatusType.Text = "Financing";
                    lblStatusType.ForeColor = Color.SeaGreen;
                }
                
            }
            else if (role.Equals("finance_manager"))
            {
                DBController.UpdateClaim(id, "Status", "Approved");
                lblStatusType.Text = "Approved";
                lblStatusType.ForeColor = Color.Green;
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            DBController.UpdateClaim(id, "Status", "Rejected");
            lblStatusType.Text = "Rejected";
            lblStatusType.ForeColor = Color.Red;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            int financerId = Convert.ToInt32(DBController.getFinanceManager().ID);
            DBController.UpdateClaim(id, "finance_manager_id", financerId.ToString());
        }
    }
}
