using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Utilities;
using Renci.SshNet.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlLandingAdmin : ScrumUserControl
    {
        public DataSet AccountDataSet { get; set; }
        public BindingSource BindingSource {get; set;}
        private Dictionary<string, string> WhereConditions;

        public ctrlLandingAdmin(ScrumUserControl oldCtrl) : base(oldCtrl)
        {

            InitializeComponent();

            // Binds datagridview to dataset, so changing one changes the other
            BindingSource = new BindingSource();

            // Stores the Data Set
            AccountDataSet = DBController.GetAccountDataSet();

            BindingSource.DataSource = AccountDataSet.Tables["Accounts"];

            dgvUserinfo.DataSource = BindingSource;

            // Sets the data grid to auto size all columns
            dgvUserinfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

            cmbSelectRole.DropDownHeight = cmbSelectRole.ItemHeight * (cmbSelectRole.Items.Count + 1);

            WhereConditions = new Dictionary<string, string>();
        }

        private void cmbSelectRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ReloadDataGrid();
        }

        private void txtInputUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReloadDataGrid();
            }
        }

        private void txtInputUser_Leave(object sender, EventArgs e)
        {
            ReloadDataGrid();
        }

        private void ReloadDataGrid()
        {
            // Store the selected role in the combobox dropdown
            string selected_role = ((KeyValuePair<string, string>)cmbSelectRole.SelectedItem).Value;

            // If not selecting all roles
            if (selected_role != "*")
            {
                // Store the selected role from the role pair dictionary stored in this combo box
                WhereConditions.Add("role", selected_role);
            }

            //If username is filled in, add it as argument
            if (!txtInputUser.Text.Equals(""))
            {
                WhereConditions.Add("username", txtInputUser.Text);
            }

            // Stores the dataset of accounts
            AccountDataSet = DBController.GetAccountDataSet(WhereConditions);

            // Clear the data source for the table to force an update
            BindingSource.DataSource = null;

            // Input the new binding data source as the Account Data Set 'Accounts' table
            BindingSource.DataSource = AccountDataSet.Tables["Accounts"];

            // dgvUserinfo.Refresh();

            // Clear the where conditions after use
            WhereConditions.Clear();
        }

        private void dgvUserinfo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Access updated data
                var updatedRow = AccountDataSet.Tables["Accounts"].Rows[e.RowIndex];
                var updatedValue = updatedRow[e.ColumnIndex];
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            // Force commit of any current edit in progress
            dgvUserinfo.EndEdit();

            // Optional: also commit to DataTable if bound via BindingSource
            if (dgvUserinfo.DataSource is BindingSource bs)
            {
                bs.EndEdit();
            }

            DBController.CommitAccountChanges();
        }
    }
}
