using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program3
    {
        public static bool ODD_OR_EVEN(int input1)
        {
            if (input1%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //or
            //Console.WriteLine(input1 + input2 + input3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($" {num1} is an even number:{ODD_OR_EVEN(input1: num1)}");

        }
    }
}
