using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core
{
    /// <summary>
    /// All the Wolf1 classes implement BaseObject. It specifies
    /// no methods otherwise.
    /// </summary>
    interface IBaseObject
    {
        Management.AccessControlList ACL { get; set; }
    }
}
