﻿using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;
using Wolf1.Core.Report;

namespace Wolf1.Core.Accounting
{
    class Equipment : IEquipment, IReport
    {
        public IEmployee AssignedTo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AssetTag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PurchasePrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime PurchaseDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PaymentsRemaining { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PaymentAmount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IHistory ServiceHistory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
