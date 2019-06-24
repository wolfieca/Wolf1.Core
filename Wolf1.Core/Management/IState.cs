using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    /// <summary>
    /// IState provides the core abstraction for entities like States,
    /// provinces, etc
    /// </summary>
    interface IState
    {
        String StateName { get; set; }
        String StatePostAbbrev { get; set; }
        Boolean MailRestricted { get; set; }
    }
}
