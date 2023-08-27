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
    public partial class Security : Form
    {
                                                //database server connection in variable conString
        public string conString = "Data Source=KINAM-NIASSOH\\SQLEXPRESS;Initial Catalog=Apartment;Integrated Security=True";
        public Security()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void displaybutton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This code only for diasplaing table  on data grid 
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM security_employee", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1
                SecurityEmployee.DataSource = dtbl;            //SecurityEmployee is the data gride name where data are displayed


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();                                //go to Dashboard page by click back
            Dashboard f2 = new Dashboard();
            f2.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                        //DISPLAY VARIABLE
        public void display_grid()
        {
            //This code only for diasplaing table  on data grid 
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM security_employee", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1
                datagrid1.DataSource = dtbl;            //datagrid1 is the data gride name where data are displayed


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string query = "INSERT INTO security_employee VALUES ('" + sid.Text.Trim() + "', '" + sname.Text.Trim() + "', '" + email.Text.Trim() + "', '" + address.Text.Trim() + "' , '" + salary.Text.Trim() + "', '" + phone.Text.Trim() + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            display_grid();
            MessageBox.Show("Successfully Added");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string query = "UPDATE security_employee SET name='" + sname.Text.Trim() + "',  email='" + email.Text.Trim() + "' , address='" + address.Text.Trim() + "' , salary='" + salary.Text.Trim() + "' , phone='" + phone.Text.Trim() + "'  WHERE Sec_id='" + sid.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            display_grid();
            MessageBox.Show("Successfully Updated");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string query = "DELETE FROM security_employee WHERE Sec_id='" + sid.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            display_grid();
            MessageBox.Show("Successfully Deleted");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void datagrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Security_Load(object sender, EventArgs e)
        {
            display_grid();
        }
    }
}
