using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumInsurance.Ctrls;

namespace ScrumInsurance
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            SetMaxSizeToMonitor();

            Session session = new Session();

            DatabaseController controller = new DatabaseController();

            // Initialize controls for main panel
            ScrumUserControl ctrlLogin = new ctrlLogin(session, controller, pnlMain, this);

            // Load login page as first control into panel
            ctrlLogin.LoadControl();
        }

        private void SetMaxSizeToMonitor()
        {
            // Get the screen where the form is located
            Screen currentScreen = Screen.FromControl(this);

            // Get the working area of the screen (the area excluding the taskbar)
            Rectangle workingArea = currentScreen.WorkingArea;

            // Set the maximum size of the form to the working area's size
            this.MaximumSize = new Size(workingArea.Width, workingArea.Height);

            // Optionally, adjust the form's position or ensure it's fully on-screen
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(workingArea.Width / 2 - this.Width / 2, workingArea.Height / 2 - this.Height / 2);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e) {}
    }
}
