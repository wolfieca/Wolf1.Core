using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.System
{
    public record ABARecord
    {
        public int ABANumber { get; }
        public string BankName { get; }
        public Address BankAddress { get; }
        public Phone BankPhone { get; }
        public Phone BankFax { get; }
        public string Memo { get; }
    }

    public class ABA
    {
        private Dictionary<int, ABARecord> ABARecords;
        public ABARecord LookupABANumber(int SearchNumber)
        {
            if (ABARecords[SearchNumber] is not null)
                return ABARecords[SearchNumber];
            return null;
        }
        public bool AddABARecord(ABARecord RecordToAdd)
        {
            if (ABARecords[RecordToAdd.ABANumber] is not null)
                return false;
            ABARecords.Add(RecordToAdd.ABANumber, RecordToAdd);
            return true;
        }
        public bool RemoveABARecord(int ABANumberToRemove) {
            return (ABARecords.Remove(ABANumberToRemove));
        }
    }
}