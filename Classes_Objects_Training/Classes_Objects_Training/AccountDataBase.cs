using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects_Training
{
    public class AccountDataBase
    {

        #region singleton
        public static AccountDataBase dataBaseInstance;
        

        public AccountDataBase() 
        {
            if (dataBaseInstance != null) 
            {
                return;
            }
            dataBaseInstance = this;

          //  currentLogin = LogIn.logInInstance;
        }

        #endregion

        public List<CreatorX> Accounts = new List<CreatorX>();
        public List<int> accountID = new List<int>();

        /// <summary>
        /// Adds the account and account ID to a list of ID's and accounts
        /// </summary>
        /// <param name="newAcc"></param>
        /// <param name="accID"></param>
        public void AddToDataBase(CreatorX newAcc, int accID) 
        {
            Accounts.Add(newAcc);
            accountID.Add(accID);
        }

        /// <summary>
        /// Checks if the data provided by the user is correct, if it is correct it calls a private function that retruns the client data.
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="clientFirstName"></param>
        /// <param name="clientLastName"></param>
        public void AccessDataBase(int clientID, string clientFirstName, string clientLastName) 
        {

            foreach (CreatorX accountElement in Accounts)
            {
                if (accountElement.getFirstName == clientFirstName & accountElement.getLastName == clientLastName)
                {
                    int accountPos = Accounts.IndexOf(accountElement);
                    int ID = accountID[accountPos];

                    if (ID == clientID)
                    {
                        GiveAccountData(accountElement.getAge, clientFirstName, clientLastName);
                    }
                }

                else 
                {
                    // Send some sort of message along the lines of "Credentials are incorrect".
                }
            }
        }

        /// <summary>
        /// Returns client data only if called by the functions that checks the credentials
        /// </summary>
        private void GiveAccountData( int age, string firstName, string lastName) 
        {
           
            LogIn.logInInstance.ChangeToClientProfile(age, firstName, lastName);
        }

        
    }
}
