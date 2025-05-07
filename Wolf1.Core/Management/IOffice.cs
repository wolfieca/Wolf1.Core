using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IOffice
    {
        String Name { get; set; }
        IAddress Address { get; set; }
        IEmployee Manager { get; set; }
        List<IServices> Services { get; set; }
        ICompanyHours BusinessHours { get; set; }
    }
}
