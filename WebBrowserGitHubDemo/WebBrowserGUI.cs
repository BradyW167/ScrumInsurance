using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Hello World, Goodbye World (Section 01 is dark)
// Hello World...Clone Dr. R, are you crazy
namespace WebBrowserGitHubDemo
{
    public partial class WebBrowserGUI : Form
    {
        public WebBrowserGUI()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            wbrDisplay.Navigate(txtURL.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBack.Text = "Load";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            wbrDisplay.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            wbrDisplay.GoHome();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Text = "Back";
            wbrDisplay.GoBack();
        }

        private void wbrDisplay_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void WebBrowserGUI_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtURL.Text = "";
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
