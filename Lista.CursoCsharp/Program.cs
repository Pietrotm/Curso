using System;
using System.Collections.Generic;

namespace Lista.CursoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos p = new Produtos();
            //
            Console.Write("Digite o nome do produto: ");
            p.Noome = Console.ReadLine();
            //
            Console.Write("Digite o preço do produto: ");
            p.Prreco = double.Parse(Console.ReadLine());
            //
            Console.Write("Digite a quantidade do produto: ");
            p.Quuantidade = int.Parse(Console.ReadLine());
            //
            Console.WriteLine("\n {0}", p.ToText());
        }
    }
}
