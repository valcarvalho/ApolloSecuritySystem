namespace ApolloSecuritySystem
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_left = new System.Windows.Forms.Label();
            this.lbl_right = new System.Windows.Forms.Label();
            this.grp_loginBox = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.errorUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_loginBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(131, 55);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(826, 49);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Welcome to Apollo Door Security System (ADSS)";
            // 
            // lbl_left
            // 
            this.lbl_left.AutoSize = true;
            this.lbl_left.Image = ((System.Drawing.Image)(resources.GetObject("lbl_left.Image")));
            this.lbl_left.Location = new System.Drawing.Point(35, 35);
            this.lbl_left.MinimumSize = new System.Drawing.Size(90, 90);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new System.Drawing.Size(90, 90);
            this.lbl_left.TabIndex = 1;
            // 
            // lbl_right
            // 
            this.lbl_right.AutoSize = true;
            this.lbl_right.Image = ((System.Drawing.Image)(resources.GetObject("lbl_right.Image")));
            this.lbl_right.Location = new System.Drawing.Point(963, 35);
            this.lbl_right.MinimumSize = new System.Drawing.Size(90, 90);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(90, 90);
            this.lbl_right.TabIndex = 2;
            // 
            // grp_loginBox
            // 
            this.grp_loginBox.Controls.Add(this.txtPassword);
            this.grp_loginBox.Controls.Add(this.txtUserName);
            this.grp_loginBox.Controls.Add(this.lbl_login);
            this.grp_loginBox.Controls.Add(this.btn_Login);
            this.grp_loginBox.Controls.Add(this.lbl_Password);
            this.grp_loginBox.Controls.Add(this.lbl_Username);
            this.grp_loginBox.Location = new System.Drawing.Point(359, 259);
            this.grp_loginBox.Name = "grp_loginBox";
            this.grp_loginBox.Size = new System.Drawing.Size(359, 230);
            this.grp_loginBox.TabIndex = 3;
            this.grp_loginBox.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(156, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(130, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(157, 92);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(130, 20);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(94, 22);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(154, 33);
            this.lbl_login.TabIndex = 3;
            this.lbl_login.Text = "Admin Login";
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(181, 169);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(105, 41);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(64, 126);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(91, 23);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(59, 92);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(96, 23);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username:";
            // 
            // errorUserName
            // 
            this.errorUserName.ContainerControl = this;
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1095, 673);
            this.Controls.Add(this.grp_loginBox);
            this.Controls.Add(this.lbl_right);
            this.Controls.Add(this.lbl_left);
            this.Controls.Add(this.lbl_title);
            this.Name = "Login";
            this.Text = "Form1";
            this.grp_loginBox.ResumeLayout(false);
            this.grp_loginBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_left;
        private System.Windows.Forms.Label lbl_right;
        private System.Windows.Forms.GroupBox grp_loginBox;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.ErrorProvider errorUserName;
        private System.Windows.Forms.ErrorProvider errorPassword;
    }
}

