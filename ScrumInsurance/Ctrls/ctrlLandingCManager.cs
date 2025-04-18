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
    public partial class ctrlLandingCManager : ScrumUserControl
    {
        public ctrlLandingCManager()
        {
            InitializeComponent();
        }

        private void ctrlLanding_Load(object sender, EventArgs e)
        {
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

        private void btnClaimsList_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlClaimsList(Session, DBController));
        }
    }
}
