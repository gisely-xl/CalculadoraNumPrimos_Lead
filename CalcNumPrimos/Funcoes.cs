using System;
using System.Collections.Generic;
using System.Text;

namespace CalcNumPrimos
{
    class Funcoes
    {
        public int Div, Num;

        public bool VerifPrimo(int num)
        {
            Num = num;
            Div = 0;

            for (int i = 1; i <= Num; i++)//for para determinar o numero de divisores do numero a ser testado
            {
                if(Num % i == 0)
                    {
                        Div++;
                    }
            }

            if(Div == 2)//Se tiver dois divisores, então é primo
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    
       
    }
}
