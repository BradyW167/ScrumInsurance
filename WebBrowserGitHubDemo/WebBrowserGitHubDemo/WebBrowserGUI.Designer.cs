namespace WebBrowserGitHubDemo
{
    partial class WebBrowserGUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.wbrDisplay = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter URL:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(221, 58);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(353, 22);
            this.txtURL.TabIndex = 1;
            // 
            // btnGO
            // 
            this.btnGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGO.Location = new System.Drawing.Point(584, 50);
            this.btnGO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(100, 42);
            this.btnGO.TabIndex = 2;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // wbrDisplay
            // 
            this.wbrDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbrDisplay.Location = new System.Drawing.Point(-4, 92);
            this.wbrDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wbrDisplay.MinimumSize = new System.Drawing.Size(27, 25);
            this.wbrDisplay.Name = "wbrDisplay";
            this.wbrDisplay.Size = new System.Drawing.Size(959, 443);
            this.wbrDisplay.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(221, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WebBrowserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wbrDisplay);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WebBrowserGUI";
            this.Text = "Web Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.WebBrowser wbrDisplay;
        private System.Windows.Forms.Button button1;
    }
}

