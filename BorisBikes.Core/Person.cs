using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BorisBikes.Core
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
            Bikes = new List<Bike>();
        }
        public string Name { get; set; }
        public IEnumerable<Bike> Bikes { get; set; }
    }
}
