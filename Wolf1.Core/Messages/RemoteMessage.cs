using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Messages
{
    /// <summary>
    /// A RemoteMessage is any Message that has to be sent to a remote network.
    /// It is designed for products like netconnect (Experian), where we send
    /// a request file (usually XML). and then wait for a response file to
    /// to place in the system.
    /// </summary>
    class RemoteMessage : Management.Message
    {
    }
}
