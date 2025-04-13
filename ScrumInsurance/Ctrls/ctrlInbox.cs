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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScrumInsurance
{
    public partial class ctrlInbox : ScrumUserControl
    {
        private int messageCount_ = 0;
        public ctrlInbox(Session session, DatabaseController DBController)
        {
            InitializeComponent();
            lblHeader.Hide();
            lblSender.Hide();
            lblDate.Hide();
            lblContents.Hide();
            lblClaim.Hide();
            pnlMessageContents.Hide();

            //these are the columns we want to grab for the select query
            string[] columns = { "Sender", "Message_Date", "Message_Subject", "Message_ID"};

            //these set the args. 
            Dictionary<String, Object> args = new Dictionary<String, Object>();
            args.Add("Recipient", session.UserAccount.Username);
            Console.WriteLine(session.UserAccount.Username);

            Dictionary<int, object[]> messageList = DBController.MessageInformation(args, columns);
            for (int i = 0; i < messageList.Count; i++)
            {
                object[] messageDetails = messageList[i];
                addMessage(messageDetails[0].ToString(), messageDetails[2].ToString(), messageDetails[1].ToString(), messageDetails[3]);
                Console.WriteLine(messageDetails[0] + ", "+ messageDetails[1] + ", " + messageDetails[2] + ", ");
            }

            

        }

        private void addMessage(string sender, string subject, string date, object id)
        {
            messageCount_++;
            //view button
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.BackColor = Color.Azure;
            btn.Text = "View";
            btn.FlatAppearance.BorderColor = Color.Azure;
            btn.FlatStyle = FlatStyle.Popup;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Width = 40;
            btn.Location = new Point(170, (messageCount_ * 60) -25);
            //we store the messageID in the buttons tag so that it can be called later using the sender in the click function. 
            btn.Tag = id;
            btn.Click += new System.EventHandler(this.btnMessageA_Click);
            pnlMessages.Controls.Add(btn);
            


            //message textbox
            Label msg = new Label();
            msg.BackColor = Color.Azure;
            msg.TextAlign = ContentAlignment.MiddleLeft;
            msg.Text = "Sender: " + sender + "\nSubject: " + subject + "\nDate: " + date;
            msg.Location = new Point(10, (messageCount_ * 60) - 40);
            msg.Width = 210;
            msg.Height = 50;
            pnlMessages.Controls.Add(msg);
        }

        private void btnMessageA_Click(object sender, EventArgs e)
        {
            //this unloads any previous control in the panel. 
            if (pnlMessageContents.Controls.Count > 0)
            {
                pnlMessageContents.Controls.RemoveAt(0);
            }

            //this creates a new button using sender as a button
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            //because the sender is always a button created in the addMessage method, it will have the id stored in the tag which we can grab. 
            int messageId = int.Parse((btn.Tag).ToString());

            //columns for query 
            string[] messageColumns = { "Sender", "Message_Date", "Message_Subject",  "Message_Content", "Claim_ID"};

            //these set the args. 
            Dictionary<String, Object> args = new Dictionary<String, Object>();
            args.Add("Message_ID", messageId);

            //call the query and get the details
            Dictionary<int, object[]> messageList = DBController.MessageInformation(args, messageColumns);
            object[] messageDetails = messageList[0]; // because messageID is unique, we only need [0]

            //assign to lables and show
            lblSender.Text = "Sender: " + messageDetails[0].ToString();
            lblSender.Show();

            lblDate.Text = messageDetails[1].ToString().Split(' ')[0];
            lblDate.Show();

            lblHeader.Text = messageDetails[2].ToString();
            lblHeader.Show();

            String messageContent = messageDetails[3].ToString();
            pnlMessageContents.Show();

            lblClaim.Text = "Claim ID: " + messageDetails[4].ToString();
            lblClaim.Show();


            //adds the contents to the panel. 

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
