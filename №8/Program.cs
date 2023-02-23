using System;

namespace _8
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Напишите программу, которая выводит на экран столько элементов ряда Фибоначчи, сколько
        //указал пользователь.Например, если на ввод поступило число 6, то вывод должен содержать
        //шесть первых чисел ряда Фибоначчи: 1 2 3 5 8 13. (Числа Фибоначчи - элементы числовой
        //последовательности, в которой первые два числа равны либо 1 и 1, либо 0 и 1, а каждое
        //последующее число равно сумме двух предыдущих чисел, например 0, 1, 1, 2, 3, 5, 8, 13, 21, 34,55, 89).
        static void Main(string[] args)
        {
            int number1 = 1, number2 = 1, number3, UserNumber;
            Console.Write("Напишите до какого элементов ряда Фибоначчи вы хотите получить = ");
            UserNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            for (int i = 2; i < UserNumber; i++)
            {
                number3 = number1 + number2;
                Console.WriteLine(number3);
                number1 = number2;
                number2 = number3;


            }

        }
    }
}
