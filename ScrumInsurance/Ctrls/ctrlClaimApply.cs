using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Paddings;
using Renci.SshNet.Messages;

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlClaimApply : ScrumUserControl
    {
        private List<string> DocumentPaths { get; set; }
        private int DocumentCount { get; set; }
        private int DocumentRowHeight { get; set; }

        public ctrlClaimApply(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();

            lblError.Text = "";

            DocumentPaths = new List<string>();

            DocumentCount = 0;
            DocumentRowHeight = 25;

            SetFileDialogProperties();
        }

        private void SetFileDialogProperties() {
            // Set filter options (PDF, Word)
            this.ofdClaimDocument.Filter = "PDF files (*.pdf)|*.pdf|Word documents (*.docx)|*.docx";

            // Sets initial directory to user's documents directory
            this.ofdClaimDocument.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Enables selection of multiple files
            this.ofdClaimDocument.Multiselect = true;

            // Set title of dialog
            this.ofdClaimDocument.Title = "Select a Claim Document";
        }

        /**
         * Opens file dialog for selection of documents
         * Stores their paths in DocumentPaths
         */
        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.ofdClaimDocument.ShowDialog();

            // If file selection was successful...
            if (dr == DialogResult.OK)
            {
                // Loop through each file selected in the dialog
                foreach (string file_path in ofdClaimDocument.FileNames)
                {
                    // Add this file's file path to the list of document paths
                    DocumentPaths.Add(file_path);

                    // Display document in the flow panel
                    AddDocument(file_path);
                }
            }
        }

        private void AddDocument(string file_path)
        {
            DocumentCount += 1;

            // Stores the horizontal padding size of the document list panel
            int padding = flpDocumentList.Padding.Left;

            // Create a container panel for this document row
            Panel container = new Panel();
            container.Width = flpDocumentList.Width - padding * 2;
            container.Height = DocumentRowHeight;
            container.BackColor = Color.Azure;
            container.BorderStyle = BorderStyle.FixedSingle;
            container.Location = new Point(0, (DocumentCount - 1) * DocumentRowHeight);
            container.Margin = new Padding(0, 0, 0, DocumentRowHeight / 4);
            container.Padding = new Padding(0);

            // Create and style label for this claim
            Label msg = new Label();
            msg.BackColor = Color.Azure;
            msg.Width = container.Width;
            msg.Height = container.Height;
            msg.Location = new Point(0, 0);
            msg.MaximumSize = new Size(container.Width - DocumentRowHeight, DocumentRowHeight);
            msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            string file_name = Path.GetFileName(file_path);

            if (file_name.Length > 35)
            {
                file_name = file_name.Substring(0, 30) + "...";
            }

            // Display the possibly truncated filename
            msg.Text = file_name;

            // Create and style button for this claim
            PictureBox pbx = new PictureBox();
            pbx.Image = Properties.Resources.trash_bin;
            pbx.SizeMode = PictureBoxSizeMode.Zoom;
            pbx.BackColor = Color.Azure;
            pbx.Width = DocumentRowHeight;
            pbx.Height = DocumentRowHeight;
            pbx.Location = new Point(container.Width - DocumentRowHeight, -1);
            pbx.Tag = file_path; // Store file path in this picture's tag
            pbx.Click += new System.EventHandler(this.pbxTrashDocument_Click);

            // Add controls to the container panel
            container.Controls.Add(msg);
            container.Controls.Add(pbx);

            // Add the container to the claim list panel
            flpDocumentList.Controls.Add(container);
        }

        private void pbxTrashDocument_Click(object sender, EventArgs e)
        {
            // Cast the sender as a picture box
            PictureBox pbx = sender as PictureBox;

            // Remove this document from the document paths list
            DocumentPaths.Remove((string)pbx.Tag);

            // Get the picture's container
            Control container = pbx.Parent;

            // Remove the deleted document container
            flpDocumentList.Controls.Remove(container);

            // Dispose of resources stored in container
            container.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (DocumentPaths.Count == 0)
            {
                lblError.ForeColor = Color.Crimson;
                lblError.Text = "No documents added";
            }

            // Submit the claim along with the documents and store the result
            bool? result = DBController.SubmitClaim(Session.UserAccount.ID, txtDetails.Text, DocumentPaths);

            // If upload was succesful
            if (result == true)
            {
                lblError.ForeColor = Color.ForestGreen;
                lblError.Text = "Claim submitted";

                txtDetails.Text = "";
            }
            // If upload failed for some data reason
            else if (result == false)
            {
                lblError.ForeColor = Color.Crimson;
                lblError.Text = "Unable to submit claim";
            }
            // If connection failed
            else
            {
                lblError.ForeColor = Color.Crimson;
                lblError.Text = "Database error";
            }
        }
    }
}
  
