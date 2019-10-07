using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.MessageQueues;
using Wolf1.Core.Script;
using Wolf1.Core.Statistics;

namespace Wolf1.Core.Management
{
    interface ICollector : IHourlyEmployee, IAssignee
    {
        String CollectorID { get; set; }
        IPersonName Alias { get; set; }
        List<IOffice> CollectionOffices { get; set; }
        List<String> Specialty { get; set; }
        IMessageQueue CollectorQueue { get; set; }
        Decimal HighBalance { get; set; }
        Decimal LowBalance { get; set; }
        IStatistics Statistics { get; set; }
        Boolean AutoReassignOldAccounts { get; set; }
        int MonthsBeforeAutoReassigb { get; set; }
        int StrategyWaitDays { get; set; }
        Decimal MonthlyQuotaHigh { get; }
        DateTime MonthlyQuotaHighDate { get; }
        Decimal MonthlyQuotaLow { get; }
        DateTime MonthlyQuotaLowDate { get; }
        Decimal MonthlyQuotaPromised { get; }
        Decimal CurrentAmountCollected { get; }
        Decimal CurrentAmountPromised { get; }
        int MaxQueueSize { get; }
        int MaxNewbizSize { get; }
        String GroupName { get; set; }
        String Team { get; set; } 
        int MaxQueueTotalSize { get; set; }
        IScript CollectorScript { get; set; }
    }
}
