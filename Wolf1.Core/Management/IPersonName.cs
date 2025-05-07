using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IPersonName
    {
        String LastName { get; set; }
        String FirstName { get; set; }
        String Suffix { get; set; }
        String Title { get; set; }

        String NameTraditional();
        String NameSortable();
        String NameFormal();
        String ProperName();
    }
}
