using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BorisBikes.Core.Tests
{
    public class BikeTests
    {
        private Bike _bike;

        [Test]
        public void returnsAnOptionofMakes()
        {
            var makes = Bike.options();
            Assert.IsTrue(makes.Contains(BikeMake.Ferrari));
        }

        [SetUp]
        public void SetupBike()
        {
            _bike = new Bike(BikeMake.Ferrari);
        }

        [Test]
        public void BikeIsNotBrokenWhenCreated()
        {
            Assert.IsTrue(!_bike.IsBroken);
        }

        [Test]
        public void BikeNotBrokenAtTwentyFiveMph()
        {
            _bike.SpeedUp(25);
            Assert.IsTrue(!_bike.IsBroken);
        }

        [Test]
        public void BikeIsBrokenAtFiftyOneMph()
        {
            _bike.SpeedUp(51);
            Assert.IsTrue(_bike.IsBroken);
        }

        [Test]
        public void BikeCanBeFixed()
        {
            _bike.SpeedUp(51);
            _bike.fix();
            Assert.IsFalse(_bike.IsBroken);
        }

        //[Test]

    }
}
