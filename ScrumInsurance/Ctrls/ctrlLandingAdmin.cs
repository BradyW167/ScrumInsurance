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
using Org.BouncyCastle.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlLandingAdmin : ScrumUserControl
    {
        //private List<Account> Accounts {  get; set; }
        public DataSet Accounts { get; set; }
        public BindingSource bindingSource {get; set;}
        private Dictionary<string, string> args;

        public ctrlLandingAdmin(ScrumUserControl oldCtrl) : base(oldCtrl)
        {

            InitializeComponent();

            dgvUserinfo.Columns.Clear();

            //Binds datagridview to dataset, so changing one changes the other
            bindingSource = new BindingSource();
            dgvUserinfo.DataSource = bindingSource;
            Accounts = DBController.GetAccounts(new Dictionary<string, string>());
            bindingSource.DataSource = Accounts.Tables[0];

            Dictionary<string, string> role_pairs = new Dictionary<string, string>()
            {
                {"All", "*" },
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

        private void CheckDatabase()
        {
            // Store the selected role from the role pair dictionary stored in this combo box
            args = new Dictionary<string, string> { { "role", ((KeyValuePair<string, string>)cmbSelectRole.SelectedItem).Value } };

            //If username is filled in, add it as argument
            if (!txtInputUser.Text.Equals(""))
            {
                args.Add("username", txtInputUser.Text);
            }

            Accounts = DBController.GetAccounts(args);

            bindingSource.DataSource = null;
            bindingSource.DataSource = Accounts.Tables[0];

            dgvUserinfo.Refresh();
        }

        private void cmbSelectRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckDatabase();
        }

        private void txtInputUser_TextChanged(object sender, EventArgs e)
        {
            CheckDatabase();
        }

        private void dgvUserinfo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DBController.UpdateAccounts(args, Accounts);
        }
    }
}
