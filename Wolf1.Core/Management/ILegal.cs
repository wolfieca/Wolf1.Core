using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Legal;

namespace Wolf1.Core.Management
{
    interface ILegal : ISupplemental
    {
        ILegalAction LegalAction { get; set; }
        List<IDebt> IncludedDebts { get; set; }
        int SuitAmount { get; set; }
    }
}
