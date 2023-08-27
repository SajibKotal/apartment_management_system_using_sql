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
    public partial class signin1 : Form
    {
        public signin1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
                                                        //database server connection in variable conString
        public string conString ="Data Source=KINAM-NIASSOH\\SQLEXPRESS;Initial Catalog=Apartment;Integrated Security=True";
       
        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string query = "SELECT COUNT (*) FROM Login where Email='" + email.Text.Trim() + "' and Password ='" + password.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
                                                        //msgbox show (dt.rows.count.tostrng);
            if (dt.Rows[0][0].ToString() == "1")
            {
                //this.Hide();
                Dashboard ss = new Dashboard();         //Dashboard is the name of next link up form
                ss.Show();
                //this.Close();
                    
            }
            else
            {
                MessageBox.Show("Plese Insert the correct Email & Password Or SignUp");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();                                //go to Home page by click back
            Form1 f2 = new Form1();
            f2.ShowDialog();
            this.Close();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            this.Hide();                                  //go to Signup page by click signup
            Signup f2 = new Signup();
            f2.ShowDialog();
            this.Close();
        }
    }
}
