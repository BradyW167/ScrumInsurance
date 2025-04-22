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
    public partial class ctrlLandingClient : ScrumUserControl
    {
        public ctrlLandingClient(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.SwapCtrlMain(new ctrlLogin(this));
            Session.UserAccount = null;
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

        private void btnNewClaim_Click(object sender, EventArgs e)
        {
            this.SwapCtrlMain(new ctrlClaimApply(this));
        }
    }
}
