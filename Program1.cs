using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program1
    {
        /// <summary>
        /// Method for adding numbers
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="input3"></param>
        public static void Add(int input1, int input2, int input3)
        {
            int result = input1 + input2 + input3;
            Console.WriteLine($"result={result.ToString()}");
            //or
            //Console.WriteLine(input1 + input2 + input 3);
        }
        static void Main(string[] args)
        {
            int input_nom = 0;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Please enter nomber of inputs (2 or 3):");
            input_nom = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter num1:");
            num1 = int.Parse(Console.ReadLine());
            if (input_nom >= 2)
            {
                Console.WriteLine("please enter num2:");
                num2 = int.Parse(Console.ReadLine());
            }
            if (input_nom == 3)
            {
                Console.WriteLine("please enter num3:");
                num3 = int.Parse(Console.ReadLine());
            }
            Add(input1: num1, input2: num2, input3: num3);

        }
    }
}
