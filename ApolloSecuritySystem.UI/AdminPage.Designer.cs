namespace ApolloSecuritySystem
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.lbl_right = new System.Windows.Forms.Label();
            this.lbl_left = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_ViewLogs = new System.Windows.Forms.Button();
            this.btn_DoorLocks = new System.Windows.Forms.Button();
            this.btn_CardKeys = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_adminPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_right
            // 
            this.lbl_right.AutoSize = true;
            this.lbl_right.Image = ((System.Drawing.Image)(resources.GetObject("lbl_right.Image")));
            this.lbl_right.Location = new System.Drawing.Point(967, 25);
            this.lbl_right.MinimumSize = new System.Drawing.Size(90, 90);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(90, 90);
            this.lbl_right.TabIndex = 5;
            // 
            // lbl_left
            // 
            this.lbl_left.AutoSize = true;
            this.lbl_left.Image = ((System.Drawing.Image)(resources.GetObject("lbl_left.Image")));
            this.lbl_left.Location = new System.Drawing.Point(39, 25);
            this.lbl_left.MinimumSize = new System.Drawing.Size(90, 90);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new System.Drawing.Size(90, 90);
            this.lbl_left.TabIndex = 4;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(135, 45);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(826, 49);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Welcome to Apollo Door Security System (ADSS)";
            // 
            // btn_ViewLogs
            // 
            this.btn_ViewLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ViewLogs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewLogs.Location = new System.Drawing.Point(377, 250);
            this.btn_ViewLogs.Name = "btn_ViewLogs";
            this.btn_ViewLogs.Size = new System.Drawing.Size(312, 80);
            this.btn_ViewLogs.TabIndex = 6;
            this.btn_ViewLogs.Text = "Print / View Logs";
            this.btn_ViewLogs.UseVisualStyleBackColor = true;
            this.btn_ViewLogs.Click += new System.EventHandler(this.btn_ViewLogs_Click);
            // 
            // btn_DoorLocks
            // 
            this.btn_DoorLocks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoorLocks.Location = new System.Drawing.Point(377, 354);
            this.btn_DoorLocks.Name = "btn_DoorLocks";
            this.btn_DoorLocks.Size = new System.Drawing.Size(312, 78);
            this.btn_DoorLocks.TabIndex = 7;
            this.btn_DoorLocks.Text = "Add / Remove Door Locks";
            this.btn_DoorLocks.UseVisualStyleBackColor = true;
            this.btn_DoorLocks.Click += new System.EventHandler(this.btn_DoorLocks_Click);
            // 
            // btn_CardKeys
            // 
            this.btn_CardKeys.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CardKeys.Location = new System.Drawing.Point(377, 456);
            this.btn_CardKeys.Name = "btn_CardKeys";
            this.btn_CardKeys.Size = new System.Drawing.Size(312, 77);
            this.btn_CardKeys.TabIndex = 8;
            this.btn_CardKeys.Text = "Maintain Card Keys";
            this.btn_CardKeys.UseVisualStyleBackColor = true;
            this.btn_CardKeys.Click += new System.EventHandler(this.btn_CardKeys_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(960, 143);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(97, 41);
            this.btn_Logout.TabIndex = 9;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_adminPage
            // 
            this.lbl_adminPage.AutoSize = true;
            this.lbl_adminPage.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminPage.Location = new System.Drawing.Point(387, 151);
            this.lbl_adminPage.Name = "lbl_adminPage";
            this.lbl_adminPage.Size = new System.Drawing.Size(289, 33);
            this.lbl_adminPage.TabIndex = 10;
            this.lbl_adminPage.Text = "Welcome to Admin Page";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1095, 673);
            this.Controls.Add(this.lbl_adminPage);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_CardKeys);
            this.Controls.Add(this.btn_DoorLocks);
            this.Controls.Add(this.btn_ViewLogs);
            this.Controls.Add(this.lbl_right);
            this.Controls.Add(this.lbl_left);
            this.Controls.Add(this.lbl_title);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_right;
        private System.Windows.Forms.Label lbl_left;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_ViewLogs;
        private System.Windows.Forms.Button btn_DoorLocks;
        private System.Windows.Forms.Button btn_CardKeys;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_adminPage;
    }
}