namespace ScrumInsurance.Ctrls
{
    partial class ctrlClaimViewer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblClaimDateValue = new System.Windows.Forms.Label();
            this.lblClaimDate = new System.Windows.Forms.Label();
            this.rtxDetails = new System.Windows.Forms.RichTextBox();
            this.lblClientNameValue = new System.Windows.Forms.Label();
            this.lblClaimAmountValue = new System.Windows.Forms.Label();
            this.lblClaimStatusValue = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClaimStatus = new System.Windows.Forms.Label();
            this.lblClaimAmount = new System.Windows.Forms.Label();
            this.btnClientProfile = new System.Windows.Forms.Button();
            this.btnViewDocs = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.lblClaimViewer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errClaim = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSetAmount = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmountError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errClaim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Azure;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReturn.Location = new System.Drawing.Point(206, 455);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 33);
            this.btnReturn.TabIndex = 117;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblClaimDateValue
            // 
            this.lblClaimDateValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaimDateValue.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblClaimDateValue.ForeColor = System.Drawing.Color.Black;
            this.lblClaimDateValue.Location = new System.Drawing.Point(760, 141);
            this.lblClaimDateValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblClaimDateValue.Name = "lblClaimDateValue";
            this.lblClaimDateValue.Size = new System.Drawing.Size(110, 21);
            this.lblClaimDateValue.TabIndex = 116;
            this.lblClaimDateValue.Text = "1/12/25";
            this.lblClaimDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClaimDate
            // 
            this.lblClaimDate.AutoSize = true;
            this.lblClaimDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaimDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblClaimDate.Location = new System.Drawing.Point(660, 140);
            this.lblClaimDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaimDate.Name = "lblClaimDate";
            this.lblClaimDate.Size = new System.Drawing.Size(102, 20);
            this.lblClaimDate.TabIndex = 115;
            this.lblClaimDate.Text = "Claim Date:";
            // 
            // rtxDetails
            // 
            this.rtxDetails.BackColor = System.Drawing.Color.Azure;
            this.rtxDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.rtxDetails.Location = new System.Drawing.Point(402, 224);
            this.rtxDetails.Margin = new System.Windows.Forms.Padding(0);
            this.rtxDetails.Name = "rtxDetails";
            this.rtxDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxDetails.Size = new System.Drawing.Size(472, 213);
            this.rtxDetails.TabIndex = 16;
            this.rtxDetails.Text = "Here is some default text. This will be filled with the user given claim details." +
    " This cannot be edited by the CManager and is simply here to display text while " +
    "having a scroll option. ";
            // 
            // lblClientNameValue
            // 
            this.lblClientNameValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClientNameValue.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblClientNameValue.ForeColor = System.Drawing.Color.Black;
            this.lblClientNameValue.Location = new System.Drawing.Point(508, 141);
            this.lblClientNameValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblClientNameValue.Name = "lblClientNameValue";
            this.lblClientNameValue.Size = new System.Drawing.Size(140, 21);
            this.lblClientNameValue.TabIndex = 15;
            this.lblClientNameValue.Text = "John Smith";
            this.lblClientNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClaimAmountValue
            // 
            this.lblClaimAmountValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaimAmountValue.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblClaimAmountValue.ForeColor = System.Drawing.Color.Black;
            this.lblClaimAmountValue.Location = new System.Drawing.Point(758, 181);
            this.lblClaimAmountValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblClaimAmountValue.Name = "lblClaimAmountValue";
            this.lblClaimAmountValue.Size = new System.Drawing.Size(110, 21);
            this.lblClaimAmountValue.TabIndex = 14;
            this.lblClaimAmountValue.Text = "$100,000,000";
            this.lblClaimAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClaimStatusValue
            // 
            this.lblClaimStatusValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaimStatusValue.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblClaimStatusValue.ForeColor = System.Drawing.Color.Olive;
            this.lblClaimStatusValue.Location = new System.Drawing.Point(508, 181);
            this.lblClaimStatusValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblClaimStatusValue.Name = "lblClaimStatusValue";
            this.lblClaimStatusValue.Size = new System.Drawing.Size(116, 21);
            this.lblClaimStatusValue.TabIndex = 13;
            this.lblClaimStatusValue.Text = "Pending";
            this.lblClaimStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblClientName.Location = new System.Drawing.Point(399, 140);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(111, 20);
            this.lblClientName.TabIndex = 12;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblClaimStatus
            // 
            this.lblClaimStatus.AutoSize = true;
            this.lblClaimStatus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaimStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblClaimStatus.Location = new System.Drawing.Point(399, 180);
            this.lblClaimStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaimStatus.Name = "lblClaimStatus";
            this.lblClaimStatus.Size = new System.Drawing.Size(116, 20);
            this.lblClaimStatus.TabIndex = 9;
            this.lblClaimStatus.Text = "Claim Status:";
            this.lblClaimStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClaimAmount
            // 
            this.lblClaimAmount.AutoSize = true;
            this.lblClaimAmount.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaimAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblClaimAmount.Location = new System.Drawing.Point(637, 180);
            this.lblClaimAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaimAmount.Name = "lblClaimAmount";
            this.lblClaimAmount.Size = new System.Drawing.Size(125, 20);
            this.lblClaimAmount.TabIndex = 8;
            this.lblClaimAmount.Text = "Claim Amount:";
            this.lblClaimAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClientProfile
            // 
            this.btnClientProfile.BackColor = System.Drawing.Color.Azure;
            this.btnClientProfile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClientProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientProfile.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.btnClientProfile.Location = new System.Drawing.Point(206, 164);
            this.btnClientProfile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnClientProfile.Name = "btnClientProfile";
            this.btnClientProfile.Size = new System.Drawing.Size(165, 33);
            this.btnClientProfile.TabIndex = 6;
            this.btnClientProfile.Text = "Client Profile";
            this.btnClientProfile.UseVisualStyleBackColor = false;
            this.btnClientProfile.Click += new System.EventHandler(this.btnClientProfile_Click);
            // 
            // btnViewDocs
            // 
            this.btnViewDocs.BackColor = System.Drawing.Color.Azure;
            this.btnViewDocs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDocs.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.btnViewDocs.Location = new System.Drawing.Point(206, 119);
            this.btnViewDocs.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnViewDocs.Name = "btnViewDocs";
            this.btnViewDocs.Size = new System.Drawing.Size(165, 33);
            this.btnViewDocs.TabIndex = 5;
            this.btnViewDocs.Text = "View Documents";
            this.btnViewDocs.UseVisualStyleBackColor = false;
            this.btnViewDocs.Click += new System.EventHandler(this.btnViewDocs_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Azure;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnApprove.Location = new System.Drawing.Point(665, 455);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(99, 33);
            this.btnApprove.TabIndex = 3;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Azure;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReject.Location = new System.Drawing.Point(775, 455);
            this.btnReject.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(99, 33);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // lblClaimViewer
            // 
            this.lblClaimViewer.AutoSize = true;
            this.lblClaimViewer.BackColor = System.Drawing.Color.Transparent;
            this.lblClaimViewer.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblClaimViewer.Location = new System.Drawing.Point(185, 76);
            this.lblClaimViewer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaimViewer.Name = "lblClaimViewer";
            this.lblClaimViewer.Size = new System.Drawing.Size(136, 26);
            this.lblClaimViewer.TabIndex = 0;
            this.lblClaimViewer.Text = "Claim Viewer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(190, 103);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 400);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // errClaim
            // 
            this.errClaim.ContainerControl = this;
            // 
            // btnSetAmount
            // 
            this.btnSetAmount.BackColor = System.Drawing.Color.Azure;
            this.btnSetAmount.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSetAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.btnSetAmount.Location = new System.Drawing.Point(206, 300);
            this.btnSetAmount.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSetAmount.Name = "btnSetAmount";
            this.btnSetAmount.Size = new System.Drawing.Size(165, 33);
            this.btnSetAmount.TabIndex = 118;
            this.btnSetAmount.Text = "Set Amount";
            this.btnSetAmount.UseVisualStyleBackColor = false;
            this.btnSetAmount.Visible = false;
            this.btnSetAmount.Click += new System.EventHandler(this.btnSetAmount_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAmount.Location = new System.Drawing.Point(206, 265);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(165, 23);
            this.txtAmount.TabIndex = 119;
            this.txtAmount.Visible = false;
            // 
            // lblAmountError
            // 
            this.lblAmountError.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblAmountError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountError.ForeColor = System.Drawing.Color.Red;
            this.lblAmountError.Location = new System.Drawing.Point(240, 336);
            this.lblAmountError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountError.Name = "lblAmountError";
            this.lblAmountError.Size = new System.Drawing.Size(100, 13);
            this.lblAmountError.TabIndex = 120;
            this.lblAmountError.Text = "Clear on Start";
            this.lblAmountError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAmountError.Visible = false;
            // 
            // ctrlClaimViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.lblAmountError);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnSetAmount);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblClaimDateValue);
            this.Controls.Add(this.lblClaimDate);
            this.Controls.Add(this.rtxDetails);
            this.Controls.Add(this.lblClientNameValue);
            this.Controls.Add(this.lblClaimAmountValue);
            this.Controls.Add(this.lblClaimStatusValue);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblClaimStatus);
            this.Controls.Add(this.lblClaimAmount);
            this.Controls.Add(this.btnClientProfile);
            this.Controls.Add(this.btnViewDocs);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.lblClaimViewer);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlClaimViewer";
            this.Size = new System.Drawing.Size(1080, 607);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errClaim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaimViewer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnViewDocs;
        private System.Windows.Forms.Button btnClientProfile;
        private System.Windows.Forms.Label lblClaimAmount;
        private System.Windows.Forms.Label lblClaimStatus;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClaimStatusValue;
        private System.Windows.Forms.Label lblClaimAmountValue;
        private System.Windows.Forms.Label lblClientNameValue;
        private System.Windows.Forms.RichTextBox rtxDetails;
        private System.Windows.Forms.Label lblClaimDateValue;
        private System.Windows.Forms.Label lblClaimDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ErrorProvider errClaim;
        private System.Windows.Forms.Button btnSetAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmountError;
    }
}
