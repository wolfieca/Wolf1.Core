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
    public class PaymentType 
    {
        public string Code { get; private set; }
        public string Title { get; private set; }
        public int InvoiceType { get; private set; }
        public int InvoiceTitle {get; private set; }
    }
}