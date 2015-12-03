using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ApolloSecuritySystem
{
    public partial class ViewLogs : Form
    {
        public ViewLogs()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MaximumSize = new Size(1111, 712);
            this.MinimumSize = new Size(1111, 712);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BindDataGridView();
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

        private void ViewLogs_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();

            Logs logsForm = new Logs();
            logsForm.ShowDialog();

            this.Close();
        }

        private void BindDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
            new DataColumn("Room No", typeof(string)),
            new DataColumn("Date",typeof(string)),
            new DataColumn("Time", typeof(string)),
            new DataColumn("Cardkey Number",typeof(string)) });

            dt.Rows.Add(1, "G01", "12/11/2015", "10:00am", "S112");
            dt.Rows.Add(2, "G02", "12/11/2015", "10:30am", "S113");
            dt.Rows.Add(3, "G03", "12/11/2015", "10:45am", "S114");
            dt.Rows.Add(4, "G04", "12/11/2015", "12:00pm", "S115");
            dt.Rows.Add(5, "G01", "12/11/2015", "01:00pm", "S112");
            dt.Rows.Add(6, "G01", "13/11/2015", "10:00am", "S112");
            dt.Rows.Add(7, "G02", "13/11/2015", "11:00am", "S113");
            dt.Rows.Add(8, "G03", "13/11/2015", "11:30am", "S114");

            this.dataGridView1.DataSource = dt;
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminPage adminForm = new AdminPage();
            adminForm.ShowDialog();

            this.Close();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login loginForm = new Login();
            loginForm.ShowDialog();

            this.Close();
        }

        private void exportData(object sender, EventArgs e)
        {
            //Build the CSV file data as a Comma separated string.
            string csv = string.Empty;

            //Add the Header row for CSV file.
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                csv += column.HeaderText + ',';
            }

            //Add new line.
            csv += "\r\n";

            //Adding the Rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //Add the Data rows.
                    csv += cell.Value.ToString().Replace(",", ";") + ',';
                }

                //Add new line.
                csv += "\r\n";
            }

            //Exporting to CSV.
            string folderPath = "C:\\CSV\\";
            File.WriteAllText(folderPath + "DataGridViewExport.csv", csv);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportData(sender, e);
        }
    }
}
