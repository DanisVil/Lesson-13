using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingDll
{
    class BuildingCluster
    {
        private Building[] buildings = new Building[10];
        public Building this[int i]
        {
            get { return buildings[i]; }
            set { buildings[i] = value; }
        }
    }
}
