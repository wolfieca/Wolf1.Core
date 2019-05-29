using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IZipCode
    {
        String ZipCode { get; set; }
        String Plus4 { get; set; }

        String ZipPlus4();
        int Compare(IZipCode testValue);
    }
}
