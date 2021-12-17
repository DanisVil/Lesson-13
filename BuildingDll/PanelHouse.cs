using System;

namespace BuildingDll
{
    public class PanelHouse: Building
    {
        internal PanelHouse(double height, byte numberOfStoreys, uint numberOfApartments, ushort entrances) : 
            base(height, numberOfStoreys, numberOfApartments, entrances){ }
        public override void WhoAmI()
        {
            Console.WriteLine("Панелька. Серая панелька");
        }
    }
}
