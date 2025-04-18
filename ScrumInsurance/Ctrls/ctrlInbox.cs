﻿using System;
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

namespace ScrumInsurance
{
    public partial class ctrlInbox : ScrumUserControl
    {
        public int MessageCount { get; set; }
        public int LoadedMessageID { get; set; }

        public ctrlInbox()
        {
            InitializeComponent();
            lblHeader.Hide();
            lblSender.Hide();
            lblDate.Hide();
            lblContents.Hide();
            lblClaim.Hide();
            pnlMessageContents.Hide();
        }

        private void ctrlInbox_Load(object sender, EventArgs e)
        {
            // Stores messages in a list for account tied to Session username
            List<Message> messages = DBController.GetMessages(Session.UserAccount.Username);

            // Loop through each message
            foreach (Message msg in messages)
            {
                AddMessage(msg);
            }
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
            btn.Location = new Point(170, (MessageCount * 60) -25);

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
            lblMessage.Location = new Point(10, (MessageCount * 60) - 40);
            lblMessage.Width = 210;
            lblMessage.Height = 50;

            // Show message info as label text
            lblMessage.Text = "Sender: " + msg.Sender + "\nSubject: " + msg.Subject + "\nDate: " + msg.Date;

            // Add lblMessage to the message panel
            pnlMessages.Controls.Add(lblMessage);
        }

        private void btnMessageA_Click(object sender, EventArgs e)
        {
            // Create a new button using the input sender object
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

            //assign to lables and show
            lblSender.Text = "Sender: " + message.Sender;
            lblSender.Show();

            Console.WriteLine(message);

            lblDate.Text = message.Date.Split(' ')[0];
            lblDate.Show();

            lblHeader.Text = message.Subject;
            lblHeader.Show();

            String messageContent = message.Content;
            pnlMessageContents.Show();

            lblClaim.Text = "Claim ID: " + message.ID;
            lblClaim.Show();

            // Create label for message and style it
            Label msg = new Label();
            msg.BackColor = Color.Azure;
            msg.TextAlign = ContentAlignment.TopLeft;
            msg.Text = messageContent;
            msg.Font = new Font("Microsoft Tai Le", 11, FontStyle.Regular);
            msg.Location = new Point(22,10);
            msg.Width = 550;

            //to handle heights dynamically, each line is roughly 90 characters
            int numLines = 1 + (messageContent.Length / 90);

            msg.Height = numLines * 22;
            pnlMessageContents.Controls.Add(msg);

        }

        private void btnMessageC_Click(object sender, EventArgs e)
        {

        }
    }
}
