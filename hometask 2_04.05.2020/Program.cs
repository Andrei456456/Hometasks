using System;
using System.Collections.Generic;
using System.Text;

namespace Salad_Chef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("            -----   SALAD   CHEF   -----          ");
            Console.WriteLine(" ");

            Console.WriteLine("Greetings! This program will help you prepare a salad of different ingredients!");
            Console.WriteLine(" ");
            Console.WriteLine("Program work order: 1.To go to the next line - push Enter;");
            Console.Write("2. All numbers entered are of INT-type, and greater than zero.");
            Console.ReadLine();
            Console.Write("List of products available today:");
            Console.ReadLine();
            
            //Print a first table with some vegetables
            СalculationAndPrintFirstDataTable firstTable = new СalculationAndPrintFirstDataTable();
            firstTable.СalculationAndPrintFirstDataTableMain();
            //Console.WriteLine("Main menu of this program:");
            //Console.WriteLine(" 1 - Print first table with vegetables");
            //Console.WriteLine(" 2 - Make a salad and count its calories");
            //Console.WriteLine(" 3 - Sort a first table with vegetables");
            //Console.WriteLine("What do you whant to do? Choose 1, 2 or 3 and enter:");

            SortFirstData sortFirstData = new SortFirstData();
            sortFirstData.SortFirstDataMain();

            //Make a salad
            Console.Write("Fine! Will we make a salad? Of course!!!");
            Console.ReadLine();
            //Console.WriteLine("Итак, с чего начнем? Давайте с простого!" +
            //   " Рекомендуем сначала приготовить порцию на 1 взрослого человека - 200...300 грамм. ");

            MakeASalad salad = new MakeASalad();
            salad.MakeASaladMain();
            Console.WriteLine("And here it is! Your salad! ");
            PrintASalad printASalad = new PrintASalad();
            printASalad.PrintASaladMain();
            Console.Write("MMMMMM.....delicious!!!");
            Console.ReadLine();

            CaloriesASalad caloriesASalad = new CaloriesASalad();
            caloriesASalad.CaloriesASaladMain();

            FindSortRangeASalad sortRangeASalad = new FindSortRangeASalad();
            sortRangeASalad.FindSortRangeASaladMain();

            MakeSortRangeASalad makeSortRangeASalad = new MakeSortRangeASalad();
            makeSortRangeASalad.MakeSortRangeASaladMain();

            Console.WriteLine();
            Console.Write("Thank you for choosing our application!");
            Console.ReadLine();
            Console.WriteLine("If you have any wishes, be sure to let us know.");
            Console.WriteLine("We will take into account your wishes" +
                " in the further development of the application. ");
            Console.ReadLine();

        }
    }
}
