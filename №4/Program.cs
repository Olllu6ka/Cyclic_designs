using System;

namespace _4
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Напишите программу, которая будет рассчитывать сумму вклада в банк.Процентную ставку,
        //сумму и срок на которой положили вклад, должен вводить пользователь с клавиатуры.
        static void Main(string[] args)
        {
            int Sum, Time, InterestSupply, DepositAmount;
            Console.Write("Напишите сумму которую вы положили в банк = ");
            Sum = int.Parse(Console.ReadLine());
            Console.Write("Напишите срок вклада = ");
            Time = int.Parse(Console.ReadLine());
            Console.Write("Напишите на какой процент вы положили в банк = ");
            InterestSupply = int.Parse(Console.ReadLine());
            for (int i = 0; i < 1; i++)
            {
                DepositAmount = (Sum * InterestSupply * Time) / 100;
                Console.WriteLine("Ваша сумма вклада в банк = " + DepositAmount + "грн");
            }

        }
    }
}
