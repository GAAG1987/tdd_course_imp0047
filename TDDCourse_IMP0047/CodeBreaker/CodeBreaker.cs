using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBreaker
{
    public class CodeBreaker
    {
        public string Answer(int input)
        {

            char[] numero = new char[] { '5', '7', '1', '3' };
            char[] intento = input.ToString().ToCharArray();
            string existe = "";
            string posicion = "";

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (numero[i] == intento[j])
                    {
                        if (i == j)
                        {
                            posicion = posicion + "*";
                        }
                        else
                        {
                            existe = existe + "-";
                        }
                    }
                }
            }

            return posicion + existe;
        }

    }
}
