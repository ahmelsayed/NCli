using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static NCli.Constants;

namespace NCli
{
    public class OptionAttribute : Attribute
    {
        public object DefaultValue { get; set; }
        public string HelpText { get; set; }
        public OptionAttribute(char shortName, string longName)
        { }

        public OptionAttribute(string longName) : this(NullCharacter, longName)
        { }

        public OptionAttribute(char shortName) : this(shortName, string.Empty)
        { }
    }
}
