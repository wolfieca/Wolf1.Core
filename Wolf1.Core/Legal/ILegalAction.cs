using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.Legal
{
    public interface ILegalAction
    {
        List<IDebt> IncludedDebts { get; set; }
        DateTime SuitDate { get; set; }
        int SuitAmount { get; set; }
        Dictionary<String, ILegal> LegalData { get; set; }
    }
}
