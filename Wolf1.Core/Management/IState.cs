using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IState
    {
        String StateName { get; set; }
        String StatePostAbbrev { get; set; }
        Boolean MailRestricted { get; set; }
        IZipCode MinZipCode { get; set; }
        IZipCode MaxZipCode { get; set; }

        Boolean ZipInState(int ZipCode);
    }
}
