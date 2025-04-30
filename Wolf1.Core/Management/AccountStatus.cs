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
    enum Bankruptcy { NO,  CH07,  CH11, CH13 };
    class AccountStatus
    {
        public string StatusCode {get; private set;}
        public string Title {get;private set;}
        public Bankruptcy BankruptcyType = Bankruptcy.NO;
        public char StatusCategory;
        public char StatusGroup;
        public AccountStatus ChangeStatusTo;
        public Strategy ChangeStrategyTo;
    }
}