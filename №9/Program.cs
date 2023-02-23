using System;

namespace _9
{
    class Program
    {
     //Используя Visual Studio, создайте проект по шаблону Console Application.
     //Напишите программу, в которой запросите пользователя ввести два числа A и B(A<B), если(A>B
     //выведите соответствующее предупреждение) и выведите суму всех чисел расположенных между
     //данными числами на экран.Дано два числа A и B(A<B) выведите все нечетные значения,
     //расположенные между данными числами
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Введите число для а = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число для b = ");
            b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                b--;
                for (; b > a; b--)
                {
                    if (b % 2 != 0)
                    {
                        Console.WriteLine(b);
                    }
                }
            }
            else if (a > b)
            {
                Console.WriteLine("Предупреждение !");
                a--;
                for (; b < a; a--)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
