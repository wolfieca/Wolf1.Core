using System;
using System.Collections.Generic;
using System.Text;
/**
 * SecurityManager is the primary security-related class in Wolf1.
 * It uses ACLs to determine whether or not a particular action is
 * allowed in the current security context. It additionally interacts
 * with the UserRights class to determine the sort of access the user
 * actually has (i.e. allowed work hours, what modules are accessible,
 * what actions the user is able to perform or request).
 */
namespace Wolf1.Core.Management
{
    /// <summary>
    /// 
    /// </summary>
    class SecurityManager
    {
        public bool CheckAccess(IBaseObject requestedObject, User requester, Access requested)
        {

        }
    }
}
