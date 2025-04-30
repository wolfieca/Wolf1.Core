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
    class ActionResultCode 
    {
        public string ActivityCode {get; private set;}
        public string Title {get; private set; }
        public Decimal ActionCost {get; private set;}
        public Decimal LaborCost {get; private set;}

    }
}