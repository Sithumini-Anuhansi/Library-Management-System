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
    public partial class Login : Form
    {
        //connection to database
        string cs = @"Data Source = Sithumini\SQLEXPRESS; Initial Catalog=LibraryManagementSystem; Integrated Security=True";
        
        //default constructor
        public Login()
        {
            InitializeComponent();
        }

        //login button logic
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //creating validations
            if (this.txtUsername.Text == "" || this.txtPassword.Text == "" || this.cmbUserType.Text == "")
            {
                MessageBox.Show("Fields cannot be empty. Please fill the fields.");
            }

            else
            { 
                //connect to database
                SqlConnection connection = new SqlConnection(cs);
                connection.Open();

                //command
                string sql = "SELECT * FROM tblUser WHERE UserName=@un AND Password=@pw AND UserType=@ut";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@un", this.txtUsername.Text);
                command.Parameters.AddWithValue("@pw", this.txtPassword.Text);
                command.Parameters.AddWithValue("@ut", this.cmbUserType.Text);

                //access data using data reader
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read() == true)
                {
                    LMS library = new LMS(this.txtUsername.Text, this.cmbUserType.Text);
                    library.Show();
                    this.Hide();

                    MessageBox.Show("Login Successful!");
                }
                else
                {
                    MessageBox.Show("Invalid username/password/usertype. Please re-enter the relevant fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //close button logic
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
