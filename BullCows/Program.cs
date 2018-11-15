using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullCows
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var game = new Game();
            var game2 = new Game2();
            int r = 0;
            Console.WriteLine("Выберите режим игры:");
            Console.WriteLine(" 1.Вы угадываете число");
            Console.WriteLine(" 2.Компьютер угадывает число");
            int z = int.Parse(Console.ReadLine());

            switch (z)
            {
                case 1:
                    for (int i = 0; i < 4; ++i)
                    {
                        int n;
                        do
                        {
                            n = rand.Next(1, 9);
                            for (int j = 0; j < i; ++j)
                            {
                                if (game.num[j] == n)
                                {
                                    n = -1;
                                    break;
                                }
                            }
                        } while (n < 0);
                        game.num[i] = n;
                    };

                    while (game.bull != 4)
                    {
                        Console.WriteLine("Введите число: ");
                        for (int i = 0; i < 4; i++)
                            game.num1[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("Вы ввели число: ");
                        for (int i = 0; i < 4; i++)
                            Console.Write(game.num1[i]);
                        Console.WriteLine();

                        game.CheckBullCow();
                        r++;
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                    };
                    Console.Write("Вы угадали число " );
                    for (int i = 0; i < 4; i++)
                        Console.Write(game.num1[i]);
                    Console.Write(" за " + r + " попыток !");
                    break;

                case 2:
                    Console.WriteLine("Введите число: ");
                    for (int i = 0; i < 4; i++)
                        game2.num2[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    game2.CheckBullCow();
                    Console.Write("Компьютер угадал ваше число за " + game2.c + " ходов: ");
                    for (int i = 0; i < 4; i++)
                        Console.Write(game2.num2_2[i]);
                    break;

                default:
                    Console.WriteLine("Вы неправильно выбрали режим игры");
                    break;
            }

            Console.ReadKey();
        }
    }
}
