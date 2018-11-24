using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects_Training
{
    public class CreatorX
    {
        private string firstName;
        private string lastName;
        private int customID;
        private int age;

        public CreatorX()
        {
            Random newRnd = new Random();
            customID = newRnd.Next(1, 1000000);
        }


        public string getFirstName 
        {
            get { return firstName; }
        }

        public string getLastName 
        {
            get { return lastName; }
        }

        public int getAge 
        {
            get { return age; }
        }

        public string setFirstName
        {
            get { return firstName; }
            set { firstName = value;}
        }

        public string setLastName 
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int getID 
        {
            get{return customID;}
        }

        public int setAge 
        {
            get { return age; }
            set { age = value; }
        }
    }
}
