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
    public partial class AddAuthors : Form
    {
        //connection to database
        string cs = @"Data Source = Sithumini\SQLEXPRESS; Initial Catalog=LibraryManagementSystem; Integrated Security=True";

        //default constructor
        public AddAuthors()
        {
            InitializeComponent();
        }

        //save button logic
        private void btnSave_Click(object sender, EventArgs e)
        {

            //creating validations
            if (this.txtAID.Text == "" || this.txtAuthorName.Text == "" || this.txtEmail.Text == "")
            {
                MessageBox.Show("Fields cannot be empty. Please fill the fields.");
            }
            else
            {
                //connect to database
                SqlConnection connection = new SqlConnection(cs);
                connection.Open();

                //command
                string sql = "INSERT INTO tblAuthors(AuthorID, Name, Email) VALUES(@aid, @name, @email)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@aid", this.txtAID.Text);
                command.Parameters.AddWithValue("@name", this.txtAuthorName.Text);
                command.Parameters.AddWithValue("@email", this.txtEmail.Text);

                //execute SQL
                command.ExecuteNonQuery();
                MessageBox.Show("Successful added author.");

                //disconnect SQL
                connection.Close();
            }
        }

        //loading form
        private void AddAuthors_Load(object sender, EventArgs e)
        {
            //connect to database
            SqlConnection connection = new SqlConnection(cs);
            connection.Open();

            //command
            string sql = "SELECT max(AuthorID) FROM tblAuthors";
            SqlCommand command = new SqlCommand(sql, connection);

            //access data using data reader]
            string aid = "";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                string str = reader.GetValue(0).ToString();
                int id = Convert.ToInt32(str.Substring(1));
                id++;
                if (id < 10)
                {
                    aid = "A00" + id;
                }
                else if (id < 100)
                {
                    aid = "A0" + id;
                }
                else
                {
                    aid = "A" + id;
                }
            }
            else
            {
                aid = "A001";
            }

            this.txtAID.Text = aid;

            //disconnect
            connection.Close();
        }
    }
}
