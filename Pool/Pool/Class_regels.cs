using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool
{
    public class Class_regels
    {
        public int ruleId;
        public string name;
        public string description;

        public Class_regels()
        {

        }

        public int RuleId
        {
           get { return ruleId; } 
           set { ruleId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
