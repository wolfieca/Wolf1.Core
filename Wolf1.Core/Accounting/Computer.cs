using System;
using System.Collections.Generic;
using Wolf1.Core.Accounting;
using Wolf1.Core.Management;
namespace Wolf1.Core.Accounting
{
    public class Computer : IComputer
    {
        public bool Server { get; set;}
        public bool Terminal { get; set;}
        public string Manufacturer { get; set;}
        public string Model { get; set;}
        public string CPU { get; set;}
        public int CPUs { get; set;}
        public string RAM { get; set;}
        public string OS { get; set;}
        public List<string> Software { get; set;}
        public string MACAddress { get; set;}
        public int AgeMonths { get; set;}
        public int MaxAgeMonths { get; set;}
        public IEmployee AssignedTo { get; set;}
        public string AssetTag { get; set;}
        public string Description { get; set;}
        public decimal PurchasePrice { get; set;}
        public DateTime PurchaseDate { get; set;}
        public int PaymentsRemaining { get; set;}
        public int PaymentAmount { get; set;}
        public IHistory ServiceHistory { get; set;}
        public decimal Depreciation { get; set;}
        public decimal ResaleValue {get; set; }
    }
}
