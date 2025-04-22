namespace ScrumInsurance.Ctrls
{
    partial class ctrlInbox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMessages = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSender = new System.Windows.Forms.Label();
            this.lblClaim = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblContents = new System.Windows.Forms.Label();
            this.pnlMessageContents = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(330, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 557);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMessages
            // 
            this.pnlMessages.AutoScroll = true;
            this.pnlMessages.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessages.Location = new System.Drawing.Point(25, 25);
            this.pnlMessages.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(280, 557);
            this.pnlMessages.TabIndex = 115;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHeader.Location = new System.Drawing.Point(345, 55);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(170, 26);
            this.lblHeader.TabIndex = 116;
            this.lblHeader.Text = "Message Subject";
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblSender.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic);
            this.lblSender.Location = new System.Drawing.Point(346, 85);
            this.lblSender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(66, 21);
            this.lblSender.TabIndex = 117;
            this.lblSender.Text = "Sender: ";
            // 
            // lblClaim
            // 
            this.lblClaim.AutoSize = true;
            this.lblClaim.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaim.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic);
            this.lblClaim.Location = new System.Drawing.Point(346, 110);
            this.lblClaim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaim.Name = "lblClaim";
            this.lblClaim.Size = new System.Drawing.Size(76, 21);
            this.lblClaim.TabIndex = 118;
            this.lblClaim.Text = "Claim ID: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic);
            this.lblDate.Location = new System.Drawing.Point(936, 59);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(94, 21);
            this.lblDate.TabIndex = 119;
            this.lblDate.Text = "12/12/2024";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblContents
            // 
            this.lblContents.AutoSize = true;
            this.lblContents.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblContents.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic);
            this.lblContents.Location = new System.Drawing.Point(346, 135);
            this.lblContents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(79, 21);
            this.lblContents.TabIndex = 120;
            this.lblContents.Text = "Contents: ";
            // 
            // pnlMessageContents
            // 
            this.pnlMessageContents.AutoScroll = true;
            this.pnlMessageContents.BackColor = System.Drawing.Color.Azure;
            this.pnlMessageContents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessageContents.Location = new System.Drawing.Point(355, 182);
            this.pnlMessageContents.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMessageContents.Name = "pnlMessageContents";
            this.pnlMessageContents.Size = new System.Drawing.Size(675, 375);
            this.pnlMessageContents.TabIndex = 121;
            // 
            // ctrlInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.pnlMessageContents);
            this.Controls.Add(this.lblContents);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblClaim);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlMessages);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlInbox";
            this.Size = new System.Drawing.Size(1080, 607);
            this.Load += new System.EventHandler(this.ctrlInbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMessages;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblClaim;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblContents;
        private System.Windows.Forms.Panel pnlMessageContents;
    }
}
