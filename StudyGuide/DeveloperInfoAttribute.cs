using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyGuide
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = true)]
    public class DeveloperInfoAttribute : System.Attribute
    {
        private string name;
        private DateTime time;
        public DeveloperInfoAttribute(string name)
        {
            this.name = name;
            time = DateTime.Now;
        }
        public override string ToString()
        {
            return name + "   " + time;
        }
    }
}
