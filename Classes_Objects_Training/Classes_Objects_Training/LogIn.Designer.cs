namespace Classes_Objects_Training
{
    partial class LogIn
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
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientFirstName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clientLastName = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.clientPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.c_FirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.c_LastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.c_Age = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.clientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(77, 67);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(99, 20);
            this.txtBoxID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // clientFirstName
            // 
            this.clientFirstName.Location = new System.Drawing.Point(77, 8);
            this.clientFirstName.Name = "clientFirstName";
            this.clientFirstName.Size = new System.Drawing.Size(99, 20);
            this.clientFirstName.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(44, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 44);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // clientLastName
            // 
            this.clientLastName.Location = new System.Drawing.Point(77, 34);
            this.clientLastName.Name = "clientLastName";
            this.clientLastName.Size = new System.Drawing.Size(99, 20);
            this.clientLastName.TabIndex = 6;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.clientLastName);
            this.loginPanel.Controls.Add(this.btnLogin);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.clientFirstName);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.txtBoxID);
            this.loginPanel.Location = new System.Drawing.Point(17, 30);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(198, 199);
            this.loginPanel.TabIndex = 8;
            // 
            // clientPanel
            // 
            this.clientPanel.Controls.Add(this.label6);
            this.clientPanel.Controls.Add(this.c_Age);
            this.clientPanel.Controls.Add(this.label4);
            this.clientPanel.Controls.Add(this.c_LastName);
            this.clientPanel.Controls.Add(this.label5);
            this.clientPanel.Controls.Add(this.c_FirstName);
            this.clientPanel.Location = new System.Drawing.Point(221, 30);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(198, 199);
            this.clientPanel.TabIndex = 9;
            this.clientPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Name";
            // 
            // c_FirstName
            // 
            this.c_FirstName.Location = new System.Drawing.Point(77, 8);
            this.c_FirstName.Name = "c_FirstName";
            this.c_FirstName.Size = new System.Drawing.Size(99, 20);
            this.c_FirstName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name";
            // 
            // c_LastName
            // 
            this.c_LastName.Location = new System.Drawing.Point(77, 37);
            this.c_LastName.Name = "c_LastName";
            this.c_LastName.Size = new System.Drawing.Size(99, 20);
            this.c_LastName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Age";
            // 
            // c_Age
            // 
            this.c_Age.Location = new System.Drawing.Point(77, 70);
            this.c_Age.Name = "c_Age";
            this.c_Age.Size = new System.Drawing.Size(99, 20);
            this.c_Age.TabIndex = 7;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 250);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.loginPanel);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientFirstName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientLastName;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox c_FirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox c_Age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox c_LastName;
    }
}