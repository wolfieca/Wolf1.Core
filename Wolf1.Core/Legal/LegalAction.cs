using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;
using Wolf1.Core.Model;
using Wolf1.Core.System;

namespace Wolf1.Core.Legal
{
    public class LegalAction : ILegalAction
    {
        public Account PrimaryAccount { get; }
        public List<Account> IncludedDebts { get; }
        public DateTime SuitDate { get;}
        public Money SuitAmount { get;}
        public Dictionary<string, ILegal> LegalData { get;}
    }
}
