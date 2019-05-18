using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Messages
{
    /// <summary>
    /// Fairly self-explanatory, but a ReportRequest is a request for a report.
    /// The request will normally contain the name of the requested report and
    /// whatever parameters are needed. ReportRequest messages are generally
    /// sent to the System's Report Queue, where there are processed as they
    /// come in.
    /// </summary>
    class ReportRequest : Management.Message
    {
    }
}
