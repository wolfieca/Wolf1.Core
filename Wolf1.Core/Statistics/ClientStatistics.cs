using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Model;
using Wolf1.Core.System;

namespace Wolf1.Core.Statistics
{
    public class ClientStatistics : IStatistics
    {
        public Client Client { get; }
        public string Month { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<string, int> Statistics { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateOnly CurrentDate { get; }
        public Money CurrentMonthReceivables { get; }
        public Money[] Aging;
        public DateOnly DateThrough { get; }
        public bool Update(string StatisticName, int value)
        {
            throw new NotImplementedException();
        }
    }

    public record ACClient
    {
        public Money NewAmount { get; } = new Money(0.0m);
        public long NewAccounts { get; } = 0;
        public Money PaidAmount { get; } = new Money(0.0m);
        public Money WholyRetainedAmount { get; } = new Money(0.0m);
        public long PaidAccounts { get; } = 0;
        public Money AmountPaidThisMonth { get; } = new Money(0.0m);
        public Money WhollyRetainedThisMonth { get; } = new Money(0.0m);
        public Money FeesOnPaymentsThisMonth { get; } = new Money(0.0m);
        public long PaymentsMadeThisMonth { get; } = 0;
        public Money PaidInFullAmount { get; } = new Money(0.0m);
        public long PaidInFullAccounts { get; } = 0;
        public Money PurgedAmount { get; } = new Money(0.0m);
        public long PurgedAccounts { get; } = 0;
        public Money ReturnedAmount { get; } = new Money(0.0m);
        public long ReturnedAccounts { get; } = 0;
        public Money TransferredInAmount { get; } = new Money(0.0m);
        public long TransferredInAccounts { get; } = 0;
        public Money TransferredOutAmount { get; } = new Money(0.0m);
        public long TransferredOutAccounts { get; } = 0;
        public Money CourtCostsChargedAmount { get; } = new Money(0.0m);
        public Money CourtCostsReturnedAmount { get; } = new Money(0.0m);
        public Money InternalCourtCostsChargedAmount { get; } = new Money(0.0m);
        public Money InternalCourtCostsReturnedAmount { get; } = new Money(0.0m);
        public Money FeesByDateReceivedAmount { get; } = new Money(0.0m);
        public Money AdjustmentsByDateReceivedAmount { get; } = new Money(0.0m);
        public Money AttorneyFeesAmount { get; } = new Money(0.0m);
        public Money ForwarderFeesAmount { get; } = new Money(0.0m);
        public Money LaborCostsIncurredByDateReceivedAmount { get; } = new Money(0.0m);
        public Money NonLaborCostsIncurredByDateReceivedAmount { get; } = new Money(0.0m);
        public Money MailingCostsIncurredByDateReceivedAmount { get; } = new Money(0.0m);
    }

    public record SUClient
    {
        public Money NewAmount { get; } = new Money(0.0m);
        public long NewAccounts { get; } = 0;
        public Money PaidAmount { get; } = new Money(0.0m);
        public Money WholyRetainedAmount { get; } = new Money(0.0m);
        public long PaidAccounts { get; } = 0;
        public Money PaidInFullAmount { get; } = new Money(0.0m);
        public long PaidInFullAccounts { get; } = 0;
        public Money PurgedAmount { get; } = new Money(0.0m);
        public long PurgedAccounts { get; } = 0;
        public Money ReturnedAmount { get; } = new Money(0.0m);
        public long ReturnedAccounts { get; } = 0;
        public Money TransferredInAmount { get; } = new Money(0.0m);
        public long TransferredInAccounts { get; } = 0;
        public Money TransferredOutAmount { get; } = new Money(0.0m);
        public long TransferredOutAccounts { get; } = 0;
        public Money CourtCostsChargedAmount { get; } = new Money(0.0m);
        public Money CourtCostsReturnedAmount { get; } = new Money(0.0m);
        public Money InternalCourtCostsChargedAmount { get; } = new Money(0.0m);
        public Money InternalCourtCostsReturnedAmount { get; } = new Money(0.0m);
        public Money FeesByDateReceivedAmount { get; } = new Money(0.0m);
        public Money AdjustmentsByDateReceivedAmount { get; } = new Money(0.0m);
        public Money AttorneyFeesAmount { get; } = new Money(0.0m);
        public Money ForwarderFeesAmount { get; } = new Money(0.0m);
        public Money LaborCostsIncurredByDateReceivedAmount { get; } = new Money(0.0m);
        public Money NonLaborCostsIncurredByDateReceivedAmount { get; } = new Money(0.0m);
        public Money MailingCostsIncurredByDateReceivedAmount { get; } = new Money(0.0m);  
    }
}
