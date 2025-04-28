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
        private List<Message> RecentMessages { get; set; }

        private Claim RecentClaim { get; set; }

        public ctrlLandingFManager(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();

            lblWelcome.Text = $"Welcome, Finance Manager {Session.UserAccount.Username}";

            DisplayRecentClaim();

            DisplayNumberOfClaims();

            DisplayRecentMessages();
        }

        private void DisplayRecentClaim()
        {
            // Gets the claim with the most recent date
            RecentClaim = DBController.GetRecentClaim(Session.UserAccount);

            // If RecentClaim is not null and has contents...
            if (RecentClaim != null)
            {
                lblClaimID.Text = "ID " + RecentClaim.ID.ToString();
                lblClaimDate.Text = RecentClaim.Date.ToString();
                lblClaimStatus.Text = RecentClaim.Status.ToString();
                btnViewClaim.Visible = true;

                // If recent claim has an assigned claim manger...
                if (RecentClaim.ClientID != 0)
                {
                    btnMessageClient.Visible = true;
                }
                else
                {
                    btnMessageClient.Visible = false;
                }
                // If recent claim has an assigned client manager...
                if (RecentClaim.ClaimManagerID != 0)
                {
                    btnMessageCM.Visible = true;
                }
                else
                {
                    btnMessageCM.Visible = false;
                }
            }
            else
            {
                lblClaimID.Text = "None";
                lblClaimDate.Visible = false;
                lblClaimStatus.Visible = false;
                btnViewClaim.Visible = false;
            }
        }

        private void DisplayNumberOfClaims()
        {
            int? claimCount = DBController.GetClaimCount(Session.UserAccount);

            if (claimCount.HasValue)
            {
                if (claimCount.Value == 1)
                {
                    lblNumClaims.Text = $"1 Claim";
                }
                else
                {
                    lblNumClaims.Text = claimCount.Value.ToString() + " Claims";
                }
            }
            else { lblNumClaims.Text = "No Claims"; }
        }

        private void DisplayRecentMessages()
        {
            RecentMessages = new List<Message>();

            // Get the five most recent messages sent to this user
            RecentMessages = DBController.GetRecentMessages(Session.UserAccount.ID);

            // Loop through each message
            for (int i = 1; i <= RecentMessages.Count; i++)
            {
                Label lblMessage = this.Controls[$"lblMessage{i}"] as Label;

                // Hide label if this message has no subject
                if (RecentMessages[i - 1].Subject == "") { lblMessage.Visible = false; }
                // Else display the message subject
                else
                {
                    lblMessage.Text = RecentMessages[i - 1].Subject;
                    lblMessage.Visible = true;
                }
            }
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlLogin(this));
        }

        private void btnClaimsList_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlClaimsList(this));
        }

        private void btnMessageCM_Click(object sender, EventArgs e)
        {
            Account recentClaimCMAccount = DBController.GetAccountByID(RecentClaim.ClaimManagerID);

            if (recentClaimCMAccount != null && recentClaimCMAccount.ID != 0)
            {
                this.SwapCtrlMain(new ctrlCompose(this, recentClaimCMAccount));
            }
        }

        private void btnMessageClient_Click(object sender, EventArgs e)
        {
            Account recentClaimClientAccount = DBController.GetAccountByID(RecentClaim.ClientID);

            if (recentClaimClientAccount != null && recentClaimClientAccount.ID != 0)
            {
                this.SwapCtrlMain(new ctrlCompose(this, recentClaimClientAccount));
            }
        }

        private void btnViewClaim_Click(object sender, EventArgs e)
        {
            this.SwapCtrlMain(new ctrlClaimViewer(this, RecentClaim.ID));
        }
    }
}
