﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the donjo...");
            Demo.Hello("It's me! Fredrik!");


            Console.WriteLine("Hello my dear branch. This is my branch.");
            Console.WriteLine(Pythagoras(2,2) + " some math for the sake of math");
            Console.Read();
        }

        static double Pythagoras(double a, double b) {
            return Math.Sqrt(a * a + b * b);
        }
    }
}
