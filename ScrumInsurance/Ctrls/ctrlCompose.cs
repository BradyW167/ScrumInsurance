using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Crmf;

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlCompose : ScrumUserControl
    {
        public int UserCount { get; set; }
        public int UserRowHeight { get; set; }
        public long LoadedUserID { get; set; }

        public ctrlCompose(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblErrorList.Hide();
            UserCount = 0;
            UserRowHeight = 60;
            LoadedUserID = 0;

            // Stores messages in a list for account tied to Session User ID
            List<Account> users = DBController.GetUserList(txtSearch.Text);

            // Loop through each message
            if (users != null)
            {
                foreach (Account acc in users)
                {
                    AddAccount(acc);
                }
            }
            else
            {
                Console.WriteLine("No accounts found.");
            }
        }

        // Constructor with input account to send a message to
        public ctrlCompose(ScrumUserControl oldCtrl, Account newMessageRecipientAccount) : base(oldCtrl)
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblErrorList.Hide();
            UserCount = 0;
            UserRowHeight = 60;
            LoadedUserID = 0;

            // Stores messages in a list for account tied to Session User ID
            List<Account> users = DBController.GetUserList(txtSearch.Text);

            // Loop through each message
            if (users != null)
            {
                foreach (Account acc in users)
                {
                    AddAccount(acc);
                }
            }
            else
            {
                Console.WriteLine("No accounts found.");
            }

            // Store this message's id as the loaded message
            LoadedUserID = newMessageRecipientAccount.ID;

            //show username on compose 
            lblRecipient.Text = "Send To: " + newMessageRecipientAccount.Username;
        }

        private void AddAccount(Account user)
        {
            // Skip own account
            if (user.ID == Session.UserAccount.ID) { return; }

            UserCount += 1;

            // Stores the horizontal padding size of the claim list panel
            int padding = flpMessageList.Padding.Left;

            // Create a container panel for this claim row
            Panel container = new Panel();
            container.Width = flpMessageList.Width - padding * 2;
            container.Height = UserRowHeight;
            container.BackColor = Color.Azure;
            container.BorderStyle = BorderStyle.FixedSingle;
            container.Location = new Point(0, (UserCount - 1) * UserRowHeight);
            container.Margin = new Padding(0, 0, 0, UserRowHeight / 4);

            // Create and style label for this claim
            Label msg = new Label();
            msg.BackColor = Color.Azure;
            msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            msg.Text = $"Username: {user.Username}\nRole: {user.Role}\n";
            msg.Width = flpMessageList.Width / 2;
            msg.Height = UserRowHeight;
            msg.Location = new Point(5, 0);

            // Create and style button for this claim
            Button btn = new Button();
            btn.BackColor = Color.Azure;
            btn.Text = "Select";
            btn.FlatAppearance.BorderColor = Color.Azure;
            btn.FlatStyle = FlatStyle.Popup;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btn.Width = 50;
            btn.Location = new Point(container.Width - btn.Width - 20, 20);
            btn.Tag = user; // Store message object in this button's tag
            btn.Click += new System.EventHandler(this.btnMessageA_Click);

            // Add controls to the container panel
            container.Controls.Add(msg);
            container.Controls.Add(btn);

            // Add the container to the claim list panel
            flpMessageList.Controls.Add(container);
        }

        private void btnMessageA_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Button clicked");
            // Cast the sender object as a button
            Button btn = sender as Button;

            // Get the message object stored in this button's tag
            Account user = btn.Tag as Account;

            Console.WriteLine("Account" + user);

            // If this message is already loaded, return
            if (user.ID == LoadedUserID) return;

            // Store this message's id as the loaded message
            LoadedUserID = user.ID;

            //show username on compose 
            lblRecipient.Text = "Send To: " + user.Username;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //unload old messages
            for (int i = 0; i < UserCount; i++)
            {
                flpMessageList.Controls.RemoveAt(0);
            }
            UserCount = 0;

            List<Account> users = DBController.GetUserList(txtSearch.Text);

            // Loop through each message
            if (users != null)
            {
                foreach (Account acc in users)
                {
                    AddAccount(acc);
                }
            }
            else
            {
                Console.WriteLine("No accounts found.");
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DBController.SendMessage(Session.UserAccount.ID, txtSubject.Text, txtContents.Text, LoadedUserID);
        }

        //   private void btnMessageC_Click(object sender, EventArgs e)
        //   {

        //   }
    }
}
