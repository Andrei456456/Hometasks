﻿using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("BLR - Вiтаем! Гэтая праграма навучыць Вас назвам дзен тыдня па парадку на розных мовах.");
            //Console.WriteLine("      Увядзiце любы нумар дня тыдня ад 1 да 7:");
            //Console.WriteLine("");
            //Console.WriteLine("RU  - Приветствуем! Эта программа научит Вас названиям дней недели по порядку на разных языках.");
            //Console.WriteLine("      Введите любой номер дня недели от 1 до 7:");
            //Console.WriteLine("");
            Console.WriteLine("      Hello! This program will teach you the names of the days of the week in order in different languages.");
            Console.WriteLine("      Enter any day number of the week from 1 to 7:");
            Console.WriteLine();
            int buttom1 = 1;
            do
            {
                string number = Console.ReadLine();
                if ((number == "1") || (number == "2") || (number == "3") || (number == "4") ||
                (number == "5") || (number == "6") || (number == "7"))
                {
                    switch (number)
                    {
                        case "1":
                            Console.WriteLine("1 - панядзелак(BLR) - понедельник(RU) - monday(ENG)");
                            break;
                        case "2":
                            Console.WriteLine("2 - аўторак(BLR) - вторник(RU) - tuesday(ENG)");
                            break;
                        case "3":
                            Console.WriteLine("3 - серада(BLR) - среда(RU) - wednesday(ENG)");
                            break;
                        case "4":
                            Console.WriteLine("4 - чацвер(BLR) - четверг(RU) - thursday(ENG)");
                            break;
                        case "5":
                            Console.WriteLine("5 - пятнiца(BLR) - пятница(RU) - friday(ENG)");
                            break;
                        case "6":
                            Console.WriteLine("6 - субота(BLR) - суббота(RU) - saturday(ENG)");
                            break;
                        case "7":
                            Console.WriteLine("7 - нядзеля(BLR) - воскресенье(RU) - sunday(ENG)");
                            break;
                    }
                }
                else
                {
                    //Console.WriteLine("BLR - некаррэктныя дадзеныя.");
                    //Console.WriteLine("RU - некорректные данные.");
                    Console.WriteLine("incorrect data.");
                }
                int buttom2 = 1;
                do
                {
                    Console.WriteLine("one more time? - yes/no");
                    string wants = Console.ReadLine();
                    if (wants == "yes")
                    {
                        buttom1 = 1;
                        buttom2 = 0;
                        Console.WriteLine("Enter any day number of the week from 1 to 7:");
                    }
                    else if (wants == "no")
                    {
                        buttom1 = 0;
                        buttom2 = 0;
                        Console.WriteLine("Thanks, see you :)");
                    }
                    else
                    {
                        Console.WriteLine("incorrect");
                        buttom2 = 1;
                    }
                } while (buttom2 > 0);
            } while (buttom1 > 0);
        }
    }
}
