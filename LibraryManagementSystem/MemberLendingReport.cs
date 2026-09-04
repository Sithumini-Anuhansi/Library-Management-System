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
    public partial class MemberLendingReport : Form
    {
        //connection to database
        string cs = @"Data Source = Sithumini\SQLEXPRESS; Initial Catalog=LibraryManagementSystem; Integrated Security=True";

        //default constructor
        public MemberLendingReport()
        {
            InitializeComponent();
        }

        //loading form
        private void MemberLendingReport_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = @"C:\Users\sithu\OneDrive\Desktop\GUI\LibraryManagementSystem\LibraryManagementSystem\MemberLendingCrystalReport.rpt";
        }

        //search button logic
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //connection
            SqlConnection connect = new SqlConnection(cs);
            connect.Open();

            //command
            string sql = "SELECT * FROM tblLendBooks WHERE MemberName=@memname";
            SqlCommand command = new SqlCommand(sql, connect);
            command.Parameters.AddWithValue("@memname", this.txtMemName.Text);

            //access data using data adapter method 
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            //bind data with crystal report
            LendingCrystalReport rpt1 = new LendingCrystalReport();
            rpt1.Load(@"Data Source = Sithumini\SQLEXPRESS; Initial Catalog=LibraryManagementSystem; Integrated Security=True");
            rpt1.SetDataSource(ds.Tables[0]);
            this.crystalReportViewer1.ReportSource = rpt1;

            //close connection
            connect.Close();
        }
    }
}
