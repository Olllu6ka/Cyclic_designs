using System;

namespace _3
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Напишите программу, в которой даны натуральные числа от 20 до 50. Вывести на консоль те из
        //них, которые делятся на 3, но не делятся на 5.
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод чисел которые деляться на 3 но на 5 не деляться ");
            for (int number = 19; number <= 50; number++)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine("Число делиться на 3 =  " + number);
                    //Console.WriteLine();
                }
                else if (number % 5 != 0)
                {
                    Console.WriteLine("\tЧисло не делиться на 5 = " + number);
                }
            }
        }
    }
}
