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

namespace ScrumInsurance
{
    public partial class ctrlInbox : ScrumUserControl
    {
        private int messageCount_ = 0;
        public ctrlInbox(Session session, DatabaseController DBController)
        {
            InitializeComponent();

            //these are the columns we want to grab for the select query
            string[] columns = { "Sender", "Message_Date", "Message_Subject"};

            //these set the args. 
            Dictionary<String, Object> args = new Dictionary<String, Object>();
            args.Add("Recipient", session.UserAccount.Username);
            Console.WriteLine(session.UserAccount.Username);

            Dictionary<int, object[]> messageList = DBController.MessageInformation(args, columns);
            for (int i = 0; i < messageList.Count; i++)
            {
                object[] messageDetails = messageList[i];
                addMessage(messageDetails[0].ToString(), messageDetails[2].ToString(), messageDetails[1].ToString());
                Console.WriteLine(messageDetails[0] + ", "+ messageDetails[1] + ", " + messageDetails[2] + ", ");
            }

            

        }

        private void addMessage(string sender, string subject, string date)
        {
            messageCount_++;
            //view button
            Button btn = new Button();
            btn.BackColor = Color.Azure;
            btn.Text = "View";
            btn.FlatAppearance.BorderColor = Color.Azure;
            btn.FlatStyle = FlatStyle.Popup;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Width = 40;
            btn.Location = new Point(170, (messageCount_ * 60) -25);
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
    }
}
