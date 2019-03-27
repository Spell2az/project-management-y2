using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClassLibrary.ApplicationsServices;
using Microsoft.Win32;
using Utilities;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
           // var generator = new ItemGenerator();


            Console.WriteLine(UserService.HashPassword("Pass@word1"));
            Console.ReadKey();

        }
    }
}
