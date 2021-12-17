using System;

namespace BuildingDll
{
    public class Cottage: Building
    {
        internal Cottage(double height, byte numberOfStoreys, uint numberOfApartments, ushort entrances) :
            base(height, numberOfStoreys, numberOfApartments, entrances){ }
        public override void WhoAmI()
        {
            Console.WriteLine("Коттедж");
        }
    }
}
