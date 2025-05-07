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
    public class ActionCode 
    {
        public string Code {get; private set;}
        public string Desctription {get; private set; }
        public Decimal ActionNonLaborCost {get; private set;}
        public Decimal ActionLaborCost {get; private set;}
        public bool IsValidForClericals {get; private set;}
        public bool IsValidForSupervisors {get; private set;}
        public bool IsValidForCollectors {get; private set;}
        public bool IsValidForClients {get; private set;}
    }
}