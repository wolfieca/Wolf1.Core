using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core
{
    /// <summary>
    /// 
    /// </summary>

    public interface IDataSource
    {
        Object Inititialize();
        Object Inititialize(String connectionString);

        Boolean Connect();
        Boolean Disconnect();

        Object Query(Object requested);
        Boolean Update(Object requested);

        Object GetField(String fieldName);

        Object Rollback();
     }
}
