using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLab2
{
    public class person
    {
        private DateTime dateTime;
        private string personTestName;
        private string socNumber;

       public person(string personTestName, DateTime dateTime)
        {
            // TODO: Complete member initialization
            this.personTestName = personTestName;
            this.dateTime = dateTime;
        }

       public person(string p1, DateTime dateTime, string p2)
       {
           // TODO: Complete member initialization
           this.personTestName = p1;
           this.dateTime = dateTime;
           this.socNumber = p2;
       }

        public string Name
        {
            get { return personTestName; }

            set { value = "John Doe"; }

        }

        public DateTime birthday
        {
            get { return dateTime; }

        }


        public string SocialSecurityNumber { get { return socNumber; } }
    }


}