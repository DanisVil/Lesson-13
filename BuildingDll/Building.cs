using System;

namespace BuildingDll
{
    [BuildingDeveloper("Александр Макеконский", "Union Carbide")]
    public class Building: IBuilding
    {
        private static ushort _counter = 1;
        public ushort Number { get; private set; }
        public double Height { get; private set; }
        public byte NumberOfStoreys { get; private set; }
        public uint NumberOfApartments { get; private set; }
        public ushort Entrances { get; private set; }
        internal Building(double height, byte numberOfStoreys, uint numberOfApartments, ushort entrances)
        {
            Height = height;
            NumberOfStoreys = numberOfStoreys;
            NumberOfApartments = numberOfApartments;
            Entrances = entrances;
            Number = _counter;
            _counter++;
        }
        public float FloorHeight
        {
            get
            {
                return (float)Height / NumberOfStoreys;
            }
        }
        public float AverageNumberOfApartmentsInTheEntrance
        {
            get
            {
                return NumberOfApartments / Entrances;
            }
        }
        public float AverageNumberOfApartmentsPerFloor
        {
            get
            {
                return NumberOfApartments / NumberOfStoreys;
            }
        }
        public virtual void WhoAmI()
        {
            Console.WriteLine("Самое обычное здание");
        }
    }
}
