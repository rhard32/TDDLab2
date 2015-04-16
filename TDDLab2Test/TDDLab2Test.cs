﻿using System;
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
        Assert.Equal( "123456789", personTestName.SocialSecurityNumber);

    }

        [Fact]
        public void ComputeThePersonsAge()
        {
            var personTestName = new person("John Doe", new DateTime(1990, 3, 1), "123456789");
            Assert.Equal(25, personTestName.Age);

        }
    }
    }

