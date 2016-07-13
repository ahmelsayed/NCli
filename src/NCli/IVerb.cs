using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCli
{
    public interface IVerb
    {
        Task Run();
    }
}
