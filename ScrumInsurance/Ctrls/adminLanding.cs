using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance.Ctrls
{
    public partial class adminLanding : UserControl
    {
        private string[] args_ = null;
        public adminLanding()
        {
            InitializeComponent();
            dgUserinfo.Rows.Add();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmitUser_Click(object sender, EventArgs e)
        {

        }
    }
}
