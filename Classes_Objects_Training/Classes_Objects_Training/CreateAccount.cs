using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Objects_Training
{
    public partial class CreateAccount : Form
    {
        public static CreateAccount createAccountInstance;
        
     
        AccountDataBase newDataBase;

        public CreateAccount()
       {
           if (createAccountInstance != null) 
           {
               return;
           }
           createAccountInstance = this;

           newDataBase = new AccountDataBase();
           currentLogin = new LogIn();
           InitializeComponent();
        }

        LogIn currentLogin;

        /// <summary>
        /// Creates a new account based on the CreatorX class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccCreate_Click(object sender, EventArgs e)
        {
            CreatorX newAccount = new CreatorX();
            newAccount.setFirstName = txtFirstName.Text;
            newAccount.setLastName = txtLastName.Text;
            newAccount.setAge = Convert.ToInt32(txtAge.Text);
            showID.Text = newAccount.getID.ToString();
            newDataBase.AddToDataBase(newAccount, newAccount.getID);
        }

        private void gotToLogin_Click(object sender, EventArgs e)
        {
            currentLogin.Show();
            this.Hide();
        }
    }
}
