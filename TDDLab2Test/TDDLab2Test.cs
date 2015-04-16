using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TDDLab2;

namespace TDDLab2Test1
{ 

    public class Name
    {
        [Fact]
        public void TddLab2Test()
    {
        var personTestName = new personName("John Doe");
        Assert.Equal("John Doe", personTestName.Name );
    }
      
    }
}
