using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Messages
{
    /// <summary>
    /// A HoldMessage is a message, usually sent to another queue, that works 
    /// in a synchronous manner (i.e. the referenced object will not receive 
    /// any further messages until this one has been processed, or has expired).
    /// Sending a HoldMessage on a Debtor object, locks the Debtor, so that it
    /// does not respond to scheduler or other messages for the duration of the
    /// Hold (either the date of expiration, or the time the HoldMessage is 
    /// responded to).
    /// </summary>
    public class HoldMessage : Message
    {
    }
}
