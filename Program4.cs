using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program4
    {
        public static int Smaller(int input1, int input2, int input3, int input4, int input5)
        {
            int min1 = 0;
            int min2 = 0;
            int min = 0;
            if(input1<input2)
            {
                min1= input1;
            }
            else
            {
                min1 = input2;
            }
            if(input3<input4)
            {
                min2 = input3;
            }
            else
            {
                min2 = input4;
            }
            if (min2 < min1)
            {
                min = min2;
            }
            else
            {
                min = min1;
            }
            if(input5 < min)
            {
                return input5;
            }
            else
            {
                return min;
            }
            //or
            //Console.WriteLine(input1 + input2 + input3);
        }
        static void Main(string[] args)
        {
            int input_nom = 0;
            int num1 = 10000000;
            int num2 = 10000000;
            int num3 = 10000000;
            int num4 = 10000000;
            int num5 = 10000000;
            Console.WriteLine("please enter Nomber of inputs (2<=Nom<=5):");
            input_nom = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter num2:");
            num2 = int.Parse(Console.ReadLine());
            if (input_nom >= 3)
            {
                Console.WriteLine("please enter num3:");
                num3 = int.Parse(Console.ReadLine());
                if (input_nom >= 4)
                {
                    Console.WriteLine("please enter num4:");
                    num4 = int.Parse(Console.ReadLine());
                    if (input_nom == 5)
                    {
                        Console.WriteLine("please enter num5:");
                        num5 = int.Parse(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine($"Min. is {Smaller(input1: num1, input2: num2, input3: num3, input4: num4, input5: num5)}");
        }
    }
}
