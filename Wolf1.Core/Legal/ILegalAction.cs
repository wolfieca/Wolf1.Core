using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;
using Wolf1.Core.Model;
using Wolf1.Core.System;

namespace Wolf1.Core.Legal
{
    public interface ILegalAction
    {
        List<Account> IncludedDebts { get; }
        DateTime SuitDate { get; }
        Money SuitAmount { get; }
        Dictionary<String, ILegal> LegalData { get; }
    }
}
