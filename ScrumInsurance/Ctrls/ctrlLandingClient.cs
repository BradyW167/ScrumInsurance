using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance
{
    public partial class ctrlLandingClient : ScrumUserControl
    {
        public ctrlLandingClient()
        {
            InitializeComponent();
        }

        private void ctrlLanding_Load(object sender, EventArgs e)
        {
            RefreshClaims();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.SwapCtrlMain(new ctrlLogin());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLanding_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void RefreshClaims()
        {
            // Convert the Session Account object to a Client object
            Client client = Session.UserAccount as Client;

            // Stores names of each label for displaying claims
            Label[] lblClaims = new Label[] { lblClaim1, lblClaim2, lblClaim3, lblClaim4 };

            // If the client has any claims...
            if (client.Claims.Count > 0)
            {
                // Display claim count in lblNumClaims
                lblNumClaims.Text = "You Have " + client.Claims.Count + " Claims";

                // Loop through each claim, up to 4
                for (int i = 0; i < 4; i++)
                {
                    // If claim i does not exist...
                    if (client.Claims[i] != null)
                    {
                        // Hide label for claim i and continue to next claim
                        lblClaims[i].Visible = false;
                        continue;
                    };

                    // Set claim label i's text to claim i's info
                    lblClaims[i].Text = client.Claims[i].Title + "\nStatus: " + client.Claims[i].Status;
                    
                    // Make claim i visible
                    lblClaims[i].Visible = true;
                }
            }
            // Else client has no claims
            else
            {
                // Show user they have no claims
                lblNumClaims.Text = "No Claims";

                // Hide all claim labels
                foreach (Label label in lblClaims) { label.Visible = false; }
            }
        }

        private void btnNewClaim_Click(object sender, EventArgs e)
        {
            this.SwapCtrlMain(new ctrlClaimApply());
        }
    }
}
