using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.DataSources
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class DataSource : IDataSource
    {
        public bool Connect()
        {
            throw new NotImplementedException();
        }

        public bool Disconnect()
        {
            throw new NotImplementedException();
        }

        public object GetField(string fieldName)
        {
            throw new NotImplementedException();
        }

        public object Query(object requested)
        {
            throw new NotImplementedException();
        }

        public object Rollback()
        {
            throw new NotImplementedException();
        }

        public bool Update(object requested)
        {
            throw new NotImplementedException();
        }

        object IDataSource.Inititialize()
        {
            throw new NotImplementedException();
        }

        object IDataSource.Inititialize(string connectionString)
        {
            throw new NotImplementedException();
        }
    }
}
