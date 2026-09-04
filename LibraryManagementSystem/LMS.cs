using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.ViewerObjectModel;

namespace LibraryManagementSystem
{
    public partial class LMS : Form
    {
        //defining variables
        string username, usertype;

        //default constructor
        public LMS()
        {
            InitializeComponent();
        }

        //parameterized constructor
        public LMS(string un, string ut)
        {
            InitializeComponent();
            username = un;
            usertype = ut;
        }

        //logout menuitem logic
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        //exit menuitem logic
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.statusStrip.Text = "Welcome, " + username;
        }

        //add books menuitem logic
        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks book = new AddBooks();
            book.Show();
            this.Hide();
        }

        //view books menuitem logic 
        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooks book = new ViewBooks();
            book.Show();
            this.Hide();
        }

        //add authors menuitem logic
        private void addAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAuthors book = new AddAuthors();
            book.Show();
            this.Hide();
        }

        //book lending menuitem logic
        private void bookLendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookLending book = new BookLending();
            book.Show();
            this.Hide();
        }

        //book report menuitem logic
        private void bookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookReport bk = new BookReport();
            bk.Show();
            this.Hide();

        }

        //lending report menuitem logic
        private void lendingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LendingReport len = new LendingReport();
            len.Show();
            this.Hide();
        }

        //member lending report menuitem logic
        private void memberLendingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberLendingReport mem = new MemberLendingReport();
            mem.Show();
            this.Hide();
        }

        //loading form
        private void LMS_Load(object sender, EventArgs e)
        { 
            //welcome message display
            this.statusStrip.Text = "Welcome, " + username;

            //specifying user library management home page
            Login login = new Login();
            
            string user1 = "Admin";
            user1 = usertype;

            string user2 = "User";
            user2 = usertype;

            if (user1 == "Admin")
            {
                memberLendingReportToolStripMenuItem.Visible = false;
            }
            else if (user2 == "User")
            {

                addBooksToolStripMenuItem.Visible = false;
                addAuthorsToolStripMenuItem.Visible = false;
                bookLendingToolStripMenuItem.Visible = false;
                lendingReportToolStripMenuItem.Visible = false;
            }
        }
    }
}
