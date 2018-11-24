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
    public partial class LogIn : Form
    {
        public static LogIn logInInstance;
       

        AccountDataBase newAccountdatabase;
        public LogIn()
        {
            if (logInInstance != null) 
            {
                return;
            }

            logInInstance = this;

            newAccountdatabase = AccountDataBase.dataBaseInstance;
            InitializeComponent();
        }

        /// <summary>
        /// Call this function when directing to login page.
        /// </summary>
        /// <param name="existingDatabase"></param>
      
        /// <summary>
        /// Send credentials to be checked by the AccesDataBase function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            int userID = Convert.ToInt32(txtBoxID.Text);
            string userFirstName = clientFirstName.Text;
            string userLastName = clientLastName.Text;

            newAccountdatabase.AccessDataBase(userID, userFirstName, userLastName);
        }

      

        public void ChangeToClientProfile(int age, string firstName, string lastName) 
        {
            loginPanel.Visible = false;
            clientPanel.Visible = true;

            c_Age.Text = age.ToString();
            c_FirstName.Text = firstName;
            c_LastName.Text = lastName;
        }
    }
}
