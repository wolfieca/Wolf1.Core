using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    /// <summary>
    /// Access levels. This is used by the SecurityManager to determine
    /// access to specific objects in the system.
    /// </summary>
    class Access
    {
        public bool CanRead { get; }
        public bool CanWrite { get; }
        public bool CanDelete { get; }
    }
}
