using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ViewBooks : Form
    {
        //connection to database
        string cs = @"Data Source = Sithumini\SQLEXPRESS; Initial Catalog=LibraryManagementSystem; Integrated Security=True";

        //default constructor
        public ViewBooks()
        {
            InitializeComponent();
        }

        //view button logic
        private void btnView_Click(object sender, EventArgs e)
        {
            //connect to database
            SqlConnection connection = new SqlConnection(cs);
            connection.Open();

            //command
            string sql = "SELECT * FROM tblBooks";
            SqlCommand command = new SqlCommand(sql, connection);

            //access data using data adapter
            SqlDataAdapter dap = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];

            //disconnect
            connection.Close();
        }

        //close button logic
        private void btnClose_Click(object sender, EventArgs e)
        {
            LMS library = new LMS();
            library.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
