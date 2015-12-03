namespace ApolloSecuritySystem
{
    partial class ViewLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLogs));
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_right = new System.Windows.Forms.Label();
            this.lbl_left = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_adminPage = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Admin
            // 
            this.btn_Admin.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.Location = new System.Drawing.Point(864, 152);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(97, 41);
            this.btn_Admin.TabIndex = 16;
            this.btn_Admin.Text = "AdminPage";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(960, 152);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(97, 41);
            this.btn_Logout.TabIndex = 15;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_right
            // 
            this.lbl_right.AutoSize = true;
            this.lbl_right.Image = ((System.Drawing.Image)(resources.GetObject("lbl_right.Image")));
            this.lbl_right.Location = new System.Drawing.Point(967, 35);
            this.lbl_right.MinimumSize = new System.Drawing.Size(90, 90);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(90, 90);
            this.lbl_right.TabIndex = 14;
            // 
            // lbl_left
            // 
            this.lbl_left.AutoSize = true;
            this.lbl_left.Image = ((System.Drawing.Image)(resources.GetObject("lbl_left.Image")));
            this.lbl_left.Location = new System.Drawing.Point(39, 35);
            this.lbl_left.MinimumSize = new System.Drawing.Size(90, 90);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new System.Drawing.Size(90, 90);
            this.lbl_left.TabIndex = 13;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(135, 55);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(826, 49);
            this.lbl_title.TabIndex = 12;
            this.lbl_title.Text = "Welcome to Apollo Door Security System (ADSS)";
            // 
            // lbl_adminPage
            // 
            this.lbl_adminPage.AutoSize = true;
            this.lbl_adminPage.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminPage.Location = new System.Drawing.Point(481, 208);
            this.lbl_adminPage.Name = "lbl_adminPage";
            this.lbl_adminPage.Size = new System.Drawing.Size(128, 33);
            this.lbl_adminPage.TabIndex = 17;
            this.lbl_adminPage.Text = "View Logs";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(41, 152);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(97, 41);
            this.btn_Back.TabIndex = 18;
            this.btn_Back.Text = "<< BACK";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 297);
            this.dataGridView1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1095, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_adminPage);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_right);
            this.Controls.Add(this.lbl_left);
            this.Controls.Add(this.lbl_title);
            this.Name = "ViewLogs";
            this.Text = "ViewLogs";
            this.Load += new System.EventHandler(this.ViewLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_right;
        private System.Windows.Forms.Label lbl_left;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_adminPage;
        private System.Windows.Forms.Button btn_Back;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}