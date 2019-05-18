using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    /**
     * AccessControlEntry is the lowest level of the Security mechanism. The
     * AccessControlList Class consists entirely of AccessControlEntries. An
     * individual AccessControlEntry consists of a User and that user's 
     * access flags. In order for AccessControlEntry to approve a requested
     * the requesting user must either: be explicitly be allowed all the
     * requested rights and not be explicitly denied any of those rights, or
     * not be explicity allowed or denied any requested rights, but the object
     * has a base AccessControlEntry that allows those rights. (Base rights are 
     * those rights that are applied to users that are not explicitly listed
     * in the AccessControlList).
     */
    class AccessControlEntry
    {
    }
}
