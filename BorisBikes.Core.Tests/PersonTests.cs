using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace BorisBikes.Core.Tests
{
    public class PersonTests
    {
        private Person _person;

        [Test]
        public void hasANameWhenCreated()
        {
            _person = new Person("Mark");
            Assert.IsTrue(_person.Name == "Mark"); 
        }

        [Test]
        public void hasNoBikesWhenCreated()
        {
            List<Bike> list1 = new List<Bike>();
            _person = new Person("John");
            Assert.IsTrue(_person.Bikes.Count() == list1.Count);
        }

    }
}
