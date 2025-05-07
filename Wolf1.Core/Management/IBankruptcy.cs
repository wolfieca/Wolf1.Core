using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    /// <summary>
    /// IBankruptcy implementers implement additional behaviors unique to 
    /// bankruptcy claim statuses (i.e. chapter, adjudicated/discharged/
    /// dismissed, etc).
    /// </summary>
    public interface IBankruptcy : IStatus
    {
        int Chapter { get; }
    }
}
