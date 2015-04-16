using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLab2
{
    public class person
    {
        private string p;
        private DateTime dateTime;

        public person(string p)
        {
           
            this.p = p;
        }

        public person(string p, DateTime dateTime)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.dateTime = dateTime;
        }

        public string Name
        {
            get { return p; }

            set { value = "John Doe"; }

        }

        public DateTime birthday { get; set; }
    }


}