using System.Diagnostics;

namespace WebBrowserApplication
{
    public partial class Web : Form
    {
        public Web()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home landingPage = new Home();

            landingPage.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
            // Replace with your desired URL
            string url = "https://www.google.com";
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open URL: " + ex.Message);
            }
        }
    }
    }
}
