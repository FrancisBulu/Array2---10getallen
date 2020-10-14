using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2___10getallen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef 10 getalen in");
            int[] getal = new int[10];

            for (int i = 0; i < 10; i++)
            {
                getal[i] = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"Jouw getal nummer {i+1} is: {getal[i]}");
            }

        }
    }
}
