using System;


namespace CalcNumPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraPrima funcoes = new CalculadoraPrima();
            Console.Write("Digite o valor limite: ");
            var lim = Console.ReadLine(); // para aceitar todo tipo de entrada
            funcoes.SomaPrimos(lim);
        }
    }
}
