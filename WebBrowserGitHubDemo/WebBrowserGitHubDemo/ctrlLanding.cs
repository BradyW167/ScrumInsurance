using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserGitHubDemo
{
    public partial class ctrlLanding : UserControl
    {
        public ctrlLanding()
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome";
            lblUser.Text = Session.GetAccount(Session.UserID).Username;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            ctrlLogin c = new ctrlLogin();
            Session.swapControl(this, c);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
