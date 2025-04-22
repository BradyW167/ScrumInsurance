using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlLandingAdmin : ScrumUserControl
    {
        private List<Account> Accounts {  get; set; }

        public ctrlLandingAdmin(ScrumUserControl oldCtrl) : base(oldCtrl)
        {

            InitializeComponent();

            Accounts = new List<Account>();

            dgvUserinfo.Columns.Clear();

            dgvUserinfo.DataSource = null;
            dgvUserinfo.DataSource = Accounts;

            Dictionary<string, string> role_pairs = new Dictionary<string, string>()
            {
                {"Admins", "admin" },
                {"Claim Managers", "claim_manager" },
                {"Finance Managers", "finance_manager" },
                {"Clients", "client" }
            };

            cmbSelectRole.DataSource = new BindingSource(role_pairs, null);
            cmbSelectRole.DisplayMember = "Key";
            cmbSelectRole.ValueMember = "Value";
        }

        private void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtInputUser_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmbSelectRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Store the selected role from the role pair dictionary stored in this combo box
            string selected_role = ((KeyValuePair<string, string>)cmbSelectRole.SelectedItem).Value;

            Accounts = DBController.GetAccountsByRole(selected_role);

            dgvUserinfo.DataSource = null;
            dgvUserinfo.DataSource = Accounts;

            dgvUserinfo.Refresh();
        }
    }
}
