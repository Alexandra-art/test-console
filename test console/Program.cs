﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x>");
            string x_str = Console.ReadLine();
            Console.Write("Введите y>");
            string y_str = Console.ReadLine();
            int x = int.Parse(x_str);
            int y = int.Parse(y_str);
            int z = x + y;
            Console.WriteLine($"{x}+{y}={z}");


                }
    }
}
