using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TDDLab2;


namespace TDDLab2Test1
<<<<<<< HEAD
{
    //Create String Name
=======
{ 
    //Create Test for Person Name
>>>>>>> origin/master
    public class Name
    {
        [Fact]
        public void TddLab2Test()
        {
            var personTestName = new person("John Doe");
            Assert.Equal("John Doe", personTestName.Name);
        }
    [Fact]
        public void birthdayTest()
    {
        var birthdayTest = new person("John Doe", new DateTime(68, 09, 12));
        Assert.Equal(new DateTime(68, 09, 12), birthdayTest.birthday);
    }
    }
    }

