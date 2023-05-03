using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1;
            int a2;

            Console.Write("insira o Primeiro algarismo: ");
            a1 = int.Parse(Console.ReadLine());

            Console.Write("insira o Segundo algarismo Diferente ao segundo: ");
            a2 = int.Parse(Console.ReadLine());

            if (a1 > a2)
                Console.WriteLine("O Primeiro ({0}) é maior que o Segundo ({1})", a1, a2);
            else
                Console.WriteLine("O Segundo ({1}) é maior que o Primeiro ({0})", a1, a2);
        }
    }
}
