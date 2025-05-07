using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{

    [Flags]
    public enum AccessRights 
    {
        None                =   0b0000_0000_0000_0000_0000_0000_0000_0000,
        IsOwner             =   0b0000_0000_0001_0000_0000_0000_0000_0000,
        AllowRead           =   0b0000_0000_0000_0000_0000_0000_0000_0001,
        AllowWrite          =   0b0000_0000_0000_0000_0000_0000_0000_0010,
        AllowDelete         =   0b0000_0000_0000_0000_0000_0000_0000_0100,
        AllowAccess         =   0b0000_0000_0000_0000_0000_0000_0000_1000,
        AllowTakeOwnership  =   0b0000_0000_0000_0000_0000_0000_0001_0000,
        AllowChange         =   0b0000_0000_0000_0000_0000_0000_0010_0000,
        AllowRemoteAccess   =   0b0000_0000_0000_0000_0000_0000_0100_0000,
        AllowCopy           =   0b0000_0000_0000_0000_0000_0000_1000_0000,
        DenyRead            =   0b0000_0000_0000_0000_0000_0001_0000_0000,
        DenyWrite           =   0b0000_0000_0000_0000_0000_0010_0000_0000,
        DenyDelete          =   0b0000_0000_0000_0000_0000_0100_0000_0000,
        DenyAccess          =   0b0000_0000_0000_0000_0000_1000_0000_0000,
        DenyTakeOwnership   =   0b0000_0000_0000_0000_0001_0000_0000_0000,
        DenyChange          =   0b0000_0000_0000_0000_0010_0000_0000_0000,
        DenyRemoteAccess    =   0b0000_0000_0000_0000_0100_0000_0000_0000,
        DenyCopy            =   0b0000_0000_0000_0000_1000_0000_0000_0000,
        AuditRead           =   0b0000_0000_0000_0001_0000_0000_0000_0000,
        AuditWrite          =   0b0000_0000_0000_0010_0000_0000_0000_0000,
        AuditDelete         =   0b0000_0000_0000_0100_0000_0000_0000_0000,
        AuditAccess         =   0b0000_0000_0000_1000_0000_0000_0000_0000,
        AuditTakeOwnership  =   0b0000_0000_0001_0000_0000_0000_0000_0000,
        AuditChange         =   0b0000_0000_0010_0000_0000_0000_0000_0000,
        AuditRemoteAccess   =   0b0000_0000_0100_0000_0000_0000_0000_0000,
        AuditCopy           =   0b0000_0000_1000_0000_0000_0000_0000_0000,
        AllowAll            =   AllowRead | AllowWrite | AllowDelete | AllowAccess | AllowTakeOwnership | AllowChange | AllowRemoteAccess | AllowCopy,
        DenyAll             =   DenyRead | DenyWrite | DenyDelete | DenyAccess | DenyTakeOwnership | DenyChange | DenyRemoteAccess | AllowCopy,
        AuditAll            =   AuditRead | AuditWrite | AuditDelete | AuditAccess | AuditTakeOwnership | AuditChange | AuditRemoteAccess | AuditCopy
    }
    /// <summary>
    /// Access levels. This is used by the SecurityManager to determine
    /// access to specific objects in the system.
    /// </summary>
    public class Access
    {
        /// <summary>
        /// _AccessMask consists of a 32-bit mask, which is made up of an 
        /// ownership byte (one bit to reflect the associated user is the 
        /// current owner, seven are reserved for future use), 8-bits of 
        /// allow permissions and 8-bits of deny permissions.
        /// </summary>
        private int _AccessMask;

        public int AccessMask { get => _AccessMask; protected set => _AccessMask = value; }
        private AccessRights _accessRight = 0;
        
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
