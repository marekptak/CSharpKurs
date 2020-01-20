using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Powitanie();

            Console.ReadKey();

        }


        /// <summary>
        /// Odczytuje imie z konsoli i wita po imieniu
        /// </summary>
        private static void Powitanie()
        {
            Console.Write("Podaj swoje imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
        }
    }
}
