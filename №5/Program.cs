using System;

namespace _5
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Напишите программу, где пользователь вводит любое целое положительное число.А программа
        //суммирует все числа от 1 до введенного пользователем числа.
        static void Main(string[] args)
        {
            int number, number1,number2;
            Console.Write("Введите целое положительное число = ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Введите число до кокого вы хотите суммировать = ");
            number1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < number1; i++)
            {
                Console.WriteLine("Суммируем = "+ number + "+" + number1 + " = " + (number + number1));
                number1--;
            }

        }
    }
}
