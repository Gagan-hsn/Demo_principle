using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("interest calculation");
            Console.WriteLine("enter principal amt");
            int principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter rate of interest");
            int rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter time ");
            int time = Convert.ToInt32(Console.ReadLine());
            double interest = principal * rate * time / 100;
            Console.WriteLine($"the interest is {interest}");
        }
    }
}