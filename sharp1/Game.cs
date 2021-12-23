using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

namespace sharp
{
    internal class Game
    {
        public GameSettings Settings { get; set; }
        public int RoundomNumber
        {
            get
            {
                //Создание объекта для генерации чисел
                Random rnd = new Random();

                //Получить очередное (в данном случае - первое) случайное число
                int value = rnd.Next(Settings.MinNumber, Settings.MaxNumber);
                return value;
            }

        }

        public Game()
        {
            Settings = new GameSettings { MinNumber = 0, MaxNumber = 10 };
        }

        public bool Equal(int number)
        {
            return number == RoundomNumber;
        }

        public void ShowMenu()
        {
            Console.WriteLine("1.New game");
            Console.WriteLine("2.Settings");
            Console.WriteLine("3.Exit");
        }

    }
}
