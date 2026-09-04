using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookReport : Form
    {
        //connection to database
        string cs = @"Data Source = Sithumini\SQLEXPRESS; Initial Catalog=LibraryManagementSystem; Integrated Security=True";

        //default constructor
        public BookReport()
        {
            InitializeComponent();
        }

        //loading form
        private void BookReport_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = @"C:\Users\sithu\OneDrive\Desktop\GUI\LibraryManagementSystem\LibraryManagementSystem\BookCrystalReport.rpt";
        }
    }
}
