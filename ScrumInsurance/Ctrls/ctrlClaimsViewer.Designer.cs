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
            this.lblClaimViewer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnViewDocs = new System.Windows.Forms.Button();
            this.btnCProfile = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblClaimAmount = new System.Windows.Forms.Label();
            this.lblClaimStatus = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblStatusType = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.rtxtDetails = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClaimViewer
            // 
            this.lblClaimViewer.AutoSize = true;
            this.lblClaimViewer.BackColor = System.Drawing.Color.Transparent;
            this.lblClaimViewer.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblClaimViewer.Location = new System.Drawing.Point(42, 31);
            this.lblClaimViewer.Name = "lblClaimViewer";
            this.lblClaimViewer.Size = new System.Drawing.Size(220, 39);
            this.lblClaimViewer.TabIndex = 0;
            this.lblClaimViewer.Text = "Viewing Claim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(40, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 511);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Azure;
            this.btnReject.Location = new System.Drawing.Point(446, 514);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(90, 35);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Azure;
            this.btnApprove.Location = new System.Drawing.Point(350, 514);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(90, 35);
            this.btnApprove.TabIndex = 3;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            // 
            // btnViewDocs
            // 
            this.btnViewDocs.BackColor = System.Drawing.Color.Azure;
            this.btnViewDocs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDocs.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDocs.Location = new System.Drawing.Point(63, 94);
            this.btnViewDocs.Name = "btnViewDocs";
            this.btnViewDocs.Size = new System.Drawing.Size(100, 80);
            this.btnViewDocs.TabIndex = 5;
            this.btnViewDocs.Text = "View Documents";
            this.btnViewDocs.UseVisualStyleBackColor = false;
            // 
            // btnCProfile
            // 
            this.btnCProfile.BackColor = System.Drawing.Color.Azure;
            this.btnCProfile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCProfile.Font = new System.Drawing.Font("Microsoft Tai Le", 7F);
            this.btnCProfile.Location = new System.Drawing.Point(63, 409);
            this.btnCProfile.Name = "btnCProfile";
            this.btnCProfile.Size = new System.Drawing.Size(100, 38);
            this.btnCProfile.TabIndex = 6;
            this.btnCProfile.Text = "View Profile";
            this.btnCProfile.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Azure;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(63, 180);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 80);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Create Report";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // lblClaimAmount
            // 
            this.lblClaimAmount.AutoSize = true;
            this.lblClaimAmount.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaimAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimAmount.Location = new System.Drawing.Point(180, 94);
            this.lblClaimAmount.Name = "lblClaimAmount";
            this.lblClaimAmount.Size = new System.Drawing.Size(160, 25);
            this.lblClaimAmount.TabIndex = 8;
            this.lblClaimAmount.Text = "Claim Amount: ";
            // 
            // lblClaimStatus
            // 
            this.lblClaimStatus.AutoSize = true;
            this.lblClaimStatus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaimStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimStatus.Location = new System.Drawing.Point(180, 132);
            this.lblClaimStatus.Name = "lblClaimStatus";
            this.lblClaimStatus.Size = new System.Drawing.Size(142, 25);
            this.lblClaimStatus.TabIndex = 9;
            this.lblClaimStatus.Text = "Claim Status:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(180, 169);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(146, 25);
            this.lblDetails.TabIndex = 10;
            this.lblDetails.Text = "Claim Details:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Azure;
            this.btnTransfer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(63, 268);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(100, 80);
            this.btnTransfer.TabIndex = 11;
            this.btnTransfer.Text = "Transfer To Finance Manager";
            this.btnTransfer.UseVisualStyleBackColor = false;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(180, 416);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(143, 25);
            this.lblClientName.TabIndex = 12;
            this.lblClientName.Text = "Client Name: ";
            // 
            // lblStatusType
            // 
            this.lblStatusType.AutoSize = true;
            this.lblStatusType.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblStatusType.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusType.ForeColor = System.Drawing.Color.Olive;
            this.lblStatusType.Location = new System.Drawing.Point(382, 133);
            this.lblStatusType.Name = "lblStatusType";
            this.lblStatusType.Size = new System.Drawing.Size(84, 25);
            this.lblStatusType.TabIndex = 13;
            this.lblStatusType.Text = "Pending";
            this.lblStatusType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(396, 94);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(60, 25);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "$0.00";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(320, 416);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 25);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "John Smith";
            // 
            // rtxtDetails
            // 
            this.rtxtDetails.BackColor = System.Drawing.Color.Azure;
            this.rtxtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDetails.Location = new System.Drawing.Point(185, 197);
            this.rtxtDetails.Name = "rtxtDetails";
            this.rtxtDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtDetails.Size = new System.Drawing.Size(351, 196);
            this.rtxtDetails.TabIndex = 16;
            this.rtxtDetails.Text = "Here is some default text. This will be filled with the user given claim details." +
    " This cannot be edited by the CManager and is simply here to display text while " +
    "having a scroll option. ";
            // 
            // ctrlClaimViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.rtxtDetails);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblStatusType);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblClaimStatus);
            this.Controls.Add(this.lblClaimAmount);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnCProfile);
            this.Controls.Add(this.btnViewDocs);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.lblClaimViewer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrlClaimViewer";
            this.Size = new System.Drawing.Size(600, 600);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaimViewer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnViewDocs;
        private System.Windows.Forms.Button btnCProfile;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblClaimAmount;
        private System.Windows.Forms.Label lblClaimStatus;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblStatusType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox rtxtDetails;
    }
}
