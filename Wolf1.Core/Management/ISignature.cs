using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Wolf1.Core.Document;

namespace Wolf1.Core.Management
{
    public interface ISignature
    {
        IPerson Signer { get; set; }
        DateTime SignDate { get; set; }
        IPAddress SignerIP { get; set; }

        Boolean Validate(IDocument Document);
        String Sign(String Original);
    }
}
