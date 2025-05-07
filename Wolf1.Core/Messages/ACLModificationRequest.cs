using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.Messages
{
    public class ACLModificationRequest : Message
    {
        public User RequestingUser{get;private set;}
        public ISecurable Target{get; private set;}
        public AccessControlList NewACL {get; private set;}
    }
}
