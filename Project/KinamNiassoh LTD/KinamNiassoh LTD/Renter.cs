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
    public partial class Renter : Form
    {                                                      //database server connection in variable conString
        public string conString = "Data Source=KINAM-NIASSOH\\SQLEXPRESS;Initial Catalog=Apartment;Integrated Security=True";
        
        public Renter()
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM renter", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1
                datagrid1.DataSource = dtbl;            //datagrid1 is the data gride name where data are displayed


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string query = "INSERT INTO renter VALUES ('" + rid.Text.Trim() + "', '" + rname.Text.Trim() + "', '" + email.Text.Trim() + "', '" + phone.Text.Trim() + "', '" + address.Text.Trim() + "', '" + income.Text.Trim() + "', '" + occupation.Text.Trim() + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            display_grid();
            MessageBox.Show("Successfully Added");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string query = "UPDATE renter SET name='" + rname.Text.Trim() + "',  email='" + email.Text.Trim() + "' , phone='" + phone.Text.Trim() + "', address='" + address.Text.Trim() + "', income='" + income.Text.Trim() + "',  occupation='" + occupation.Text.Trim() + "'  WHERE Rent_id='" + rid.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            display_grid();
            MessageBox.Show("Successfully Updated");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string query = "DELETE FROM renter WHERE Rent_id='" + rid.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            display_grid();
            MessageBox.Show("Successfully Deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();                                //go to Dashboard page by click back
            Dashboard f2 = new Dashboard();
            f2.ShowDialog();
            this.Close();
        }

        private void Renter_Load(object sender, EventArgs e)
        {
            display_grid();
        }
    }
}
