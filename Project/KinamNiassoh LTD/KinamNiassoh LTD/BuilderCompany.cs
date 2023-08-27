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
    public partial class BuilderCompany : Form
    {                   //database server connection in variable conString
        public string conString = "Data Source=KINAM-NIASSOH\\SQLEXPRESS;Initial Catalog=Apartment;Integrated Security=True";

        public BuilderCompany()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();                                //go to Dashboard page by click back
            Dashboard f2 = new Dashboard();
            f2.ShowDialog();
            this.Close();
        }

        private void BuilderCompany_Load(object sender, EventArgs e)
        {
            //This code only for diasplaing table  on data grid 
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM buildercompany", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1
                datagrid1.DataSource = dtbl;            //datagrid1 is the data gride name where data are displayed

            }
        }
    }
}
