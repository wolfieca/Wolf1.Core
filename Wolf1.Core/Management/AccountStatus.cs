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
    public enum Bankruptcy { NO,  CH07,  CH11, CH13 };
    public class AccountStatus
    {
        public string Code {get; private set;}
        public bool CanLettersBeSent { get; private set;}
        public string Desceiption {get;private set;}
        public Bankruptcy BankruptStatus = Bankruptcy.NO;
        public char StatusCategory {get; private set;}
        public char StatusGroup {get; private set;}
        public bool IncludeOnReturnReport {get; private set;}
        public AccountStatus ChangeStatusTo {get; private set;}
        public Strategy ChangeStrategyTo {get; private set;}
    }
}