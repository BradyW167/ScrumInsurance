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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            Session session = new Session();

            DatabaseController controller = new DatabaseController();

            // Initialize controls for main panel
            ScrumUserControl ctrlLogin = new ctrlLogin(session, controller, pnlMain);

            // Load login page as first control into panel
            ctrlLogin.loadControl();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void formMain_Closing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void formMain_Resize(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlMain.Controls)
            {
                if (ctrl is frmMain)
                {
                    // ctrl.CenterUserControl(ctrl, pnlMain);
                }
            }
        }
        private void lbl_createAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutpnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
