using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Document;
using Wolf1.Core.Legal;
using Wolf1.Core.Management;
using Wolf1.Core.MessageQueues;
using Wolf1.Core.Script;

namespace Wolf1.Core.Management
{
    public enum Bankruptcy { NO, CH07, CH11, CH13 };
    public class AccountStatus
    {
        public String Code { get; private set; }
        public Boolean CanLettersBeSent { get; private set; }
        public String Description { get; private set; }
        public Bankruptcy BankruptStatus = Bankruptcy.NO;
        public char StatusCategory { get; private set; }
        public char StatusGroup { get; private set; }
        public Boolean IncludeOnReturnReport { get; private set; }
        public AccountStatus ChangeStatusTo { get; private set; }
        public Strategy ChangeStrategyTo { get; private set; }
    }
    
    /// Sample
    /// Code:                   NEW
    /// CanLettersBeSend:       true
    /// Description:            account is new on the system
    /// Bankruptcy:             Bankruptcy.NO
    /// StatusCategory:         ???
    /// StatusGroup:            ???
    /// IncludeOnReturnReport:  false
    /// ChangeStatusTo:         ""
    /// ChangeStrategyTo:       ""
}