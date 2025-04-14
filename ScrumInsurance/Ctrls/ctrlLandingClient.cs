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
        public ctrlLandingClient(Session session)
        {
            InitializeComponent();
            Session = session;
            RefreshClaims();
        }

        private void ctrlLanding_Load(object sender, EventArgs e)
        {
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.swapCtrlMain(new ctrlLogin());
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
            Label[] lblClaims = new Label[] { lblClaim1, lblClaim2, lblClaim3, lblClaim4 };
            if (((Client)Session.UserAccount).Claims.Count > 0)
            {
                lblNumClaims.Text = ((Client)Session.UserAccount).Claims.Count + " claims ";
                for (int i = 0; i < lblClaims.Length; i++)
                {
                    if (((Client)Session.UserAccount).Claims.Count > i)
                    {
                        lblClaims[i].Text = ((Client)Session.UserAccount).Claims[i].Title + "\nStatus: " + ((Client)Session.UserAccount).Claims[i].Status;
                    }
                    else
                    {
                        lblClaims[i].Visible = false;
                    }
                }
            }
            else
            {
                lblNumClaims.Text = "No claims";
                foreach (Label label in lblClaims)
                {
                    label.Visible = false;
                }
            }
        }

        private void btnNewClaim_Click(object sender, EventArgs e)
        {
            this.swapCtrlMain(new ClaimApply());
        }
    }
}
