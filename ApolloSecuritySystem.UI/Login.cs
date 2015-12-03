using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApolloSecuritySystem.Properties;

namespace ApolloSecuritySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MaximumSize = new Size(1111, 712);
            this.MinimumSize = new Size(1111, 712);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public override sealed Size MinimumSize
        {
            get { return base.MinimumSize; }
            set { base.MinimumSize = value; }
        }

        public override sealed Size MaximumSize
        {
            get { return base.MaximumSize; }
            set { base.MaximumSize = value; }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (ValidateTextBoxes())
            {
                if (txtUserName.Text == Resources.Login_btn_Login_Click_admin &&
                    txtPassword.Text == Resources.Login_btn_Login_Click_admin)
                {
                    this.DialogResult = DialogResult.OK;

                    this.Hide();

                    AdminPage adminPage = new AdminPage();
                    adminPage.ShowDialog();

                    this.Close();
                }
                else
                {
                    //Authontication Failed
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show(Resources.Login_btn_Login_Click_Invalid_username_or_password);
                }
            }
        }

        private bool ValidateTextBoxes()
        {
            if (txtUserName.Text.Trim().Length == 0)
            {
                //errorUserName.SetError(txtUserName, "Please Enter User Name");

                MessageBox.Show(Resources.Login_btn_Login_Click_Invalid_username_or_password);
                return false;
            }
            else
            {
                errorUserName.SetError(txtUserName, "");
            }
            if (txtPassword.Text.Trim().Length == 0)
            {
                //errorPassword.SetError(txtPassword, "Please Enter the Password");

                MessageBox.Show(Resources.Login_btn_Login_Click_Invalid_username_or_password);
                return false;
            }
            else
            {
                errorPassword.SetError(txtPassword, "");
            }
            return true;
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(this, new EventArgs());
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(this, new EventArgs());
            }
        }
    }
}
