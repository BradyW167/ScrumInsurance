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
        public ctrlLogin()
        {
            InitializeComponent();

            DatabaseController dbController_ = new DatabaseController();
        }

        private void ctrlLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TableLayoutPanel parentPanel = this.Parent as TableLayoutPanel;

            // Load next page if database connection established
            /*if (dbController_.isConnected())
             * {
             * 
            */
            if (parentPanel != null)
            {
                int columnIndex = parentPanel.GetColumn(this);
                int rowIndex = parentPanel.GetRow(this);

                // Remove the current UserControl
                parentPanel.Controls.Remove(this);
                this.Dispose();

                // Load the new UserControl
                ctrlForgotPass newControl = new ctrlForgotPass();
                newControl.Dock = DockStyle.Fill;

                // Add new UserControl to the same cell
                parentPanel.Controls.Add(newControl, columnIndex, rowIndex);
            }
        }
    }
}
