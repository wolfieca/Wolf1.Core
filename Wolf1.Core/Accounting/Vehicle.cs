using System;
using System.Collections.Generic;
using Wolf1.Core.Accounting;
using Wolf1.Core.Document;
using Wolf1.Core.Management;

namespace Wolf1.Core.Accounting
{
    class Vehicle : IVehicle
    {
        public string Manufacturer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ModelYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LicencePlate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int InitialMileage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Mileage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Leased { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime LeaseStart { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime LeaseEnd { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime LeaseBroken { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IDocument> LeaseDocuments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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