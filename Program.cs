using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");
            Console.WriteLine("Hello Class");
            Console.Write("Wat is uw naam? ");
            var ingevuld = Console.ReadLine();
            Console.WriteLine($"Hallo {ingevuld}");
            Console.ReadLine(); 

            if (ingevuld == "Rahmi")
            {
                Console.WriteLine("Hallo Rahmi");
            }
            else
            {
                Console.WriteLine("Goedenmorgen");
            }
            Console.Write("Wat is uw favorieten videogame");

            var videogame = Console.ReadLine();

            Console.WriteLine($"U heet {ingevuld} en uw favorieten game is {videogame}");

            Console.ReadLine();
        }
    }
}
