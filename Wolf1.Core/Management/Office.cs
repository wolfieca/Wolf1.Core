using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public class Office
    {
        public Employee OfficeManager {get; private set;}
        public Address PhysicalAddress {get; private set;}
        public Address MailingAddress {get; private set;}
        public List<Employee> Employees {get; private set;}
    }
}
