using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    public class Validator
    {
        public static bool validateVNumber(string radius, ref double ValidNumber)
        {
            bool ValidNum = double.TryParse(radius, out ValidNumber);
            return ValidNum;
        }
    }
}
