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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();

            // Initialize controls for main panel
            UserControl ctrlLogin = new LoginControl();

            ctrlLogin.Anchor = AnchorStyles.None; // Prevent stretching

            pnlMain.Controls.Add(ctrlLogin, 1, 0); // Add to center column
            CenterUserControl(ctrlLogin);
        }

        // Function to center the UserControl inside the column
        private void CenterUserControl(Control control)
        {
            int columnIndex = 1; // Assuming it's in the middle column
            int rowIndex = 0;     // Assuming it's in row 0

            // Get the column width
            int columnWidth = pnlMain.GetColumnWidths()[columnIndex];
            int rowHeight = pnlMain.GetRowHeights()[rowIndex];

            // Set the position dynamically
            control.Left = (columnWidth - control.Width) / 2;
            control.Top = (rowHeight - control.Height) / 2;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void LoginPage_Resize(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlMain.Controls)
            {
                if (ctrl is LoginPage)
                {
                    CenterUserControl(ctrl);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

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
