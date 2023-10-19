using System;

namespace Aula_19_10_2023_While_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator, contadorFinal;
            string simbolo;

            Console.Write("Informe um fator: ");
            fator = int.Parse(Console.ReadLine());

            Console.Write("Informe um fator Final: ");
            contadorFinal = int.Parse(Console.ReadLine());

            Console.Write("Informe um fator Final: ");
            simbolo = Console.ReadLine();

            //2 x 1 = 2
            int contador = 1;
            while (contador <= contadorFinal)
            {
                if (simbolo == "+")
                    Console.WriteLine($"{fator} + {contador} = {fator + contador}");
                else if (simbolo == "-")
                    Console.WriteLine($"{fator} - {contador} = {fator - contador}");
                else if (simbolo == "*")
                    Console.WriteLine($"{fator} x {contador} = {fator * contador}");
                else if (simbolo == "/")
                    Console.WriteLine($"{fator} / {contador} = {fator / contador}");
                else
                    Console.Write("Operador Invalido");
                //contador = contador + 1;
                contador++;
            }
            Console.Write("***Fim da Tabuada***");
        }
    }
}
