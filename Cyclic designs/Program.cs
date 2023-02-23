using System;

namespace Cyclic_designs
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Напишите программу, которая будет выводить на экран числа от 1 до 5. Написать три варианта
        //реализации(while, do...while, for).
        static void Main(string[] args)
        {
            int number = 1,Variant = 0;
            Console.Write("Ваше число = 0 и мы вам выводим от 1 до 5 " + 
                "\nЕсть три варианта выполнения действия - 1)while 2)Do...While 3)For = ");
            Variant = int.Parse(Console.ReadLine());
            if (Variant == 1 )
            {
                while (number < 5)
                {
                    Console.WriteLine(number);
                    number++;
                }
            }
            else if (Variant == 2)
            {
                do
                {
                    Console.WriteLine(number);
                    number++;
                } while (number < 5);
            }
            else if (Variant == 3)
            {
                for (int i = 0; i < 4; i ++)
                {
                    Console.WriteLine(number);
                    number++;
                }
            }
        }
    }
}
