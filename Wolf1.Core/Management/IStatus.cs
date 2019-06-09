using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    /// <summary>
    /// Classes implementing this interface reflect debtor account statuses,
    /// which are used to determine behaviors relating to the debtor
    /// </summary>
    interface IStatus
    {
        String Code { get; set; }
        String Description { get; set; }
        Boolean AllowLetters { get; set; }
        Boolean OnPaymentChangeStatus { get; set; }
        IStatus OnPaymentChangeStatusTo { get; set; }
        IStrategy Strategy { get; set; }
    }
}
