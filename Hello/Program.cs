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
            NewMethod();

            Console.ReadKey();

        }
        //
        private static void NewMethod()
        {
            Console.Write("Podaj swoje imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
        }
    }
}
