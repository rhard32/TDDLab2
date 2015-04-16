using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TDDLab2;


namespace TDDLab2Test1
{
    //Create Test for Person Name
    public class Name
    {
        [Fact]
        public void TddLab2Test()
        {
            var personTestName = new person("John Doe", DateTime.Now, "123456789");
            Assert.Equal("John Doe", personTestName.Name);
        }
        [Fact]
        public void birthdayTest()
        {
            var birthdayTest = new person("John Doe", new DateTime(68, 09, 12));
            Assert.Equal(new DateTime(68, 09, 12), birthdayTest.birthday);
        }

        [Fact]
        public void socialSecNumbTest()
        {
            var personTestName = new person("John Doe", DateTime.Now, "123456789");
            Assert.Equal("123456789", personTestName.SocialSecurityNumber);

        }

        [Fact]
        public void ComputeThePersonsAge()
        {
            var personTestName = new person("John Doe", new DateTime(1990, 3, 1), "123456789");
            Assert.Equal(25, personTestName.Age);

        }

        [Fact]
        public void CanSortByLastName()
        {
            var firstPerson = new person("Abigal Addams", DateTime.Now, "111223333");
            var secondPerson = new person("John Smith", DateTime.Now, "111223333");

            Assert.Equal(-1, firstPerson.CompareTo(secondPerson));
        }

        [Fact]
        public void OrderByLastName()
        {
            var firstPerson = new person("Abigal Addams", DateTime.Now, "111223333");
            var secondPerson = new person("John Smith", DateTime.Now, "111223333");

            Assert.Equal(1, secondPerson.CompareTo(firstPerson));
        }
    }
}

