using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IPhoneNumber
    {
        String CountryCode { get; set; }
        String AreaCode { get; set; }
        String Prefix { get; set; }
        String LineNumber { get; set; }
        String Extension { get; set; }
        Boolean CanCall { get; set; }

        String InternationalNumber();
        String LongDistanceNumber();
        String LocalNumber();
        String USNumber();
    }
}
