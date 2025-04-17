using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cmp;

namespace ScrumInsurance
{
    public partial class ctrlClaimsList : ScrumUserControl
    {
        private int claimCount_ = 0;
        private Session session_;
        public ctrlClaimsList(Session session, DatabaseController DBController)
        {
            InitializeComponent();
            session_ = session;
            //these are the columns we want to grab for the select query
            string[] columns = { "Claim_Title", "Claim_Date", "Claim_Status", "Claim_ID" };

            //these set the args. 
            
            Dictionary<String, Object> args = new Dictionary<String, Object>();
            if (session.UserAccount.Role.Equals("claim_manager"))
            {
                args.Add("Claim_Status", "Validating");
            }
            else if (session.UserAccount.Role.Equals("finance_manager"))
            {
                args.Add("Claim_Status", "Financing");
            }


            Dictionary<int, object[]> claimList = DBController.ClaimInformation(args, columns);
            for (int i = 0; i < claimList.Count; i++)
            {
                object[] claimDetails = claimList[i];
                addClaim(claimDetails[0].ToString(), claimDetails[2].ToString(), claimDetails[1].ToString(), claimDetails[3]);
                Console.WriteLine(claimDetails[0] + ", " + claimDetails[1] + ", " + claimDetails[2] + ", ");
            }

        }

        private void addClaim(string sender, string subject, string date, object id)
        {
            claimCount_++;
            //view button
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.BackColor = Color.Azure;
            btn.Text = "View";
            btn.FlatAppearance.BorderColor = Color.Azure;
            btn.FlatStyle = FlatStyle.Popup;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Width = 40;
            btn.Location = new Point(170, (claimCount_ * 60) - 25);
            //we store the messageID in the buttons tag so that it can be called later using the sender in the click function. 
            btn.Tag = id;
            btn.Click += new System.EventHandler(this.btnMessageA_Click);
            pnlList.Controls.Add(btn);



            //message textbox
            Label msg = new Label();
            msg.BackColor = Color.Azure;
            msg.TextAlign = ContentAlignment.MiddleLeft;
            msg.Text = "Claim Title: " + sender + "\nStatus: " + subject + "\nDate: " + date;
            msg.Location = new Point(10, (claimCount_ * 60) - 40);
            msg.Width = 210;
            msg.Height = 50;
            pnlList.Controls.Add(msg);
        }


        private void btnMessageA_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            int claimId = int.Parse((btn.Tag).ToString());
            swapCtrlMain(new ctrlClaimViewer(DBController, claimId, session_));
        }
    }
}
