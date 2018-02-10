using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.app
{
    public class NumberConverter
    {
        public string Parse(int number)
        {
            switch (number)
            {
                case 1:
                    return "I";
                case 5:
                    return "V";
                case 9:
                    return "IX"; 
            }

            return "another thing";
        }
    }
}
