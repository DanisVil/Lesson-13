using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingDll
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class BuildingDeveloperAttribute : System.Attribute
    {
        private string programmerName;
        private string organisationName;
        public BuildingDeveloperAttribute(string programmerName, string organisationName)
        {
            this.programmerName = programmerName;
            this.organisationName = organisationName;
        }
        public override string ToString()
        {
            return "Разработчик - " + programmerName + ", название организации - " + organisationName;
        }
    }
}
