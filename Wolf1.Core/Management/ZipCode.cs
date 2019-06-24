using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    /// <summary>
    /// Zip reflects U.S.-style zip codes. Zip objects can only be compared
    /// with other Zip Objects. And only the base segment of the Zip is used
    /// for comparison.
    /// U.S. Zip Codes are in the form NNNNN-NNNN w
    /// </summary>
    public class Zip : IZipCode
    {
        private int _ZipBase;
        private int _ZipPlus4;
        public string Plus4 { get => _ZipPlus4.ToString(); set => _ZipPlus4 = int.Parse(value); }
        public string ZipCode { get => _ZipBase.ToString(); set => _ZipBase = int.Parse(value); }

        /// <summary>
        /// Compare this Zip Code with another. Only the Base segmnt of the 
        /// Zip code is used for these comparisons, so 93230-0950 and 93230-0951 will
        /// test as equal.
        /// </summary>
        /// <param name="testValue">Zip to compare agains</param>
        /// <returns>   1 if testValue is higher than this Zip Code
        ///             0 if testValue and this Zip Code are the same
        ///             -1 if testValue is lower than this Zip Code</returns>
        public int Compare(IZipCode testValue)
        {
            return int.Parse(ZipCode) - int.Parse(testValue.ZipCode);
        }

        /// <summary>
        /// Validate a ZipCode value. 
        /// </summary>
        /// <param name="testValue"></param>
        /// <returns></returns>
        public Boolean Validate(String testValue)
        {
            if (int.TryParse(testValue, out int x))
                return true;
            else
                return false;
        }
 
        /// <summary>
        /// Compare two Zip Codes
        /// </summary>
        /// <param name="z1">The first Zip Code in the comparion</param>
        /// <param name="z2">The second Zip Code in the comparison</param>
        /// <returns>   1 if the z1 has a higher ZipBase than z2
        ///             0 if z1 and z2 have the same ZipBases
        ///             -1 if z1 has a lower ZipBase than z2</returns>
        public static int Compare (Zip z1, Zip z2)
        {
            return int.Parse(z1.ZipCode)-int.Parse(z2.ZipCode);
        }

        /// <summary>
        /// Return this instance formatted in the USPS NNNNN-NNNN format.
        /// </summary>
        /// <returns></returns>
        public string ZipPlus4()
        {
            //return ZipCode.ToString("D5") + "-" + ZipCode.ToString("D4");
            return $"{ZipCode:D5}-{Plus4:D4}";
        }

        /// <summary>
        /// < operator
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static Boolean operator < (Zip z1, Zip z2)
        {
            return int.Parse(z1.ZipCode) < int.Parse(z2.ZipCode);
        }
 
        /// <summary>
        /// > operator
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static Boolean operator > (Zip z1, Zip z2)
        {
            return int.Parse(z1.ZipCode) > int.Parse(z2.ZipCode);
        }

        /// <summary>
        /// <= operator
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static Boolean operator <= (Zip z1, Zip z2)
        {
            return int.Parse(z1.ZipCode) > int.Parse(z2.ZipCode);
        }

        /// <summary>
        /// >= operator
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static Boolean operator >= (Zip z1, Zip z2)
        {
            return int.Parse(z1.ZipCode)>=int.Parse(z2.ZipCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static Boolean operator == (Zip z1, Zip z2)
        {
            return int.Parse(z1.ZipCode)==int.Parse(z2.ZipCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static Boolean operator !=(Zip z1, Zip z2)
        {
            return int.Parse(z1.ZipCode) != int.Parse(z2.ZipCode);
        }
    }
}
