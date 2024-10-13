using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program5
    {
        public static int Calculation(int input1, int input2, int input3)
        {
            int result = 0;
            //result = input1 + (input3 - 1) * input2;
            //or
            result = input1;
            for (int i = 1; i < input3; i++)
            {
                result += input2;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int a0 = 0;
            int d = 0;
            int n = 0;
            Console.WriteLine("please enter initial value:");
            a0 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter difference value:");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter Nomber of numbers:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"result={Calculation(a0, d, n)}");
        }
    }
}
