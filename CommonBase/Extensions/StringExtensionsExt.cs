using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBase.Extensions
{
    partial class StringExtensions
    {
        public static bool IsValidSSN(this string ssn)
        {
            if (ssn == null || ssn.Length != 10)
                return false;

            ssn.Trim();

            int sum = 0;
            int[] weights = { 3, 7, 9, 0, 5, 8, 4, 2, 1, 6 };

            for (int i = 0; i < weights.Length; i++)
            {
                if (i == 3)
                    continue;

                if (Int32.TryParse(ssn[i].ToString(), out int num))
                    sum += num * weights[i];
                else
                    return false;
            }

            int calculatedChecksum = sum % 11;

            int referenceChecksum;
            if(Int32.TryParse(ssn[3].ToString(), out referenceChecksum))
            {
                return (calculatedChecksum == referenceChecksum);
            }

            return false;
        }

        public static bool IsValidDrugNumber(this string str)
        {
            if (str == null || str.Length != 10)
                return false;


            int sum = 0;
            for (int i = 0; i < str.Length-1; i++)
            {
                if (Int32.TryParse(str[i].ToString(), out int num))
                    sum += num * (i + 1);
                else
                    return false;
            }

            if (Int32.TryParse(str[9].ToString(), out int checksum))
                return (checksum == (sum % 11));
            else
                return false;

        }
    }
}
