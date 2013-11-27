
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanConverter
{
    public class RomanConverter
    {
        public string Answer(int input)
        {
            string[] units = {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};

            int unit = (input % 10)-1;

            return units[unit];
        }
    }
}
