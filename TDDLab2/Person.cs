using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLab2
{
    public class personName
    {
        private string personTestName;

        public personName(string personTestName)
        {
           
            this.personTestName = personTestName;
        }

        public string Name
        {
            get { return personTestName; }

            set { value = "John Doe"; }

        }
    }
}