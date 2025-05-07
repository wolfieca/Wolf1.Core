using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
    public class AccessControlList
    {
        private Dictionary<IUser, AccessControlEntry> _ACL;

        public Dictionary<IUser,AccessControlEntry> ACL { get => _ACL; protected set => _ACL = value; }

        public List<User> Readers {get => Readers; protected set => Readers = value;}
        public User Writer { get => Writer; protected set => Writer = value;}
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

        public bool RequestReadAccess ( User user )
        {
            Readers.Add(user);
            return false;
        }
        public bool RequestWriteAccess ( User user )
        {
            if ( this.Writer != null || this.Writer == user )
            {
                this.Writer = user;
                return true;
            } 
            return false;
        }
        public bool ReleaseReadAccess(User user) 
        {
            if (Readers.Contains(user)) 
            {
                Readers.Remove (user);
                return true;   
            } 
            return false;
        }
        public bool ReleaseWriteAccess ( User user ) 
        {
            if ( this.Writer == user )
            {
                this.Writer = null;
                return true;
            } 
            return false;
        }
    }
}
