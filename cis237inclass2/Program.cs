﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();

            Console.WriteLine("Solve 5!");
            Console.WriteLine("The answer is:");
            //Call to Factorial class. The factorial instance is created in program.cs
            Console.WriteLine(factorial.CalculateFactorial(5));

        }
    }
}
