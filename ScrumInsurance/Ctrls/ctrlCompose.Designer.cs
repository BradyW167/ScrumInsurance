namespace ScrumInsurance.Ctrls
{
    partial class ctrlCompose
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblContents = new System.Windows.Forms.Label();
            this.flpMessageList = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtContents = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblErrorList = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHeader.Location = new System.Drawing.Point(517, 48);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(277, 39);
            this.lblHeader.TabIndex = 116;
            this.lblHeader.Text = "Compose Message";
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblRecipient.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic);
            this.lblRecipient.Location = new System.Drawing.Point(519, 91);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(113, 30);
            this.lblRecipient.TabIndex = 117;
            this.lblRecipient.Text = "Send To: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic);
            this.lblDate.Location = new System.Drawing.Point(1421, 55);
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
            this.lblContents.Location = new System.Drawing.Point(519, 133);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(121, 30);
            this.lblContents.TabIndex = 120;
            this.lblContents.Text = "Contents: ";
            // 
            // flpMessageList
            // 
            this.flpMessageList.AutoScroll = true;
            this.flpMessageList.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flpMessageList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMessageList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMessageList.Location = new System.Drawing.Point(38, 133);
            this.flpMessageList.Margin = new System.Windows.Forms.Padding(0);
            this.flpMessageList.Name = "flpMessageList";
            this.flpMessageList.Padding = new System.Windows.Forms.Padding(38);
            this.flpMessageList.Size = new System.Drawing.Size(419, 761);
            this.flpMessageList.TabIndex = 0;
            this.flpMessageList.WrapContents = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(76, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(343, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(76, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(343, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search User";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtContents
            // 
            this.txtContents.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContents.Location = new System.Drawing.Point(524, 216);
            this.txtContents.Name = "txtContents";
            this.txtContents.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtContents.Size = new System.Drawing.Size(1032, 552);
            this.txtContents.TabIndex = 121;
            this.txtContents.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox2.Location = new System.Drawing.Point(38, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(419, 139);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Azure;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(1353, 791);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(203, 80);
            this.btnSend.TabIndex = 122;
            this.btnSend.Text = "Send Message";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblErrorList
            // 
            this.lblErrorList.AutoSize = true;
            this.lblErrorList.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblErrorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorList.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorList.Location = new System.Drawing.Point(863, 815);
            this.lblErrorList.Name = "lblErrorList";
            this.lblErrorList.Size = new System.Drawing.Size(309, 29);
            this.lblErrorList.TabIndex = 123;
            this.lblErrorList.Text = "**HIDDEN ON INITIALIZE**";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic);
            this.lblSubject.Location = new System.Drawing.Point(519, 174);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(104, 30);
            this.lblSubject.TabIndex = 124;
            this.lblSubject.Text = "Subject: ";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(629, 177);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(320, 26);
            this.txtSubject.TabIndex = 125;
            // 
            // ctrlCompose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblErrorList);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtContents);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.flpMessageList);
            this.Controls.Add(this.lblContents);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblRecipient);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlCompose";
            this.Size = new System.Drawing.Size(1620, 934);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblContents;
        private System.Windows.Forms.FlowLayoutPanel flpMessageList;
        private System.Windows.Forms.RichTextBox txtContents;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblErrorList;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
    }
}
