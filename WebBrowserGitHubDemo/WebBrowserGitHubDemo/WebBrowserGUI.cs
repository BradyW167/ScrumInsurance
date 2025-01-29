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

        private void btnFirstButton_Click(object sender, EventArgs e)
        {
            btnFirstButton.Text = "You clicked me didnt you";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnFirstButton.Text = "Do Not Click Me";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            wbrDisplay.Refresh();
        }
    }
}
