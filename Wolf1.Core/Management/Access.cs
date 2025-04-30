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
        public bool AllowRemoteAccess { get; protected set; }
        public bool AllowChangePermissions { get; protected set; }
        public bool AllowCopy { get; protected set; }
        public bool AllowChange { get; protected set; }
        public bool DenyRead { get; protected set;}
        public bool DenyWrite { get; protected set; }
        public bool DenyDelete { get; protected set; }
        public bool DenyAccess { get; protected set; }
        public bool DenyTakeOwnership { get; protected set; }
        public bool DenyRemoteAccess { get; protected set; }
        public bool DenyChangePermissions { get; protected set; }
        public bool DenyCopy { get; protected set; }
        public bool DenyChange { get; protected set; }
        public bool AuditRead { get; protected set; }
        public bool AuditWrite { get; protected set; }
        public bool AuditDelete { get; protected set; }
        public bool AuditAccess { get; protected set; }
        public bool AuditTakeOwnership { get; protected set; }
        public bool AuditRemoteAccess { get; protected set; }
        public bool AuditChangePermissions { get; protected set; }
        public bool AuditCopy { get; protected set; }
        public bool AuditChange { get; protected set; }

        public bool CanRead()
        {
            return AllowRead && !DenyRead;
        }
        public bool CanWrite()
        {
            return AllowWrite && !DenyWrite;
        }
        public bool CanDelete()
        {
            return AllowDelete && !DenyDelete;
        }
        public bool CanAccess()
        {
            return AllowAccess && !DenyAccess;
        }
        public bool CanTakeOwnership()
        {
            return AllowTakeOwnership && !DenyTakeOwnership;
        }
        public bool CanRemoteAccess()
        {
            return AllowRemoteAccess && !DenyRemoteAccess;
        }
        public bool CanChangePermissions()
        {
            return AllowChangePermissions && !DenyChangePermissions;
        }
        public bool CanCopy()
        {
            return AllowCopy && !DenyCopy;
        }
        public bool CanChange()
        {
            return AllowChange && !DenyChange;
        }

        public bool TakeOwnership (Access currentOwner)
        {
            if (!currentOwner.IsOwner)
                return false;
            if (this.CanTakeOwnership())
            {
                this.IsOwner = true;
                currentOwner.IsOwner = false;
            }
            return this.IsOwner;
        }
   }
}
