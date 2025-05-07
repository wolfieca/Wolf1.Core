using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.Accounting
{
    public interface IComputer : IEquipment
    {
        Boolean Server { get; set; }
        Boolean Terminal { get; set; }
        String Manufacturer { get; set; }
        String Model { get; set; }
        String CPU { get; set; }
        int CPUs { get; set; }
        String RAM { get; set; }
        String OS { get; set; }
        List<String> Software { get; set; }
        String MACAddress { get; set; }
        int AgeMonths { get; set; }
        int MaxAgeMonths { get; set; }
    }
}
