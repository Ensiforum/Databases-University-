using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab1
{
    public partial class QueryEdit : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-C216EJ4;Initial Catalog=BiologistHandbook;Integrated Security=True";
        public QueryEdit()
        {
            InitializeComponent();
        }

        private void doSqlButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(testInput.Text, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView.DataSource = dt;
                sqlconn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(@"Error" + ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            testInput.Clear();
            testInput.Text = "SELECT";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
