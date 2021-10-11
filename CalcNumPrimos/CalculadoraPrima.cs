using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcNumPrimos
{
    class CalculadoraPrima
    {

        public bool Valid(int? numero)//dizer se a entrada de dados é válida
        {
            bool result = numero < 2 || numero == null ? false : true;// se entrar um numero menor que 2 ou nulo o retorno é falso
            return result;
        }

        public bool Primo(int? num)
        {
            if (!Valid(num))
            {
                return false;
            }
            else
            {
                int div = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        div++;
                    }
                }
                bool res_div = div == 2 ? true : false;//for simplificado
                return res_div;
            }

        }


        public object SomaPrimos(string primo)
        {
            int lim;
            bool bool_lim = int.TryParse(primo, out lim);

            if (bool_lim == false || lim < 1)
            {
                Console.WriteLine("Valor de entrada inválido");
                return 0;//perguntar se pode
            }
            else
            {
                Console.Write($"Números primos de 0 a {lim}: ");
                List<int> lista = new List<int>();

                for (int i = 0; i <= lim; i++)
                {
                    if (Primo(i))
                    {
                        lista.Add(i);
                        Console.Write(i + " ");
                    }
                }
                int result = lista.Sum(x => x);
                Console.WriteLine("\nSoma dos primos de 0 a " + lim + " é: " + result);
                return result;
            }
        }
    }
}
