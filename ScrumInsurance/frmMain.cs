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
            ScrumUserControl ctrlLogin = new ctrlLogin(session, controller, pnlMain, this);

            // Load login page as first control into panel
            ctrlLogin.LoadControl();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e) {}
    }
}
