using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;
using Wolf1.Core.System;

namespace Wolf1.Core.Statistics
{
    public class CollectorStatistics : IStatistics
    {
        public Collector Collector { get; }
        public DateTime CurrentDate { get; }
        public ACColl[] AC;
        public SUColl[] SU;
        public SU2Coll[] SU2;

        public CollectorStatistics()
        {
            Collector = new Collector();
            CurrentDate = DateTime.Now;
            AC = new ACColl[17];
            SU = new SUColl[3];
            SU2 = new SU2Coll[13]; 
        }

        public string Month { get; }
        public string Year { get; }
        public Dictionary<string, int> Statistics { get; }

        public bool Update(string StatisticName, int value)
        {
            throw new NotImplementedException();
        }
    }
    public record ACColl
    {
        public Money NewDollars { get; } = new Money(0.00m);
        public long NewAccounts { get; }= 0;
        public Money PaidByDateReceivedDollars { get; } = new Money(0.00m);
        public long PaidByDateReceivedAccounts { get; } = 0;
        public Money PaidThisMonthDollars { get; } = new Money(0.00m);
        public long PaidThisMonthAccounts { get; } = 0;
        public Money PaidInFullByDateReceivedDollars { get; } = new Money(0.00m);
        public long PaidInFullByDateReceivedAccounts { get; } = 0;
        public Money PurgedDollarsByDateReceived { get; } = new Money(0.00m);
        public long PurgedAccountsByDateReceived { get; } = 0;
        public Money ReturnedDollarsByDateReceived { get; } = new Money(0.00m);
        public long ReturnedAccountsByDateReceived { get; } = 0;
        public Money TransferredInDollarsByDateReceived { get; } = new Money(0.00m);
        public long TransferredInAccountsByDateReceived { get; } = 0;
        public Money TransferredOutDollarsByDateReceived { get; } = new Money(0.00m);
        public long TransferredOutAccountsByDateReceived { get; } = 0;
        public Money CourtCostsChargedByDateReceived { get; } = new Money(0.00m);
        public Money CourtCostsReturnedByDateReceived { get; } = new Money(0.00m);
        public Money InternalCourtCostsChargedByDateReceived { get; } = new Money(0.00m);
        public Money InternalCourtCostsReturnedByDateReceived { get; } = new Money(0.00m);
        public Money FeeDollarsByDateReceived { get; } = new Money(0.00m);
        public Money AdjustmentDollarsByDateReceived { get; } = new Money(0.00m);
        public Money AttorneyFees { get; } = new Money(0.00m);
        public Money ForwarderFees { get; } = new Money(0.00m);
    }
    public record SUColl
    {
        public Money NewDollars { get; } = new Money(0.00m);
        public long NewAccounts { get; } = 0;
        public Money PaidByDateReceivedDollars { get; } = new Money(0.00m);
        public long PaidByDateReceivedAccounts { get; } = 0;
        public Money PaidInFullByDateReceivedDollars { get; } = new Money(0.00m);
        public long PaidInFullByDateReceivedAccounts { get; } = 0;
        public Money PurgedByDateReceivedDollars { get; } = new Money(0.00m);
        public long PurgedDateReceivedAccounts { get; } = 0;
        public Money ReturnedByDateReceivedDollars { get; } = new Money(0.00m);
        public long ReturnedByDateReceivedAccounts { get; } = 0;
        public Money TransferredByDateReceivedDollars { get; } = new Money(0.00m);
        public long TransferredByDateReceivedAccounts { get; } = 0;
        public Money CourtCostsChargedByDateReceived { get; } = new Money(0.00m);
        public Money CourtCostsReturnedByDateReceived { get; } = new Money(0.00m);
        public Money InternalCourtCostsChargedByDateReceived { get; } = new Money(0.00m);
        public Money InternalCourtCostsReturnedByDateReceived { get; } = new Money(0.00m);
        public Money FeeByDateReceivedDollars { get; } = new Money(0.00m);
        public Money AdjustmentByDateReceivedDollars { get; } = new Money(0.00m);
        public Money AttorneyFeesDollars { get; } = new Money(0.00m);
        public Money ForwarderFeesDollars { get; } = new Money(0.00m);
    }
    public record SU2Coll
    {
        public long PromisesNumber { get; } = 0;
        public Money PromisesAmount { get; } = new Money(0.00m);
        public long PromisesKepNumber { get; }
        public Money PromisesKeptAmount { get; } = new Money(0.00m);
        public long ContractsNumber { get; }
        public Money ContractsAmount { get; } = new Money(0.00m);
        public long ContractsKeptNumber { get; }
        public Money ContractsKeptAmount { get; } = new Money(0.00m);
    }
}
