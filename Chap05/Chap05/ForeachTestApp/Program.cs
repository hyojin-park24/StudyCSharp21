using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sources = { 1, 2, 3, 4, 5, 3, 6, 7, 8, 9, 10 };

           //랙\\f;
            for (int i = 0; i < sources.Length; i++)
            {
                Console.WriteLine($"sources[i] = {sources[i]}");
            }
            //foreach
            Console.WriteLine("Foreach문");
            var idx = 0;
            foreach(var item in sources)
            {
                Console.WriteLine($"sources = { item}");
            }
        }
    }
}
