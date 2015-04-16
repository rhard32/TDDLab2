using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLab2
{
    public class personName
    {
        private string p;

        public personName(string p)
        {
           
            this.p = p;
        }

        public string Name
        {
            get { return p; }

            set { value = "John Doe"; }

        }
    }
}