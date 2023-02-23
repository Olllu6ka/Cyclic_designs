using System;

namespace _._10
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Напишите программу, которая будет складывать, вычитать, умножать или делить два числа.
        //Числа и знак операции вводятся пользователем.После выполнения вычисления программа не
        //должна завершаться, а должна запрашивать новые данные для вычислений.Завершение
        //программы должно выполняться при вводе символа '0' в качестве знака операции. Если
        //пользователь вводит неверный знак (не '0', '+', '-', '*', '/'), то программа должна сообщать ему об
        //ошибке и снова запрашивать знак операции.Также сообщать пользователю о невозможности
        //деления на ноль, если он ввел 0 в качестве делителя.
        static void Main(string[] args)
        {
            int Number, Number1, OperationForNumber,breaka = 1;
            string Operation = null;
            for (; ;)
            {
                Console.Write("Введите первое число = ");
                Number = int.Parse(Console.ReadLine());
                Console.Write("Введите второе число = ");
                Number1 = int.Parse(Console.ReadLine());
                Console.Write("Каркулятор" + "\nФункци = 1)0 - Завершение програмы " + "2)+ 3)- 4)* 5)/"
                    + "\nВведите знак из представленых перед вами = ");
                Operation = Console.ReadLine();
                switch (Operation)
                {
                    case "+":
                        Console.WriteLine("Сложение - " + (Number + Number1));
                        break;
                    case "-":
                        Console.WriteLine("Выберите над каким мы бдуем делать вычитание " + "\nЕсли над первым то напишите 1 если второе то 2");
                        OperationForNumber = int.Parse(Console.ReadLine());
                        if (OperationForNumber == 1)
                        {
                            Console.WriteLine("Вычитание - " + (Number - Number1));
                        }
                        else if (OperationForNumber == 2)
                        {
                            Console.WriteLine("Вычитание - " + (Number1 - Number));
                        }
                        break;
                    case "*":
                        Console.WriteLine("Умножение - " + (Number * Number1));
                        break;
                    case "/":
                            Console.WriteLine("Выберите над каким мы бдуем делать деление " + "\nЕсли над первым то напишите 1 если второе то 2");
                            OperationForNumber = int.Parse(Console.ReadLine());
                            if (OperationForNumber == 1)
                            {
                                if (Number1 == 0)
                                {
                                    Console.WriteLine("Делить на ноль нельзя");
                                }
                                Console.WriteLine("Деление - " + (Number / Number1));
                            }
                            else if (OperationForNumber == 2)
                            {
                                Console.WriteLine("Деление - " + (Number1 / Number));
                                if (Number == 0)
                                {
                                    Console.WriteLine("Делить на ноль нельзя");
                                }
                            }
                        break;
                    case "0":
                        Console.WriteLine("Прогрмма закрывается :) ");
                        breaka = 0;
                        break;
                }
                if (breaka == 0 )
                {
                    break;
                }
            }
        }
    }
}
