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
    public partial class ctrlLogin : UserControl
    {
        private DatabaseController dbController_;

        public ctrlLogin(DatabaseController dbController)
        {
            InitializeComponent();
            dbController_ = dbController;
        }

        private void ctrlLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Load next page if database connection established
            if (dbController_.openConnection())
            {
                ctrlForgotPass newControl = new ctrlForgotPass();
                swapControl(newControl);
            }
            else {
                btnLogin.Text = "Failed";
            }
        }

        // Deletes the current user control in parent panel and load a new input control
        private void swapControl(UserControl c)
        {
            TableLayoutPanel parentPanel = this.Parent as TableLayoutPanel;

            if (parentPanel != null)
            {
                int columnIndex = parentPanel.GetColumn(this);
                int rowIndex = parentPanel.GetRow(this);

                // Remove the current UserControl
                parentPanel.Controls.Remove(this);
                this.Dispose();

                // Load the new UserControl
                c.AutoSize = true;
                c.Dock = DockStyle.Fill;

                // Add new UserControl to the same cell
                parentPanel.Controls.Add(c, columnIndex, rowIndex);
            }
        }
    }
}
