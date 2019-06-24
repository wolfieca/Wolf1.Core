using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    /// <summary>
    /// IZipCode abstracts Postal Codes for the system. Comparison
    /// operators for Zip codes work differently than they do for actual
    /// numbers, since the ordinality of zip codes only affects the
    /// geographic location of the zip codes.
    /// The intent is for there to be a seperate IZipCode implementer
    /// for each different kind of Post Code (i.e. Canada and the UK).
    /// IZipCode implementers are only comparable within the same 
    /// Postal Code type (i.e. U.S. post codes are only meaningfully
    /// comparable to other U.S. post codes).
    /// </summary>
    public interface IZipCode
    {
        String ZipCode { get; set; }
        //String Plus4 { get; set; }

        //String ZipPlus4();
        int Compare(IZipCode testValue);

        Boolean Validate(String testValue);
    }
}
