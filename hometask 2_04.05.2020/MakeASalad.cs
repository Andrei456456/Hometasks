using System;
using System.Collections.Generic;
using System.Text;

namespace Salad_Chef
{
    class MakeASalad
    {
        
        public static Dictionary<int, VegetableInf> Salad = new Dictionary<int, VegetableInf>();
        
        public void MakeASaladMain()
        {
            Console.Write("Please select product numbers from the FIRST table - products available today.");
            Console.ReadLine();

            string answer = "n";
            
            int keySalad = 0;
            int number;
            int saladVegMass;
            int mist;
           // do 
            //{
                do
                {
                    keySalad++;
                    //Console.WriteLine("i = " + keySalad);
                    do
                    {
                        Console.Write("   Please enter the number " + keySalad + "-th ingredients - ");
                        string numberStr = Console.ReadLine();
                        if (int.TryParse(numberStr, out number) == true &&
                        VegetablesFirstData.Vegetables.ContainsKey(number = int.Parse(numberStr)) == true)
                        {
                            number = int.Parse(numberStr);
                            mist = 0;
                        }
                        else if (int.TryParse(numberStr, out number) == false)
                        {
                            mist = 1;
                            Console.Write("it's not a number. Try again:");
                        }
                        else
                        {
                            mist = 2;
                            Console.Write("There is no any numbers like this. Try again:");
                        }
                    } while (mist == 1 ^ mist == 2);

                    string saladVegName = VegetablesFirstData.Vegetables[number].VegName;
                    Console.Write("your choice   -   " + saladVegName);

                    do
                    {
                        Console.Write(".   Enter the mass of the ingredient in grams: ");
                        string massStr = Console.ReadLine();
                        if (int.TryParse(massStr, out saladVegMass))
                        {
                            saladVegMass = int.Parse(massStr);
                            mist = 0;
                        }
                        else
                        {
                            mist = 1;
                            Console.Write("it's not a number. Try again:");
                        }
                    } while (mist == 1);
                    //Console.Write(saladVegMass);

                    Salad.Add(keySalad, new VegetableInf {
                        VegName = VegetablesFirstData.Vegetables[number].VegName,
                        VegСaloriesNumber100gr = VegetablesFirstData.Vegetables[number].VegСaloriesNumber100gr,
                        SaladVegMass = saladVegMass.ToString(),
                        VegTaste = VegetablesFirstData.Vegetables[number].VegTaste,
                        VegSpicy = VegetablesFirstData.Vegetables[number].VegSpicy,
                        VegColor = VegetablesFirstData.Vegetables[number].VegColor,
                        VegСountryOfOrigin = VegetablesFirstData.Vegetables[number].VegСountryOfOrigin,
                    } );
                    //Console.WriteLine(" ");
                    //Console.WriteLine($" {keySalad} |" +
                   //     $" {Salad[keySalad].VegName} | " +
                   //     $" {Salad[keySalad].VegСaloriesNumber100gr} |" +
                   //     $" {Salad[keySalad].SaladVegMass} |" +
                   //     $" {Salad[keySalad].VegTaste}|" +
                   //     $" {Salad[keySalad].VegSpicy}|" +
                   //     $" {Salad[keySalad].VegColor}|" +
                   //     $" {Salad[keySalad].VegСountryOfOrigin}|");                    
                
                    Console.Write("Add another ingredient?? Press 'y' to add - ");
                    answer = Console.ReadLine();
                    
                } while (answer == "y");


             
           // foreach (var index in System.Linq.Enumerable.Range(1, MakeASalad.Salad.Count))
            //    {
            //        Console.WriteLine($" {index} |" +
            //                $" {Salad[index].VegName} | " +
            //                $" {Salad[index].VegСaloriesNumber100gr} |" +
            //                $" {Salad[index].SaladVegMass} |" +
            //                $" {Salad[index].VegTaste}|" +
            //                $" {Salad[index].VegSpicy}|" +
            //                $" {Salad[index].VegColor}|" +
            //                $" {Salad[index].VegСountryOfOrigin}|");
            //    }
                //keySalad = 0;
                //Console.Write("One more salad? Press 'y' to make another salad - ");
                //answer = Console.ReadLine();
                //Console.WriteLine();
            //} while (answer == "y");
        
        }  


        
            
            
    }

}
    

