namespace BuildingDll
{
    interface IBuildingFactory
    {
        IBuilding Create(string type, double height, byte numberOfStoreys, uint numberOfApartments, ushort entrances);
    }
}
