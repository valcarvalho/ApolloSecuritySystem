namespace ApolloSecuritySystem
{
    partial class CardKeys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardKeys));
            this.lbl_right = new System.Windows.Forms.Label();
            this.lbl_left = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.lbl_adminPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_right
            // 
            this.lbl_right.AutoSize = true;
            this.lbl_right.Image = ((System.Drawing.Image)(resources.GetObject("lbl_right.Image")));
            this.lbl_right.Location = new System.Drawing.Point(966, 31);
            this.lbl_right.MinimumSize = new System.Drawing.Size(90, 90);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(90, 90);
            this.lbl_right.TabIndex = 5;
            // 
            // lbl_left
            // 
            this.lbl_left.AutoSize = true;
            this.lbl_left.Image = ((System.Drawing.Image)(resources.GetObject("lbl_left.Image")));
            this.lbl_left.Location = new System.Drawing.Point(38, 31);
            this.lbl_left.MinimumSize = new System.Drawing.Size(90, 90);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new System.Drawing.Size(90, 90);
            this.lbl_left.TabIndex = 4;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(134, 51);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(826, 49);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Welcome to Apollo Door Security System (ADSS)";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(959, 145);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(97, 41);
            this.btn_Logout.TabIndex = 10;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.Location = new System.Drawing.Point(863, 145);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(97, 41);
            this.btn_Admin.TabIndex = 12;
            this.btn_Admin.Text = "AdminPage";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // lbl_adminPage
            // 
            this.lbl_adminPage.AutoSize = true;
            this.lbl_adminPage.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminPage.Location = new System.Drawing.Point(438, 153);
            this.lbl_adminPage.Name = "lbl_adminPage";
            this.lbl_adminPage.Size = new System.Drawing.Size(232, 33);
            this.lbl_adminPage.TabIndex = 14;
            this.lbl_adminPage.Text = "Maintain Card Keys";
            // 
            // CardKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1095, 673);
            this.Controls.Add(this.lbl_adminPage);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_right);
            this.Controls.Add(this.lbl_left);
            this.Controls.Add(this.lbl_title);
            this.Name = "CardKeys";
            this.Text = "CardKeys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_right;
        private System.Windows.Forms.Label lbl_left;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Label lbl_adminPage;
    }
}