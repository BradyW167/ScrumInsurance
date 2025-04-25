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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSender = new System.Windows.Forms.Label();
            this.lblClaim = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblContents = new System.Windows.Forms.Label();
            this.pnlMessageContents = new System.Windows.Forms.Panel();
            this.flpMessageList = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCompose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHeader.Location = new System.Drawing.Point(518, 85);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(252, 39);
            this.lblHeader.TabIndex = 116;
            this.lblHeader.Text = "Message Subject";
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblSender.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic);
            this.lblSender.Location = new System.Drawing.Point(519, 131);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(100, 30);
            this.lblSender.TabIndex = 117;
            this.lblSender.Text = "Sender: ";
            // 
            // lblClaim
            // 
            this.lblClaim.AutoSize = true;
            this.lblClaim.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaim.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic);
            this.lblClaim.Location = new System.Drawing.Point(519, 169);
            this.lblClaim.Name = "lblClaim";
            this.lblClaim.Size = new System.Drawing.Size(115, 30);
            this.lblClaim.TabIndex = 118;
            this.lblClaim.Text = "Claim ID: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic);
            this.lblDate.Location = new System.Drawing.Point(1404, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(135, 30);
            this.lblDate.TabIndex = 119;
            this.lblDate.Text = "12/12/2024";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblContents
            // 
            this.lblContents.AutoSize = true;
            this.lblContents.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblContents.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic);
            this.lblContents.Location = new System.Drawing.Point(519, 208);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(121, 30);
            this.lblContents.TabIndex = 120;
            this.lblContents.Text = "Contents: ";
            // 
            // pnlMessageContents
            // 
            this.pnlMessageContents.AutoScroll = true;
            this.pnlMessageContents.BackColor = System.Drawing.Color.Azure;
            this.pnlMessageContents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessageContents.Location = new System.Drawing.Point(532, 280);
            this.pnlMessageContents.Name = "pnlMessageContents";
            this.pnlMessageContents.Size = new System.Drawing.Size(1012, 576);
            this.pnlMessageContents.TabIndex = 121;
            // 
            // flpMessageList
            // 
            this.flpMessageList.AutoScroll = true;
            this.flpMessageList.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flpMessageList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMessageList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMessageList.Location = new System.Drawing.Point(38, 38);
            this.flpMessageList.Margin = new System.Windows.Forms.Padding(0);
            this.flpMessageList.Name = "flpMessageList";
            this.flpMessageList.Padding = new System.Windows.Forms.Padding(38, 38, 38, 38);
            this.flpMessageList.Size = new System.Drawing.Size(419, 774);
            this.flpMessageList.TabIndex = 0;
            this.flpMessageList.WrapContents = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(495, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1086, 856);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCompose
            // 
            this.btnCompose.BackColor = System.Drawing.Color.Azure;
            this.btnCompose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompose.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompose.Location = new System.Drawing.Point(38, 833);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(419, 61);
            this.btnCompose.TabIndex = 122;
            this.btnCompose.Text = "Compose Message";
            this.btnCompose.UseVisualStyleBackColor = false;
            this.btnCompose.Click += new System.EventHandler(this.btnCompose_Click);
            // 
            // ctrlInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btnCompose);
            this.Controls.Add(this.flpMessageList);
            this.Controls.Add(this.pnlMessageContents);
            this.Controls.Add(this.lblContents);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblClaim);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlInbox";
            this.Size = new System.Drawing.Size(1620, 934);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblClaim;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblContents;
        private System.Windows.Forms.Panel pnlMessageContents;
        private System.Windows.Forms.FlowLayoutPanel flpMessageList;
        private System.Windows.Forms.Button btnCompose;
    }
}
