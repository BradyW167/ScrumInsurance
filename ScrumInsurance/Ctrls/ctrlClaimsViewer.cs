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
        private DatabaseController DBController_;
        private object[] claimDetails;
        private string role;

        public ctrlClaimViewer(DatabaseController DBController, int claimId, Session session)
        {
            InitializeComponent();
            DBController_ = DBController;
            role = session.UserAccount.Role;

            //columns for query 
            string[] claimColumns = { "Claim_Amount", "Claim_Status", "Claim_Date", "Claim_Content", "Claim_ID" };

            //these set the args. 
            Dictionary<String, Object> args = new Dictionary<String, Object>();
            args.Add("Claim_ID", claimId);

            //call the query and get the details
            Dictionary<int, object[]> claimList = DBController.ClaimInformation(args, claimColumns);
            claimDetails = claimList[0]; // because claimID is unique, we only need [0]

            lblAmount.Text = claimDetails[0].ToString();
            lblStatusType.Text = claimDetails[1].ToString();
            rtxtDetails.Text = claimDetails[3].ToString();

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (role.Equals("claim_manager"))
            {
                DBController_.UpdateClaim(claimDetails[4], "Financing");
            }
            else if (role.Equals("finance_manager"))
            {
                DBController_.UpdateClaim(claimDetails[4], "Approved");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            DBController_.UpdateClaim(claimDetails[4], "Rejected");
        }
    }
}
