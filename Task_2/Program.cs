using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        public static int result = 0;
        //•	Задача 2: Напишите программу, которая вычисляет сумму чисел от 1 до 100.
        static void Main(string[] args)
        {
            for(int i = 1; i < 101; i++)
            {
                result += i;
            }
            Console.WriteLine("Сумма чисел равна: " + result);
        }
    }
}
