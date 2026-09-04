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
    public partial class BookLending : Form
    {
        //connection to database
        string cs = @"Data Source = Sithumini\SQLEXPRESS; Initial Catalog=LibraryManagementSystem; Integrated Security=True";

        //default constructor
        public BookLending()
        {
            InitializeComponent();
        }

        //save button logic
        private void btnSave_Click(object sender, EventArgs e)
        {
            //creating validations
            if (this.txtTxnID.Text == "" || this.date.Text == "" || this.txtMemberName.Text == "" || this.cmbBookName.Text == "" || this.returnDate.Text == "")
            {
                MessageBox.Show("Fields cannot be empty. Please fill the fields.");
            }
            else
            {
                //connect to database
                SqlConnection connection = new SqlConnection(cs);
                connection.Open();

                //command
                string sql = "INSERT INTO tblLendBooks(TxnID, Date, MemberName, BookName, ReturnDate) VALUES(@tid, @date, @memname, @bname, @retdate)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@tid", this.txtTxnID.Text);
                command.Parameters.AddWithValue("@date", this.date.Text);
                command.Parameters.AddWithValue("@memname", this.txtMemberName.Text);
                command.Parameters.AddWithValue("@bname", this.cmbBookName.Text);
                command.Parameters.AddWithValue("@retdate", this.returnDate.Text);

                //execute SQL
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully lended book.");

                //disconnect SQL
                connection.Close();
            }
        }

        //loading form
        private void BookLending_Load(object sender, EventArgs e)
        {
            //connect to database
            SqlConnection connection = new SqlConnection(cs);
            connection.Open();

            //command
            string sql = "SELECT max(TxnID) FROM tblLendingBooks";
            SqlCommand command = new SqlCommand(sql, connection);

            //access data using data reader]
            string tid = "";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                string str = reader.GetValue(0).ToString();
                int id = Convert.ToInt32(str.Substring(1));
                id++;
                if (id < 10)
                {
                    tid = "T00" + id;
                }
                else if (id < 100)
                {
                    tid = "T0" + id;
                }
                else
                {
                    tid = "T" + id;
                }
            }
            else
            {
                tid = "T001";
            }

            this.txtTxnID.Text = tid;

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
    }
}
