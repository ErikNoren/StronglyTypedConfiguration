using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StronglyTypedConfiguration.Tests
{
    public class ComplexSetting
    {
        public string Name;
        public int Age;
        public DateTime EmployedOnDate;
        public string[] Aliases;
        public Address Address;
    }

    public class Address
    {
        public string HouseNumber;
        public string Street;
        public string City;
        public string State;
    }
}
