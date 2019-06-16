using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public class Zip : IZipCode
    {
        private int _ZipBase;
        private int _ZipPlus4;
        public string Plus4 { get => _ZipPlus4.ToString(); set => throw new NotImplementedException(); }
        public string ZipCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Compare(IZipCode testValue)
        {
            throw new NotImplementedException();
        }

        public string ZipPlus4()
        {
            throw new NotImplementedException();
        }

        public static Boolean operator < (Zip z1, IZipCode z2)
        {
            return false;
        }

        public static Boolean operator > (Zip z1, IZipCode z2)
        {
            return false;
        }

        public static Boolean operator <= (Zip z1, IZipCode z2)
        {
            return false;
        }

        public static Boolean operator >= (Zip z1, IZipCode z2)
        {
            return false;
        }

        public static Boolean operator == (Zip z1, IZipCode z2)
        {
            return false;
        }

        public static Boolean operator !=(Zip z1, IZipCode z2)
        {
            return false;
        }
    }
}
