using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word");
            Console.WriteLine("Args Length:" + args.Length);

            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("argw[" + i + "] = " + args[i]);
            }

            Console.ReadKey();
        }
    }
}
