using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Forms;

namespace Wolf1.Core.Management
{
    interface ISystem
    {
        List<String> MoneyFields { get; }
        int LastDebtor { get; }
        String CollectionChargesLine { get; }
        String InterestChargesLine { get; }
        String BillableCourtCostsLine { get; }
        String InternalCourtCostsLine { get; }
        int FiscalMonth { get; }
        int FiscalYear { get; }
        int ReminderDays { get; }
        Dictionary<String, Boolean> StandardInterest { get; }
        Dictionary<String, Boolean> CompoundInterest { get; }
        Boolean RearrangeDebtsOnMerge { get; }
        Boolean RunSchedulerOnSaturday { get; }
        Boolean RunSchedulerOnSunday { get; }
        Boolean UseCreditBureauReporting { get; }
        Boolean DebtSpecificCreditReport { get; }
        Boolean OpenItem { get; }
        Boolean MessageOnNSF { get; }
        int KeptPercent { get; }
        String ValidInvoiceCycles { get; }
        IForm InvoiceForm { get; }
        Boolean BreakOldCollectorNag { get; }
        int OldCollectorNagAge { get; }
        Boolean BreakReportsByOffice { get; }
        IForm StatementForm { get; }
        Dictionary<String, IState> States { get; set; }
        ICompany SystemCompany { get; set; }
        List<IOffice> Offices { get; }
        Dictionary<IOffice,IClient> Clients { get; }
        List<ICompany> Companies { get; }

    }
}
