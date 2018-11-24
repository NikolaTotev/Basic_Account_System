namespace Classes_Objects_Training
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
            this.SignInbtn = new System.Windows.Forms.Button();
            this.CreateAccountbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignInbtn
            // 
            this.SignInbtn.Location = new System.Drawing.Point(76, 162);
            this.SignInbtn.Name = "SignInbtn";
            this.SignInbtn.Size = new System.Drawing.Size(108, 27);
            this.SignInbtn.TabIndex = 0;
            this.SignInbtn.Text = "Sign In";
            this.SignInbtn.UseVisualStyleBackColor = true;
            this.SignInbtn.Click += new System.EventHandler(this.SignInbtn_Click);
            // 
            // CreateAccountbtn
            // 
            this.CreateAccountbtn.Location = new System.Drawing.Point(223, 162);
            this.CreateAccountbtn.Name = "CreateAccountbtn";
            this.CreateAccountbtn.Size = new System.Drawing.Size(108, 27);
            this.CreateAccountbtn.TabIndex = 1;
            this.CreateAccountbtn.Text = "Create Account";
            this.CreateAccountbtn.UseVisualStyleBackColor = true;
            this.CreateAccountbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 286);
            this.Controls.Add(this.CreateAccountbtn);
            this.Controls.Add(this.SignInbtn);
            this.Name = "Form1";
            this.Text = "Bank Data";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SignInbtn;
        private System.Windows.Forms.Button CreateAccountbtn;
    }
}

