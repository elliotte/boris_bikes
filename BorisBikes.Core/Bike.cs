using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BorisBikes.Core
{
    public class Bike
    {
        public Bike(BikeMake make)
        {
            Make = make;
        }
        public bool IsBroken { get; private set; }
        public BikeMake Make { get; private set; }

        public static IEnumerable<BikeMake> options()
        {
            yield return BikeMake.Ferrari;
            yield return BikeMake.Ford;
        }

        private int _speed;

        public int SpeedUp(int byHowMuch)
        {
            _speed += byHowMuch;

            if (_speed <= 50) return _speed;

            IsBroken = true;
            return -1;
        }

        public bool fix()
        {
            IsBroken = false;
            return true;
        }
    }
}
