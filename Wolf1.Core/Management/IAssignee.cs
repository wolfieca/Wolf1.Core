using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    /// <summary>
    /// IAssignee defines an interface for objects that debts can be assigned
    /// to, outside of Collectors, which are covered under the base debtor.
    /// Assignees are generally external companies that deal with debtors
    /// on behalf of the primary company. Examples will be Forwarders for 
    /// Debtors with addresses in states for which mail is restricted, and 
    /// Attorneys, who take legal actions against the debtor.
    /// </summary>
    interface IAssignee : ICompany
    {
        List<IDebtor> AssignedDebtors { get; set; }
        Boolean Assign(IDebtor DebtorToAssign);
        Boolean Recall(IDebtor DebtorToAssign);
    }
}
