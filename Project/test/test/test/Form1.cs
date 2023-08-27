using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            signin f2 = new signin();
            f2.ShowDialog();
            this.Close();
        }
    }
}
