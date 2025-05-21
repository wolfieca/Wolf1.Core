using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.CreditReport
{
    public enum CreditReportRunMode { DEBUG, INITIALIZE, CONVERSION, CONVERSION_PIF, EVALUATE, NORMAL }
    public interface ICreditReport 
    {
        int FileWidth {get; set;}
        CreditReportRunMode RunMode { get; set;}
    }
}
