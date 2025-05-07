using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IContract : Document.IDocument
    {
        ISignature Signature { get; set; }
        ISignature CounterSignature { get; set; }
        DateTime EffectiveDate { get; set; }
        Boolean Active { get; set; }
        DateTime TerminationDate { get; set; }
        IHistory ContractHistory { get; set; }
        String SignedContract { get; set; }
        String CounterSignedContract { get; set; }
    }
}
