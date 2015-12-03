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
    public partial class AdminPage : Form
    {
        public AdminPage()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login loginForm = new Login();
            loginForm.ShowDialog();

            this.Close();
        }

        private void btn_ViewLogs_Click(object sender, EventArgs e)
        {
            this.Hide();

            Logs logForm = new Logs();
            logForm.ShowDialog();

            this.Close();
        }

        private void btn_DoorLocks_Click(object sender, EventArgs e)
        {
            this.Hide();

            Doors doorForm = new Doors();
            doorForm.ShowDialog();

            this.Close();
        }

        private void btn_CardKeys_Click(object sender, EventArgs e)
        {
            this.Hide();

            CardKeys cardKeysForm = new CardKeys();
            cardKeysForm.ShowDialog();

            this.Close();
        }
    }
}
