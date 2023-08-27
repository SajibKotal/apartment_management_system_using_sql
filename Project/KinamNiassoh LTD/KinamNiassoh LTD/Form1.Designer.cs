namespace KinamNiassoh_LTD
{
    partial class Form1
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
            this.signup = new System.Windows.Forms.Button();
            this.signin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(729, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "KinamNiassoh LTD";
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.BackColor = System.Drawing.Color.Khaki;
            this.signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.Location = new System.Drawing.Point(974, 426);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(130, 57);
            this.signup.TabIndex = 1;
            this.signup.Text = "Signup";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // signin
            // 
            this.signin.AutoSize = true;
            this.signin.BackColor = System.Drawing.Color.ForestGreen;
            this.signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.Location = new System.Drawing.Point(805, 426);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(130, 57);
            this.signin.TabIndex = 2;
            this.signin.Text = "Signin";
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1144, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::KinamNiassoh_LTD.Properties.Resources.pexels_photo_2568906;
            this.ClientSize = new System.Drawing.Size(1434, 824);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button button1;

    }
}

