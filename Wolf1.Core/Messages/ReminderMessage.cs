using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Messages
{
    /// <summary>
    /// A ReminderMessage is a scheduled message that will be brought up to
    /// a specified user at a specified data and time. Unlike a HoldMessage,
    /// a ReminderMessage has not affect on the referenced object's message
    /// processing.
    /// </summary>
    class ReminderMessage : Management.Message
    {
    }
}
