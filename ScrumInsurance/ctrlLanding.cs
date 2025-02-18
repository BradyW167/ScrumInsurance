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
    public partial class ctrlLanding : UserControl
    {
        private DatabaseController dbController_;
        public ctrlLanding()
        {
            //while the landing page SHOULD always carry over the database from the login, this ensures that it will always have a non null database
            InitializeComponent();
            lblWelcome.Text = "Welcome";
            lblUser.Text = Session.getAccount(Session.userID).username_;
            if (dbController_ == null)
            {
                dbController_ = new DatabaseController();
            }
        }

        public ctrlLanding(DatabaseController dbController)
        {
            //this will carry over the same database used on the connection from the login screen
            InitializeComponent();
            lblUser.Text = Session.getAccount(Session.userID).username_;
            dbController_ = dbController;
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
