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

       public person(string personTestName, DateTime dateTime)
        {
            // TODO: Complete member initialization
            this.personTestName = personTestName;
            this.dateTime = dateTime;
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
            
    }


}