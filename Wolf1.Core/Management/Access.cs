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
        /// <summary>
        /// _AccessMask consists of a 32-bit mask, which is made up of an 
        /// ownership byte (one bit to reflect the associated user is the 
        /// current owner, seven are reserved for future use), 8-bits of 
        /// allow permissions and 8-bits of deny permissions.
        /// </summary>
        private int _AccessMask;

        public int AccessMask { get => _AccessMask; protected set => _AccessMask = value; }

        /// <summary>
        /// The associated User is the owner of this object.
        /// </summary>
        public bool IsOwner { get; protected set; } 

        public bool AllowRead { get; protected set; }
        public bool AllowWrite { get; protected set; }
        public bool AllowDelete { get; protected set; }
        public bool AllowAccess { get; protected set; }
        public bool AllowTakeOwnership { get; protected set; }
        public bool AllowSpecial1 { get; protected set; }
        public bool AllowSpecial2 { get; protected set; }
        public bool AllowSpecial3 { get; protected set; }
        public bool AllowSpecial4 { get; protected set; }
        public bool DenyWrite { get; protected set; }
        public bool DenyDelete { get; protected set; }
        public bool DenyAccess { get; protected set; }
        public bool DenyTakeOwnership { get; protected set; }
        public bool DenySpecial1 { get; protected set; }
        public bool DenySpecial2 { get; protected set; }
        public bool DenySpecial3 { get; protected set; }
        public bool DenySpecial4 { get; protected set; }
    }
}
