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
            lblWelcome.Text = "Welcome, " + session.Username;
        }

        private void ctrlLanding_Load(object sender, EventArgs e)
        {

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.swapControl(new ctrlLogin());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLanding_Click(object sender, EventArgs e)
        {

        }
    }
}
