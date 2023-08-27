using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinamNiassoh_LTD
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void visitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();                                //go to Visitor page by click back
            Visitor f2 = new Visitor();              //Visitor is destination form name
            f2.ShowDialog();
            this.Close();

        }

        private void kinamNiassohLTDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ownerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();                                //go to Home page by click back
            Customer f2 = new Customer();              //customer is destination form name
            f2.ShowDialog();
            this.Close();
        }

        private void guardInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();                                //go to Security page by click security
            Security f2 = new Security();              //Security is destination form name
            f2.ShowDialog();
            this.Close();
        }

        private void ownerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();                                //go to Owner page by click security
            Owner f2 = new Owner();              //Owner is destination form name
            f2.ShowDialog();
            this.Close();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();                                //go to Manager page by click security
            Manager f2 = new Manager();              //Manager is destination form name
            f2.ShowDialog();
            this.Close();
        }

        private void buyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();                                //go to Manager page by click security
            Buyer f2 = new Buyer();              //Manager is destination form name
            f2.ShowDialog();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        
        
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();                                //go to Renter page by click security
            Renter f2 = new Renter();              //Renter is destination form name
            f2.ShowDialog();
            this.Close();
        }

        private void builderCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();                                //go to BuilderCompany page by click security
            BuilderCompany f2 = new BuilderCompany();              //BuilderCompany is destination form name
            f2.ShowDialog();
            this.Close();
        }
    }
}
