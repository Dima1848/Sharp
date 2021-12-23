using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sharp;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Settings(out int minNumber, out int maxNumber)
        {
            string userValue;


            Console.WriteLine($"Введіть мінімальне значення:");
            userValue = Console.ReadLine();
            if (!int.TryParse(userValue, out minNumber))
            {
                Console.WriteLine("Введені некоректні дані");
            }
            Console.WriteLine($"Введіть максимальне значення:");
            userValue = Console.ReadLine();
            if (!int.TryParse(userValue, out maxNumber))
            {
                Console.WriteLine("Введені некоректні дані");
            }
        }
        public static void NewGame(int minNumber, int maxNumber)
        {
            string userValue;

            while (true)
            {
                Console.WriteLine($"Введіть число від {minNumber} до {maxNumber}:");

                userValue = Console.ReadLine();

                if (!int.TryParse(userValue, out int userNamber))
                {
                    Console.WriteLine("Введені некоректні дані");
                }
                else if (maxNumber < userNamber || userNamber < minNumber)
                {
                    Console.WriteLine("Введені некоректні дані");
                }
                else
                {

                    //Создание объекта для генерации чисел
                    Random rnd = new Random();

                    //Получить очередное (в данном случае - первое) случайное число
                    int value = rnd.Next(minNumber, maxNumber);

                    //Вывод полученного числа в консоль
                    Console.WriteLine(value);

                    int console = value;

                    if (console == userNamber)
                    {
                        Console.WriteLine("Ви виграли!");

                    }
                    else
                    {
                        Console.WriteLine("You loser");
                    }
                    Console.WriteLine("Продовжиш гру?(y/n)");
                    userValue = Console.ReadLine();
                    if (userValue.ToLower() == "n")
                    {
                        return;
                    }
                }
            }
        }
        public void Metod()
        {
            string userValue;
            int minNumber = 0;
            int maxNumber = 10;

            Console.WriteLine("Зіграємо в гру, я загадаю число а вам потрібно його відгадати...");
            while (true)
            {


                Console.WriteLine("1.New game");
                Console.WriteLine("2.Settings");
                Console.WriteLine("3.Exit");

                Console.WriteLine("Введіть дію:");
                userValue = Console.ReadLine();
                if (userValue.ToLower() == "1")
                {
                    NewGame(minNumber, maxNumber);
                }

                if (userValue.ToLower() == "2")
                {
                    Settings(out minNumber, out maxNumber);
                }

                if (userValue.ToLower() == "3")
                {
                    return;
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string userValue;
            int minNumber = 0;
            int maxNumber = 10;

            Console.WriteLine("Зіграємо в гру, я загадаю число а вам потрібно його відгадати...");
            while (true)
            {


                Console.WriteLine("1.New game");
                Console.WriteLine("2.Settings");
                Console.WriteLine("3.Exit");

                Console.WriteLine("Введіть дію:");
                userValue = Console.ReadLine();
                if (userValue.ToLower() == "1")
                {
                    NewGame(minNumber, maxNumber);
                }

                if (userValue.ToLower() == "2")
                {
                    Settings(out minNumber, out maxNumber);
                }

                if (userValue.ToLower() == "3")
                {
                    return;
                }
            }
        }
        public static int GetValue(string massage)
        {
            Console.WriteLine(massage);
            string userValue;
            while (true)
            {
                userValue = Console.ReadLine();
                if (int.TryParse(userValue, out int namber))
                {
                    return namber;
                }
                Console.WriteLine("Введено некоректні дані");
            }

        }
    }
}


