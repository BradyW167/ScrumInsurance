using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet.Messages;
using ScrumInsurance.Database;

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlClaimViewer : ScrumUserControl
    {
        Claim Claim { get; set; }

        public ctrlClaimViewer(ScrumUserControl oldCtrl, long claim_id) : base(oldCtrl)
        {
            InitializeComponent();
            string role = Session.UserAccount.Role;

            // Stores queried claim matching input claim_id in class property
            Claim = DBController.GetClaim(claim_id);

            // Stores status of the input claim
            string status = Claim.Status.ToString();

            // Set the status label text
            lblClaimStatusValue.Text = status;

            // Set the label's color based on the status
            if (status == "Pending")
            {
                lblClaimStatusValue.ForeColor = Color.Olive;
            }
            else if (status == "Financing")
            {
                lblClaimStatusValue.ForeColor = Color.SeaGreen;
            }
            else if (status == "Approved")
            {
                lblClaimStatusValue.ForeColor = Color.Green;
            }
            else if (status == "Rejected")
            {
                lblClaimStatusValue.ForeColor = Color.Red;
            }

            // Set the claim amount label
            lblClaimAmountValue.Text = Claim.Amount.ToString();
            
            // Set the claim content text
            rtxDetails.Text = Claim.Content.ToString();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (Session.UserAccount.Role.Equals("claim_manager"))
            {
                if(DBController.UpdateClaim(Claim.ID, "Status", "Financing") == true) 
                {
                    lblClaimStatusValue.Text = "Financing";
                    lblClaimStatusValue.ForeColor = Color.SeaGreen;
                }
                
            }
            else if (Session.UserAccount.Role.Equals("finance_manager"))
            {
                DBController.UpdateClaim(Claim.ID, "Status", "Approved");
                lblClaimStatusValue.Text = "Approved";
                lblClaimStatusValue.ForeColor = Color.Green;
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            DBController.UpdateClaim(Claim.ID, "Status", "Rejected");
            lblClaimStatusValue.Text = "Rejected";
            lblClaimStatusValue.ForeColor = Color.Red;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            // Gets the ID of the finance manager with the least claims assigned
            long financer_id = DBController.GetLeastClaimsManagerID(false);
            
            DBController.UpdateClaim(Claim.ID, "finance_manager_id", financer_id);
            if (DBController.UpdateClaim(Claim.ID, "Status", "Financing") == true)
            {
                lblClaimStatusValue.Text = "Financing";
                lblClaimStatusValue.ForeColor = Color.SeaGreen;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SwapCtrlMain(new ctrlClaimsList(this));
        }

        private void btnClientProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnViewDocs_Click(object sender, EventArgs e)
        {
            // Get the documents associated with this claim as a list
            List<Document> documents = DBController.GetDocuments(Claim.ID);

            // If documents is null, there was a database error
            if (documents == null)
            {
                errClaim.SetError(btnViewDocs, "Database connection error");
            }
            // If there are no documents, display to user
            else if (documents.Count == 0)
            {
                errClaim.SetError(btnViewDocs, "No documents found");
            }
            else
            {
                // Clear error text
                errClaim.SetError(btnViewDocs, "");

                foreach (Document document in documents)
                {
                    DownloadDocument(document);
                }
            }
        }

        private void DownloadDocument(Document doc)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = doc.FileName;
                saveFileDialog.Filter = "All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, doc.FileData);
                    MessageBox.Show("File downloaded successfully!", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
