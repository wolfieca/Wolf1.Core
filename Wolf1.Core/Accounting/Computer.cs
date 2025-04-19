using System;
using System.Collections.Generic;
using Wolf1.Core.Accounting;
using Wolf1.Core.Management;
namespace Wolf1.Core.Accounting
{
    class Computer : IComputer
    {
        public bool Server { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Terminal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Manufacturer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CPU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CPUs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RAM { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OS { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Software { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MACAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AgeMonths { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxAgeMonths { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEmployee AssignedTo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AssetTag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal PurchasePrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime PurchaseDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PaymentsRemaining { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PaymentAmount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IHistory ServiceHistory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Depreciation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
