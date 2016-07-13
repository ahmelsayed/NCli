using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCli
{
    public class VerbAttribute : Attribute
    {
        public string HelpText { get; set; }
        public string Usage { get; set; }
        public bool Show { get; set; } = true;
        internal string[] LongNames { get; }
        public VerbAttribute(params string[] longNames)
        {
            LongNames = longNames;
        }
    }
}
