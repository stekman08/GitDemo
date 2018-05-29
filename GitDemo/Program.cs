using System;
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
            Console.Read();
        }

        static double Pythagoras(double a, double b) {
            return Math.Sqrt(a * a + b * b);
        }
    }
}
