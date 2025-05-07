using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IBatchType
    {
        String Type { get; }
        Boolean Payment { get; }
        Boolean Adjustment { get; }
        Boolean Us { get; }
        Boolean Client { get; }
        Boolean Reversal { get; }
        Boolean Match { get; }
    }
}
