using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Org.BouncyCastle.Asn1.Cmp;

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlClaimsList : ScrumUserControl
    {
        private int ClaimCount {  get; set; }
        private int ClaimRowHeight { get; set; }

        public ctrlClaimsList(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();

            ClaimCount = 0;

            ClaimRowHeight = 100;

            List<Claim> claimList = DBController.GetClaimList(Session.UserAccount);

            foreach (Claim claim in claimList)
            {
                AddClaim(claim);
            }

            // Adds padding at bottom of scroll
            AddScrollPaddingSpacer();
        }

        // Adds a claim object to the claim panel with a label and a button
        private void AddClaim(Claim claim)
        {
            // Increment claim counter
            ClaimCount += 1;

            // Stores the horizontal padding size of the claim list panel
            int padding = flpClaimList.Padding.Left;

            // Create a container panel for this claim row
            Panel container = new Panel();
            container.Width = flpClaimList.Width - padding * 2;
            container.Height = ClaimRowHeight;
            container.BackColor = Color.Azure;
            container.BorderStyle = BorderStyle.FixedSingle;
            container.Location = new Point(0, (ClaimCount - 1) * ClaimRowHeight);
            container.Margin = new Padding(0, 0, 0, ClaimRowHeight / 4);

            // Create and style label for this claim
            Label msg = new Label();
            msg.BackColor = Color.Azure;
            msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            msg.Font = new Font("Microsoft Tai Le", 12, FontStyle.Regular);
            msg.Text = $"ID: {claim.ID.ToString()} \nStatus: {claim.Status.ToString()} \nDate: {claim.Date.ToString()}";
            msg.Width = flpClaimList.Width / 2;
            msg.Height = ClaimRowHeight;
            msg.Location = new Point(10, 0);

            // Create and style button for this claim
            Button btn = new Button();
            btn.BackColor = Color.Azure;
            btn.Font = new Font("Microsoft Tai Le", 12, FontStyle.Regular);
            btn.Text = "View";
            btn.FlatAppearance.BorderColor = Color.Azure;
            btn.FlatStyle = FlatStyle.Popup;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btn.Width = 80;
            btn.Height = 40;
            btn.Location = new Point(container.Width - btn.Width - 20, 35);
            btn.Tag = claim.ID; // Store claim id in this claim's button tag
            btn.Click += new System.EventHandler(this.btnMessageA_Click);

            // Add controls to the container panel
            container.Controls.Add(msg);
            container.Controls.Add(btn);

            // Add the container to the claim list panel
            flpClaimList.Controls.Add(container);

        }

        // Process clicks on claims
        private void btnMessageA_Click(object sender, EventArgs e)
        {
            // Store the sender object as a button
            Button btn = sender as Button;

            // Store the claim id as a long from the button's tag property
            long claim_id = long.Parse(btn.Tag.ToString());

            // Load the selected claim's info into the claim viewer control and swap to it
            SwapCtrlMain(new ctrlClaimViewer(this, claim_id));
        }

        private void AddScrollPaddingSpacer() 
        {
            Panel spacer = new Panel();

            // Sets size to the padding of the bottom panel
            spacer.Size = new Size(1, flpClaimList.Padding.Bottom);

            // Locates the spacer just after the last claim
            spacer.Location = new Point(0, ClaimCount * 150);
            spacer.BackColor = Color.Transparent;

            // Adds spacer to the panel
            flpClaimList.Controls.Add(spacer);
        }
    }
}
