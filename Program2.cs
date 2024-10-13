using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program2
    {
        public static string Divisible(int input1, int input2)
        {
            if(input1%input2==0)
            {
                return "num1 is divisible to num2.";
            }
            else if(input2%input1==0)
            {
                return "num2 is divisible to num1.";
            }
            else
            {
                return "These Numbers are not divisible to each other.";
            }
            //or
            //Console.WriteLine(input1 + input2 + input3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter num2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Divisible(input1: num1, input2: num2));

        }
    }
}
