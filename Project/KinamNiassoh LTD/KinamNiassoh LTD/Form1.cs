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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void signin_Click(object sender, EventArgs e)
        {
            this.Hide();                                  //go to signin1 page by click signin
            signin1 f2 = new signin1();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();                                  // close this form
        }
    }
}
