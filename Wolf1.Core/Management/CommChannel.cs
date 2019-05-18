using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    /// <summary>
    /// 
    /// </summary>

    public abstract class CommChannel
    {
        /**
         * The init methods provide ways to intialize CommChannel objects. The default init method
         * looks for defaults from a set of configuration files.
         */
        public abstract void Init();
        
    }
}
