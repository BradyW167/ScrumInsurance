using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Crmf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlInbox : ScrumUserControl
    {
        public int MessageCount { get; set; }
        public int LoadedMessageID { get; set; }

        public ctrlInbox(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();
            lblHeader.Hide();
            lblSender.Hide();
            lblDate.Hide();
            lblContents.Hide();
            lblClaim.Hide();
            pnlMessageContents.Hide();

            // Stores messages in a list for account tied to Session User ID
            List<Message> messages = DBController.GetMessageList(int.Parse(Session.UserAccount.ID.ToString()));

            // Loop through each message
            if (messages != null)
            {
                foreach (Message msg in messages)
                {
                    msg.initializeSender(DBController);
                    AddMessage(msg);
                }
            }
            else
            {
                Console.WriteLine("No messages found.");
            }
        }

        private void ctrlInbox_Load(object sender, EventArgs e)
        {
        }

        private void AddMessage(Message msg)
        {
            MessageCount++;

            // Create new button for this message and style it
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.BackColor = Color.Azure;
            btn.Text = "View";
            btn.FlatAppearance.BorderColor = Color.Azure;
            btn.FlatStyle = FlatStyle.Popup;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Width = 40;
            btn.Location = new Point(190, (MessageCount * 70) - 25);

            // Store message id in button btn's 'Tag' property
            btn.Tag = msg.ID;

            // Add click handler to button btn
            btn.Click += new System.EventHandler(this.btnMessageA_Click);

            // Add button btn to the message panel
            pnlMessages.Controls.Add(btn);

            // Create new label for this message and style it
            Label lblMessage = new Label();
            lblMessage.BackColor = Color.Azure;
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            lblMessage.Location = new Point(25, (MessageCount * 70) - 45);
            lblMessage.Width = 230;
            lblMessage.Height = 60;

            // Show message info as label text
            lblMessage.Text = "Sender: " + msg.Sender + "\nSubject: " + msg.Subject + "\nDate: " + msg.Date;

            // Add lblMessage to the message panel
            pnlMessages.Controls.Add(lblMessage);
        }

        private void btnMessageA_Click(object sender, EventArgs e)
        {
            // Cast the sender object as a button
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            // Get the message_id for this btn's message from its tag value
            int message_id = int.Parse(btn.Tag.ToString());

            // If this message is already loaded, return
            if (message_id == LoadedMessageID) return;

            // Store this message's id as the loaded message
            LoadedMessageID = message_id;

            // Unload previous message from contents panel
            if (pnlMessageContents.Controls.Count > 0)
            {
                pnlMessageContents.Controls.RemoveAt(0);
            }

            // Get the message for messageID
            Message message = DBController.GetMessage(message_id);
            message.initializeSender(DBController);

            //assign to lables and show
            lblSender.Text = "Sender: " + message.Sender;
            lblSender.Show();

            Console.WriteLine(message);

            lblDate.Text = message.Date.Split(' ')[0];
            lblDate.Show();

            lblHeader.Text = message.Subject;
            lblHeader.Show();

            string message_content = message.Content;
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
