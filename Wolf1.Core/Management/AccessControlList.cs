using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    /**
     * An AccessControlList represents the levels of access that an object
     * allows. It's largely passive, with the exception of checking whether
     * or not a requested access is to be allowed. The SecurityManager
     * is responsible for taking action to respond to the AccessControlLists
     * recommendations.
     */
    class AccessControlList
    {
        private Dictionary<IUser, Access> _ACL;

        public Dictionary<IUser,Access> ACL { get => _ACL; protected set => _ACL = value; }

        /// <summary>
        /// Check whether the specified user is allowed the  level of access
        /// requested for the specified user.
        /// </summary>
        /// <param name="User">The user access is being requested for</param>
        /// <param name="RequestedAccess">The access being requested</param>
        /// <returns></returns>
        public Boolean CheckAccess(IUser User, Access RequestedAccess)
        {
            throw new NotImplementedException();
        }
    }
}
