namespace WindowsFormsApp1
{
    partial class GoogleDriveManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleDriveManager));
            this.listView1 = new System.Windows.Forms.ListView();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.ChangeAccount = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Menu;
            this.listView1.Location = new System.Drawing.Point(8, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(456, 258);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(12, 77);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(304, 32);
            this.DownloadButton.TabIndex = 4;
            this.DownloadButton.Text = "Download File";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // ChangeAccount
            // 
            this.ChangeAccount.BackColor = System.Drawing.Color.Transparent;
            this.ChangeAccount.Location = new System.Drawing.Point(167, 24);
            this.ChangeAccount.Name = "ChangeAccount";
            this.ChangeAccount.Size = new System.Drawing.Size(149, 35);
            this.ChangeAccount.TabIndex = 2;
            this.ChangeAccount.Text = "ChangeAccount";
            this.ChangeAccount.UseVisualStyleBackColor = false;
            this.ChangeAccount.Click += new System.EventHandler(this.ChangeAccount_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(12, 24);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(149, 35);
            this.Refresh.TabIndex = 0;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(340, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 125);
            this.panel1.TabIndex = 5;
            // 
            // GoogleDriveManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 392);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.ChangeAccount);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GoogleDriveManager";
            this.Text = "Google Drive Manager";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button ChangeAccount;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Panel panel1;
    }
}