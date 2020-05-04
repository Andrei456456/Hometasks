using System;
using System.Collections.Generic;
using System.Text;

namespace Salad_Chef
{
    class CaloriesASalad
    {
        public void CaloriesASaladMain()
        {
            decimal totalSaladMass = 0m;
            decimal totalSaladCalories = 0m;

            //foreach (var index in System.Linq.Enumerable.Range(1, MakeASalad.Salad.Count))
            //{
            //    Console.WriteLine($" {index} |" +
            //        $"{MakeASalad.Salad[index].VegName} | " +
            //            $" {MakeASalad.Salad[index].VegСaloriesNumber100gr} |" +
            //            $" {MakeASalad.Salad[index].SaladVegMass} |" +
            //            $" {MakeASalad.Salad[index].VegTaste}|" +
            //            $" {MakeASalad.Salad[index].VegSpicy}|" +
            //           $" {MakeASalad.Salad[index].VegColor}|" +
            //            $" {MakeASalad.Salad[index].VegСountryOfOrigin}|");
            // }


            //Общая масса салата, Общее количество калорий
            foreach (var index in System.Linq.Enumerable.Range(1, MakeASalad.Salad.Count))
            {
                //Console.WriteLine($" {index} - " + $"{ MakeASalad.Salad[index].SaladVegMass}");
               // totalSaladCalories
                
                decimal mi = Math.Round(decimal.Parse(MakeASalad.Salad[index].SaladVegMass),3);
                totalSaladMass = Math.Round(mi + totalSaladMass, 3);

                decimal kCali = Math.Round(
                    decimal.Parse(MakeASalad.Salad[index].VegСaloriesNumber100gr.ToString()) * 
                    (decimal.Parse(MakeASalad.Salad[index].SaladVegMass)/100), 3);

                totalSaladCalories = Math.Round(kCali + totalSaladCalories, 3);


                //Console.WriteLine(totalSaladMass);
            }

            Console.Write("The total mass of salad - " + totalSaladMass + " gr,");
            Console.ReadLine();
            Console.Write("Total calories in salad - " + totalSaladCalories + " kCal,");
            Console.ReadLine();
            // Калорийность салата на 100 грамм
            decimal kCal100gr = Math.Round(totalSaladCalories / (totalSaladMass / 100), 3);
            Console.Write("The number of calories in a salad per 100 grams - " +
                kCal100gr + " kCal/100gr.");
            Console.ReadLine();
        }
    }
}