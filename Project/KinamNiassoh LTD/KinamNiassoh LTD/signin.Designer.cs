namespace KinamNiassoh_LTD
{
    partial class signin1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.not = new System.Windows.Forms.Label();
            this.signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "....Signin....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Password :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your Email :";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(571, 379);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(325, 40);
            this.password.TabIndex = 3;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(571, 284);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(325, 40);
            this.email.TabIndex = 4;
            this.email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.LightGreen;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(766, 442);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(130, 57);
            this.login.TabIndex = 5;
            this.login.Text = "Signin";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(571, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // not
            // 
            this.not.AutoSize = true;
            this.not.Font = new System.Drawing.Font("Segoe Script", 11.2F);
            this.not.Location = new System.Drawing.Point(566, 526);
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(206, 30);
            this.not.TabIndex = 7;
            this.not.Text = "Not a member Yet !";
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.SystemColors.Window;
            this.signup.Font = new System.Drawing.Font("Segoe Script", 10.2F);
            this.signup.ForeColor = System.Drawing.Color.Blue;
            this.signup.Location = new System.Drawing.Point(766, 513);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(130, 57);
            this.signup.TabIndex = 8;
            this.signup.Text = "SignUp";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // signin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1434, 824);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.not);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "signin1";
            this.Text = "signin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label not;
        private System.Windows.Forms.Button signup;
    }
}