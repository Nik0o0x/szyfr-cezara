using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Szyfr_Cezara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość przesunięcia:");
            int szyfr;
            szyfr = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj teskt do zmienienia:");
            foreach (var c in Console.ReadLine())
            {
                Console.Write(Convert.ToChar((c - 'a' + szyfr) % ('z' - 'a' + szyfr) + 'a'));
            }
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}