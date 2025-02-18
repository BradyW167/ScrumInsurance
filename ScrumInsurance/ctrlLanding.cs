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
        }

        private void ctrlLanding_Load(object sender, EventArgs e)
        {
            // Load username into text label
            lblUser.Text = session_.getAccount(session_.userID).Username;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            ctrlLogin c = new ctrlLogin();
            this.swapControl(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
