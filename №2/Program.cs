using System;

namespace _2
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Напишите программу, которая будет выводить на экран таблицу умножения на 3.
        static void Main(string[] args)
        {
            Console.WriteLine("Выводит на экран таблицу умножения на 3");
            int number = 3, number1 = 0;
            for (int i = 0; i < 9; i++)
            {
                number1++;
                Console.WriteLine("3 * " +  number1 + " = " +(number * number1));
            }
        }
    }
}
