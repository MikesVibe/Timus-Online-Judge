using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var intigers = input.Split(" ");

            int output = 1;
            foreach (var intiger in intigers)
            {
                output *= Int32.Parse(intiger);
            }
            output *= 2;
            Console.WriteLine(output);
        }
    }
}