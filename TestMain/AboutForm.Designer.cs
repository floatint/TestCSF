namespace TestMain
{
    partial class AboutForm
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
            this.GitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // GitLinkLabel
            // 
            this.GitLinkLabel.AutoSize = true;
            this.GitLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitLinkLabel.Location = new System.Drawing.Point(271, 110);
            this.GitLinkLabel.Name = "GitLinkLabel";
            this.GitLinkLabel.Size = new System.Drawing.Size(91, 29);
            this.GitLinkLabel.TabIndex = 0;
            this.GitLinkLabel.TabStop = true;
            this.GitLinkLabel.Text = "GitHub";
            this.GitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 265);
            this.Controls.Add(this.GitLinkLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutForm";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel GitLinkLabel;
    }
}