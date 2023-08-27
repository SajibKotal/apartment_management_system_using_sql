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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
                                                        //database server connection in variable conString
        public string conString = "Data Source=KINAM-NIASSOH\\SQLEXPRESS;Initial Catalog=Apartment;Integrated Security=True";
        
        private void signup1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string query = "INSERT INTO Login VALUES ('"+email.Text.Trim()+"', '"+password.Text.Trim()+"')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MessageBox.Show("SignUp Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();                                //go to Home page by click back
            Form1 f2 = new Form1();
            f2.ShowDialog();
            this.Close();
        }
    }
}
