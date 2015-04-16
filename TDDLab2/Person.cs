using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLab2
{
    public class person
    {
<<<<<<< HEAD
        private string p;
        private DateTime dateTime;

        public person(string p)
=======
        private string personTestName;

        public personName(string personTestName)
>>>>>>> origin/master
        {
           
            this.personTestName = personTestName;
        }

        public person(string p, DateTime dateTime)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.dateTime = dateTime;
        }

        public string Name
        {
            get { return personTestName; }

            set { value = "John Doe"; }

        }

        public DateTime birthday { get; set; }
    }


}