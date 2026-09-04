using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddBooks : Form
    {
        //connection to database
        string cs = @"Data Source = Sithumini\SQLEXPRESS; Initial Catalog=LibraryManagementSystem; Integrated Security=True";

        //default constructor
        public AddBooks()
        {
            InitializeComponent();
        }

        //save button logic
        private void btnSave_Click(object sender, EventArgs e)
        {
            //creating validations
            if (this.txtBookID.Text == "" || this.txtISBN.Text == "" || this.cmbCategory.Text == "" || this.txtName.Text == "" || this.cmbAuthor.Text == "")
            {
                MessageBox.Show("Fields cannot be empty. Please fill the fields.");
            }
            else 
            {
                //connect to database
                SqlConnection connection = new SqlConnection(cs);
                connection.Open();

                //command
                string sql = "INSERT INTO tblBooks(BookID, ISBN, Category, Name, Author) VALUES(@bid, @isbn, @cat, @name, @author)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@bid", this.txtBookID.Text);
                command.Parameters.AddWithValue("@isbn", this.txtISBN.Text);
                command.Parameters.AddWithValue("@cat", this.cmbCategory.Text);
                command.Parameters.AddWithValue("@name", this.txtName.Text);
                command.Parameters.AddWithValue("@author", this.cmbAuthor.Text);

                //execute SQL
                command.ExecuteNonQuery();
                MessageBox.Show("Successful added book.");

                //disconnect SQL
                connection.Close();
            }
        }

        //close button logic
        private void btnClose_Click(object sender, EventArgs e)
        {
            LMS library = new LMS();
            library.Show();
            this.Hide();
        }

        //loading form
        private void AddBooks_Load(object sender, EventArgs e)
        {
            //connect to database
            SqlConnection connection = new SqlConnection(cs);
            connection.Open();

            //command
            string sql = "SELECT max(BookID) FROM tblBooks";
            SqlCommand command = new SqlCommand(sql, connection);

            //access data using data reader]
            string bid = "";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                string str = reader.GetValue(0).ToString();
                int id = Convert.ToInt32(str.Substring(1));
                id++;
                if (id < 10)
                {
                    bid = "B00" + id;
                }
                else if (id < 100)
                {
                    bid = "B0" + id;
                }
                else
                {
                    bid = "B" + id;
                }
            }
            else
            {
                bid = "B001";
            }

            this.txtBookID.Text = bid;

            //disconnect
            connection.Close();
        }
    }
}
