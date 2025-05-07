using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Document;

namespace Wolf1.Core.Management
{
    public interface IDocumentDelivery
    {
        IDocument Document { get; set; }
        Boolean Email { get; set; }
        Boolean Website { get; set; }
        Boolean CallUs { get; set; }
        Boolean Print { get; set; }
        Boolean Fax { get; set; }
        Boolean None { get; set; }
    }
}
