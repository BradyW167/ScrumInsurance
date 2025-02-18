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
    public partial class ctrlLanding : ScrumUserControl
    {
        public ctrlLanding()
        {
            InitializeComponent();
            /* Causes error because "session_ is null"
            lblUser.Text = session_.getAccount(session_.userID).Username;*/
        }

        private void ctrlLanding_Load(object sender, EventArgs e)
        {
            // Load username into text label Doesn't run when page is loaded
            lblUser.Text = session_.getAccount(session_.userID).Username;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.swapControl(new ctrlLogin());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
