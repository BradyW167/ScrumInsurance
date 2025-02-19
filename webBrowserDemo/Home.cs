using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserApplication
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Web landingPage = new Web();

            landingPage.Show();
            this.Hide();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            object value = toolTip1_Popup.Show();
        }

        private void txtbHome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
