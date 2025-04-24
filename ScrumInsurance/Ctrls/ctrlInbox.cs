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
    public partial class ctrlInbox : ScrumUserControl
    {
        public int MessageCount { get; set; }
        public int MessageRowHeight { get; set; }
        public long LoadedMessageID { get; set; }

        public ctrlInbox(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();
            lblHeader.Hide();
            lblSender.Hide();
            lblDate.Hide();
            lblContents.Hide();
            lblClaim.Hide();
            pnlMessageContents.Hide();

            MessageCount = 0;
            MessageRowHeight = 60;
            LoadedMessageID = 0;

            // Stores messages in a list for account tied to Session User ID
            List<Message> messages = DBController.GetMessageList(Session.UserAccount.ID);

            // Loop through each message
            if (messages != null)
            {
                foreach (Message msg in messages)
                {
                    AddMessage(msg);
                }
            }
            else
            {
                Console.WriteLine("No messages found.");
            }
        }

        private void AddMessage(Message message)
        {
            MessageCount += 1;

            // Stores the horizontal padding size of the claim list panel
            int padding = flpMessageList.Padding.Left;

            // Create a container panel for this claim row
            Panel container = new Panel();
            container.Width = flpMessageList.Width - padding * 2;
            container.Height = MessageRowHeight;
            container.BackColor = Color.Azure;
            container.BorderStyle = BorderStyle.FixedSingle;
            container.Location = new Point(0, (MessageCount - 1) * MessageRowHeight);
            container.Margin = new Padding(0, 0, 0, MessageRowHeight / 4);

            // Create and style label for this claim
            Label msg = new Label();
            msg.BackColor = Color.Azure;
            msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            msg.Text = $"Sender: {message.SenderUsername}\nSubject: {message.Subject}\nDate: {message.Date}";
            msg.Width = flpMessageList.Width / 2;
            msg.Height = MessageRowHeight;
            msg.Location = new Point(5, 0);

            // Create and style button for this claim
            Button btn = new Button();
            btn.BackColor = Color.Azure;
            btn.Text = "View";
            btn.FlatAppearance.BorderColor = Color.Azure;
            btn.FlatStyle = FlatStyle.Popup;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btn.Width = 50;
            btn.Location = new Point(container.Width - btn.Width - 20, 20);
            btn.Tag = message; // Store message object in this button's tag
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
            Message message = btn.Tag as Message;

            Console.WriteLine("Message" + message);

            // If this message is already loaded, return
            if (message.ID == LoadedMessageID) return;

            // Store this message's id as the loaded message
            LoadedMessageID = message.ID;

            // Unload previous message from contents panel
            if (pnlMessageContents.Controls.Count > 0)
            {
                pnlMessageContents.Controls.RemoveAt(0);
            }

            // Show message properties on labels
            lblSender.Text = "Sender: " + message.SenderUsername;
            lblSender.Show();

            lblDate.Text = message.Date.Split(' ')[0];
            lblDate.Show();

            lblHeader.Text = message.Subject;
            lblHeader.Show();

            string message_content = DBController.GetMessageContent(message.ID);
            pnlMessageContents.Show();

            lblClaim.Text = "Claim ID: " + message.ID;
            lblClaim.Show();

            lblContents.Show();

            // Create label for message and style it
            Label msg = new Label();
            msg.BackColor = Color.Azure;
            msg.TextAlign = ContentAlignment.TopLeft;
            msg.Text = message_content;
            msg.Font = new Font("Microsoft Tai Le", 12, FontStyle.Regular);
            msg.Location = new Point(25,25);
            msg.Width = 550;

            //to handle heights dynamically, each line is roughly 90 characters
            int numLines = 1 + (message_content.Length / 90);

            msg.Height = numLines * 22;
            pnlMessageContents.Controls.Add(msg);

        }

     //   private void btnMessageC_Click(object sender, EventArgs e)
     //   {

     //   }
    }
}
