using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new ItemGenerator();
         
            Console.WriteLine(generator.GetJson());
            Console.ReadKey();
        }
    }
}
