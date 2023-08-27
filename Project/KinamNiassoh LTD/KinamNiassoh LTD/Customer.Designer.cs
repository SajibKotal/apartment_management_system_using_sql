namespace KinamNiassoh_LTD
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.displaybutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customers = new System.Windows.Forms.DataGridView();
            this.customer1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.datagrid1 = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.TextBox();
            this.cname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customers)).BeginInit();
            this.customer1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.customers);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1426, 875);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.displaybutton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1423, 97);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "To display Customer\'s Information Just Click on Show Button";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1131, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // displaybutton
            // 
            this.displaybutton.BackColor = System.Drawing.Color.Aquamarine;
            this.displaybutton.Location = new System.Drawing.Point(984, 27);
            this.displaybutton.Name = "displaybutton";
            this.displaybutton.Size = new System.Drawing.Size(130, 57);
            this.displaybutton.TabIndex = 1;
            this.displaybutton.Text = "Show";
            this.displaybutton.UseVisualStyleBackColor = false;
            this.displaybutton.Click += new System.EventHandler(this.displaybutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(1267, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Signout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customers
            // 
            this.customers.BackgroundColor = System.Drawing.Color.Beige;
            this.customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customers.Location = new System.Drawing.Point(82, 65);
            this.customers.Name = "customers";
            this.customers.RowTemplate.Height = 24;
            this.customers.Size = new System.Drawing.Size(1368, 656);
            this.customers.TabIndex = 0;
            this.customers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customers_CellContentClick);
            // 
            // customer1
            // 
            this.customer1.Controls.Add(this.tabPage2);
            this.customer1.Controls.Add(this.tabPage3);
            this.customer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customer1.Location = new System.Drawing.Point(0, 0);
            this.customer1.Name = "customer1";
            this.customer1.Padding = new System.Drawing.Point(10, 10);
            this.customer1.SelectedIndex = 0;
            this.customer1.Size = new System.Drawing.Size(1434, 767);
            this.customer1.TabIndex = 0;
            this.customer1.SelectedIndexChanged += new System.EventHandler(this.customer1_SelectedIndexChanged_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.datagrid1);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.address);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.email);
            this.tabPage3.Controls.Add(this.phone);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cid);
            this.tabPage3.Controls.Add(this.cname);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 48);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1426, 715);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Add New Customer";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click_1);
            // 
            // datagrid1
            // 
            this.datagrid1.BackgroundColor = System.Drawing.Color.Beige;
            this.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid1.Location = new System.Drawing.Point(684, 168);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.RowTemplate.Height = 24;
            this.datagrid1.Size = new System.Drawing.Size(736, 539);
            this.datagrid1.TabIndex = 48;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.Color.Tomato;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(507, 644);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 57);
            this.button8.TabIndex = 45;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Khaki;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(345, 644);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 57);
            this.button4.TabIndex = 44;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(89, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 44);
            this.label2.TabIndex = 17;
            this.label2.Text = ".....Add  New Customer.....";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(27, 586);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(610, 40);
            this.address.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Address :";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(178, 644);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 57);
            this.button3.TabIndex = 18;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(27, 395);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(610, 40);
            this.email.TabIndex = 26;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(27, 490);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(610, 40);
            this.phone.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phone :";
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(27, 198);
            this.cid.Multiline = true;
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(610, 40);
            this.cid.TabIndex = 22;
            // 
            // cname
            // 
            this.cname.Location = new System.Drawing.Point(27, 293);
            this.cname.Multiline = true;
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(610, 40);
            this.cname.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Customer ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Customer Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::KinamNiassoh_LTD.Properties.Resources.pexels_photo_25689062;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 766);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1434, 767);
            this.Controls.Add(this.customer1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customers)).EndInit();
            this.customer1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button displaybutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView customers;
        private System.Windows.Forms.TabControl customer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView datagrid1;


    }
}