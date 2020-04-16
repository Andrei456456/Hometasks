using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Будем изучать таблицу умножения.");
            Console.WriteLine("Будем умножать выбранное число на числа от 1 до 10.");
            Console.WriteLine("Введите любое 63-разрядное целое число со знаком, без разделительных знаков (и желательно без фанатизма):");
            Console.WriteLine();
            int buttom1 = 1;
            do
            {
                string number = Console.ReadLine();

                try
                {
                    long number1 = Convert.ToInt64(number);

                    for (int i = 1; i < 11; i++)
                    {
                        Console.WriteLine(number1 + " * " + i + " = " + number1 * i + ";");
                    }

                    //Console.WriteLine(number1 + " * 10 = " + number1*10);

                }
                catch (FormatException)
                {
                    Console.WriteLine("Введенные данные не соответствуют требованиям по формату.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Число не может вписаться в формат long. Ну и зачем эти сложности? ;)");
                }

                int buttom2 = 1;
                do
                {
                    Console.WriteLine("еще раз поумножаем? - да/нет");
                    string wants = Console.ReadLine();
                    if (wants == "да")
                    {
                        buttom1 = 1;
                        buttom2 = 0;
                        Console.WriteLine("Введите любое 63-разрядное целое число со знаком (желательно без фанатизма):");
                    }
                    else if (wants == "нет")
                    {
                        buttom1 = 0;
                        buttom2 = 0;
                        Console.WriteLine("Благодарим, до встречи :)");
                    }
                    else
                    {
                        Console.WriteLine("попробуйте снова правильно ввести без ошиюок - да/нет.");
                        buttom2 = 1;
                    }
                } while (buttom2 > 0);
            } while (buttom1 > 0);
        }

    }
}   

