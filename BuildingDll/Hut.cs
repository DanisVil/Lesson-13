using System;

namespace BuildingDll
{
    public class Hut: Building
    {
        internal Hut(double height, byte numberOfStoreys, uint numberOfApartments, ushort entrances) :
            base(height, numberOfStoreys, numberOfApartments, entrances){ }
        public override void WhoAmI()
        {
            Console.WriteLine("Уга-буга");
        }
    }
}
