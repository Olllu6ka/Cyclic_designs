using System;

namespace _6
{
    class Program
    {
      //. Используя Visual Studio, создайте проект по шаблону Console Application.
      //Напишите программу, которая поможет первокласнику Пети, у которого m грн.Мороженое
      //стоит k грн.Петя решил наесться досыта мороженого, для этого он покупал по одному
      //мороженому и съедал его до тех пор, пока ему хватало денег. Как Пете узнать, сколько денег
      //останется у него в конце концов? учтите, что петя делить еще не умеет, а умеет только вычитать и
      //складывать. сколько мороженых он может съесть?
        static void Main(string[] args)
        {
            int money = 0, ice = 0, day = 0, moneyf = 0,breaka = 0;
            Console.Write("Петя введи сколько грн у тебя есть = ");
            money = int.Parse(Console.ReadLine());
            Console.Write("Петя введи сколько стоит мороженое = ");
            ice = int.Parse(Console.ReadLine());
            for (; ;)
            {
                moneyf = money - ice;
                money = moneyf;
                if (money < 0 )
                {
                    Console.WriteLine("Петя у тебя закончились деньги !");
                    Console.WriteLine("Вот столько дней подряд ты можешь кушать мороженое = " + day + " дней");
                    breaka = 0;
                    if (breaka == 0)
                    {
                        break;
                    }
                }
                day++;
            }
            
        }
    }
}
