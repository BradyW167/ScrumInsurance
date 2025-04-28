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
            this.flpMessageList = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCompose = new System.Windows.Forms.Button();
            this.rtxContents = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // flpMessageList
            // 
            this.flpMessageList.AutoScroll = true;
            this.flpMessageList.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flpMessageList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMessageList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMessageList.Location = new System.Drawing.Point(25, 25);
            this.flpMessageList.Margin = new System.Windows.Forms.Padding(0);
            this.flpMessageList.Name = "flpMessageList";
            this.flpMessageList.Padding = new System.Windows.Forms.Padding(25, 25, 25, 25);
            this.flpMessageList.Size = new System.Drawing.Size(280, 504);
            this.flpMessageList.TabIndex = 0;
            this.flpMessageList.WrapContents = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(330, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 557);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCompose
            // 
            this.btnCompose.BackColor = System.Drawing.Color.Azure;
            this.btnCompose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompose.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompose.Location = new System.Drawing.Point(25, 541);
            this.btnCompose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(279, 40);
            this.btnCompose.TabIndex = 122;
            this.btnCompose.Text = "Compose Message";
            this.btnCompose.UseVisualStyleBackColor = false;
            this.btnCompose.Click += new System.EventHandler(this.btnCompose_Click);
            // 
            // rtxContents
            // 
            this.rtxContents.BackColor = System.Drawing.Color.Azure;
            this.rtxContents.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxContents.Location = new System.Drawing.Point(349, 165);
            this.rtxContents.Margin = new System.Windows.Forms.Padding(0);
            this.rtxContents.Name = "rtxContents";
            this.rtxContents.ReadOnly = true;
            this.rtxContents.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxContents.Size = new System.Drawing.Size(689, 360);
            this.rtxContents.TabIndex = 123;
            this.rtxContents.Text = "";
            // 
            // ctrlInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.rtxContents);
            this.Controls.Add(this.btnCompose);
            this.Controls.Add(this.flpMessageList);
            this.Controls.Add(this.lblContents);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblClaim);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlInbox";
            this.Size = new System.Drawing.Size(1080, 607);
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
        private System.Windows.Forms.FlowLayoutPanel flpMessageList;
        private System.Windows.Forms.Button btnCompose;
        private System.Windows.Forms.RichTextBox rtxContents;
    }
}
