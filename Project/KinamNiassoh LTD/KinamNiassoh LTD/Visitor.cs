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

namespace KinamNiassoh_LTD
{
    public partial class Visitor : Form
    {                                       //database server connection in variable conString
        public string conString = "Data Source=KINAM-NIASSOH\\SQLEXPRESS;Initial Catalog=Apartment;Integrated Security=True";
        public Visitor()
        {
            InitializeComponent();
        }
                    //DISPLAY VARIABLE
        public void display_grid()
        {
                     //This code only for diasplaing table  on data grid 
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM visitor", sqlCon); //visitor is data base table name 
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1
                datagrid1.DataSource = dtbl;           //datagrid1 is the data gride name where data are displayed


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);      //conString is the name of database
            string query = "INSERT INTO visitor VALUES ('" + vid.Text.Trim() + "', '" + vname.Text.Trim() + "', '" + cin.Text.Trim() + "', '" + cout.Text.Trim() + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            display_grid();
            MessageBox.Show("Successfully Added");
        }

        private void Visitor_Load(object sender, EventArgs e)
        {
            display_grid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string query = "UPDATE visitor SET name='" + vname.Text.Trim() + "',  check_in='" + cin.Text.Trim() + "' , check_out='" + cout.Text.Trim() + "'  WHERE v_id='" + vid.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            display_grid();
            MessageBox.Show("Successfully Updated");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string query = "UPDATE visitor SET check_out='" + cout.Text.Trim() + "'  WHERE v_id='" + cvid.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            display_grid();
            MessageBox.Show("Successfully Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();                                //go to Dashboard page by click back
            Dashboard f2 = new Dashboard();
            f2.ShowDialog();
            this.Close();
        }
    }
}
