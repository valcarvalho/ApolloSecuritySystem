using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApolloSecuritySystem
{
    public partial class CardKeys : Form
    {
        public CardKeys()
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

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login loginForm = new Login();
            loginForm.ShowDialog();

            this.Close();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminPage adminForm = new AdminPage();
            adminForm.ShowDialog();

            this.Close();
        }
    }
}
