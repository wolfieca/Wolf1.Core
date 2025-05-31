using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.MessageQueues;
using Wolf1.Core.Script;
using Wolf1.Core.Statistics;

namespace Wolf1.Core.Management
{
    public interface ICollector : IHourlyEmployee, IAssignee
    {
        String CollectorID { get;  }
        IPersonName Alias { get;  }
        List<IOffice> CollectionOffices { get;  }
        List<String> Specialty { get;  }
        IMessageQueue CollectorQueue { get;  }
        Decimal HighBalance { get;  }
        Decimal LowBalance { get;  }
        IStatistics Statistics { get;  }
        Boolean AutoReassignOldAccounts { get;  }
        int MonthsBeforeAutoReassigb { get;  }
        int StrategyWaitDays { get;  }
        Decimal MonthlyQuotaHigh { get; }
        DateTime MonthlyQuotaHighDate { get; }
        Decimal MonthlyQuotaLow { get; }
        DateTime MonthlyQuotaLowDate { get; }
        Decimal MonthlyQuotaPromised { get; }
        Decimal CurrentAmountCollected { get; }
        Decimal CurrentAmountPromised { get; }
        int MaxQueueSize { get; }
        int MaxNewbizSize { get; }
        String GroupName { get;  }
        String Team { get;  } 
        int MaxQueueTotalSize { get;  }
        IScript CollectorScript { get;  }
    }
}
