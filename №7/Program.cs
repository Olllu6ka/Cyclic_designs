using System;

namespace _7
{
    class Program
    {
      //Используя Visual Studio, создайте проект по шаблону Console Application.
      //Напишите программу, в которой создайте две целочисленные переменные и задайте им
      //некоторые значения.Применяя технику вложенных циклов, нарисуйте прямоугольник из
      //звездочек. Используйте значения ранее созданных переменных для указания высоты и ширины
     //прямоугольника
        static void Main(string[] args)
        {
            int Height = 8, Width = 15;
            for (int i = 0; i < Height; i++)
            {
                for (int g = 0; g < Width; g++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }


        }
    }
}
