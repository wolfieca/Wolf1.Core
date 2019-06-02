using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Document;

namespace Wolf1.Core.Accounting
{
    interface IVehicle : IAsset , IEquipment
    {
        String Manufacturer { get; set; }
        String Model { get; set; }
        int ModelYear { get; set; }
        String LicencePlate { get; set; }
        int InitialMileage { get; set; }
        int Mileage { get; set; }
        Boolean Leased { get; set; }
        DateTime LeaseStart { get; set; }
        DateTime LeaseEnd { get; set; }
        DateTime LeaseBroken { get; set; }
        List<IDocument> LeaseDocuments { get; set; }
    }
}
