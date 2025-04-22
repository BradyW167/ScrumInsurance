using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cmp;

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlClaimsList : ScrumUserControl
    {
        private int ClaimCount {  get; set; }

        public ctrlClaimsList(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();

            ClaimCount = 0;

            //these are the columns we want to grab for the select query
            string[] columns = { "Claim_Title", "Claim_Date", "Claim_Status", "Claim_ID" };

            //these set the args. 
            
            Dictionary<String, Object> args = new Dictionary<String, Object>();
            if (Session.UserAccount.Role.Equals("claim_manager"))
            {
                args.Add("Claim_Status", "Validating");
            }
            else if (Session.UserAccount.Role.Equals("finance_manager"))
            {
                args.Add("Claim_Status", "Financing");
            }


            List<Claim> claimList = DBController.GetClaimList(Session.UserAccount);

            foreach (Claim claim in claimList)
            {
                addClaim(claim);
            }

        }

        // Adds a claim object to the claim panel with a label and a button
        private void addClaim(Claim claim)
        {
            // Increment claim counter
            ClaimCount += 1;

            // Create new button for this claim
            Button btn = new Button();

            // Style button
            btn.BackColor = Color.Azure;
            btn.Text = "View";
            btn.FlatAppearance.BorderColor = Color.Azure;
            btn.FlatStyle = FlatStyle.Popup;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Width = 80;
            btn.Height = 50;

            // Calculate button location based on number of claims loaded
            btn.Location = new Point(340, (ClaimCount * 120) - 50);
            
            // Store claim id in this claim's button tag
            btn.Tag = claim.ID;

            // Add a click event handler to the button
            btn.Click += new System.EventHandler(this.btnMessageA_Click);

            // Add the button to the claim panel
            pnlList.Controls.Add(btn);

            // Create new lable for this claim
            Label msg = new Label();

            // Style the label
            msg.BackColor = Color.Azure;
            msg.TextAlign = ContentAlignment.MiddleLeft;
            msg.Font = new Font("Microsoft Tai Le", 11, FontStyle.Regular);
            msg.Text = $"Title: {claim.Title} \nStatus: {claim.Status.ToString()} \nDate: {claim.Date.ToString()}";
            msg.Width = 420;
            msg.Height = 100;

            // Calculate label location based on number of claims loaded
            msg.Location = new Point(10, (ClaimCount * 120) - 80);

            // Add the label to the claim panel
            pnlList.Controls.Add(msg);
        }

        // Process clicks on claims
        private void btnMessageA_Click(object sender, EventArgs e)
        {
            // Store the sender object as a button
            Button btn = sender as Button;

            // Store the claim id as a long from the button's tag property
            long claim_id = long.Parse(btn.Tag.ToString());

            // Load the selected claim's info into the claim viewer control and swap to it
            SwapCtrlMain(new ctrlClaimViewer(this, claim_id));
        }
    }
}
