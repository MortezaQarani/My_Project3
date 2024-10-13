using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program6
    {
        public static int Calculation(int input1)
        {
            int result = 0;
            double m1 = (1 + Math.Sqrt(5)) / 2;
            result = (int) ((Math.Pow(m1, input1) - Math.Pow(1 - m1, input1)) / Math.Sqrt(5));        
            return result;
        }
        static void Main(string[] args)
        {
            int a0 = 0;
            int d = 0;
            int n = 0;
            //Console.WriteLine("please enter initial value:");
            //a0 = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter difference value:");
            //d = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter Nomber of numbers(>=1):");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"result={Calculation(n)}");
        }
    }
}
