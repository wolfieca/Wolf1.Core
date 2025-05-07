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
    public class ResultCode 
    {
        public string Code {get; private set;}
        public string Description {get; private set; }
        public bool MarkAsWorked { get; private set;}
        public bool MarkAsContacted {get; private set;}
        public bool IsValidForClerical {get; private set;}
        public bool IsValidForSupervisor {get; private set;}
        public bool IsValidForCollector {get; private set;}
        public bool IsValidForClient {get; private set;}
        public bool IsValidClericalQueue {get; private set;}
        public bool IsValidSupervisorQueue {get; private set;}
    }
}