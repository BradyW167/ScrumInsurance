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
    public partial class ctrlAdminLanding : ScrumUserControl
    {
        // private string[] args_ = null;

        public ctrlAdminLanding(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmitUser_Click(object sender, EventArgs e)
        {
            Account admin_account = DBController.ValidateLogin("test", "admin12345");
            string[] account_info = { admin_account.Username, admin_account.Password, admin_account.Role, admin_account.SecurityQuestion, admin_account.SecurityAnswer };
            dgUserinfo.Rows.Add(account_info);
        }
    }
}
