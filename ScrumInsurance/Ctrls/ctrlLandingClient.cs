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
        DatabaseController dbController_; // we will need this later. Might be efficient to pass in db?
        public ctrlLandingClient(Session session)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome,\n" + session.Username;
            lblUser.Text = session.Username;
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
    }
}
