using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***START***");
            Console.WriteLine("Coffee ...");

            Coffee c = new Coffee();
            c.PrepareRecipe();

            Console.WriteLine("\nTea...");
            Tea t = new Tea();
            t.PrepareRecipe();

            Console.ReadLine();
        }
    }
}
