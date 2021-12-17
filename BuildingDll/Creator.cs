using System;
using System.Collections.Generic;
using System.Linq;

namespace BuildingDll
{
    public class Creator: IBuildingFactory
    {
        private Dictionary<ushort, IBuilding> heshTable = new Dictionary<ushort, IBuilding>();
        public IBuilding Create(string type, double height, byte numberOfStoreys, uint numberOfApartments, ushort entrances)
        {
            switch (type.ToLower())
            {
                case "панелька":
                    PanelHouse panelka = new PanelHouse(height, numberOfStoreys, numberOfApartments, entrances);
                    heshTable.Add(panelka.Number, panelka);
                    return panelka;
                case "коттедж":
                    Cottage cottage = new Cottage(height, numberOfStoreys, numberOfApartments, entrances);
                    heshTable.Add(cottage.Number, cottage);
                    return cottage;
                case "хижина":
                    Hut hut = new Hut(height, numberOfStoreys, numberOfApartments, entrances);
                    heshTable.Add(hut.Number, hut);
                    return hut;
                default:
                    Console.WriteLine("Что-то пошло не так, держите панельку");
                    panelka = new PanelHouse(height, numberOfStoreys, numberOfApartments, entrances);
                    heshTable.Add(panelka.Number, panelka);
                    return panelka;
            }
        }
        public void RemoveBuilding(ushort id)
        {
            heshTable.Remove(id);
        }
        public IBuilding GetBuilding(ushort id)
        {
            if (heshTable.Keys.Contains(id))
            {
                return heshTable[id];
            }
            return null;
        }
    }
}
