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
        public ctrlClaimViewer(DatabaseController DBController, int claimId)
        {
            InitializeComponent();

            //columns for query 
            string[] claimColumns = { "Claim_Amount", "Claim_Status", "Claim_Date", "Claim_Content", "Claim_ID" };

            //these set the args. 
            Dictionary<String, Object> args = new Dictionary<String, Object>();
            args.Add("Claim_ID", claimId);

            //call the query and get the details
            Dictionary<int, object[]> claimList = DBController.ClaimInformation(args, claimColumns);
            object[] claimDetails = claimList[0]; // because claimID is unique, we only need [0]

            lblAmount.Text = claimDetails[0].ToString();
            lblStatusType.Text = claimDetails[1].ToString();
            rtxtDetails.Text = claimDetails[3].ToString();

        }
    }
}
