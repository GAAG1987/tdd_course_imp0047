using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBreaker
{
    public class CodeBreaker
    {
        public string Answer(string input)
        {
            if(input.Length==4)
            {
                return "4";
            }



            return input.Length.ToString();
        }

    }
}
