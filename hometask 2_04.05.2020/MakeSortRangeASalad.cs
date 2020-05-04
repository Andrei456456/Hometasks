using System;
using System.Collections.Generic;
using System.Text;

namespace Salad_Chef
{
    class MakeSortRangeASalad : FindSortRangeASalad
    {
        public static Dictionary<int, VegetableInf> SaladSort = new Dictionary<int, VegetableInf>();


        public void MakeSortRangeASaladMain()
        {
            //поиск значений входящих в диапазон и составление словаря
            // int keySalad = 0;
            // int number;
            FindSortRangeASalad start1 = new FindSortRangeASalad();
            FindSortRangeASalad end1 = new FindSortRangeASalad();

            int start = start1.startRangeReady;
            int end = end1.endRangeReady;

            //Console.WriteLine("start - " + start);
            //Console.WriteLine("end - " + end);

           
            int i = 0;
            //Console.WriteLine("i = " + i);
            foreach (var index in System.Linq.Enumerable.Range(1, MakeASalad.Salad.Count))
            {
                //Console.WriteLine(MakeASalad.Salad[index] + " - " +
                 //   MakeASalad.Salad[index].VegName + " - " +
                 //   MakeASalad.Salad[index].VegСaloriesNumber100gr);
                bool tryAnswerLeft = (start <= MakeASalad.Salad[index].VegСaloriesNumber100gr);
               // Console.WriteLine("tryAnswerLeft - " + tryAnswerLeft);
                bool tryAnswerRight = (MakeASalad.Salad[index].VegСaloriesNumber100gr <= end);
               // Console.WriteLine("tryAnswerRight - " + tryAnswerRight);

                if (tryAnswerLeft == true && tryAnswerRight == true)
                {
                    i++;
                //    Console.WriteLine("i = " + i);
                //    Console.WriteLine(MakeASalad.Salad[index].VegСaloriesNumber100gr +
                //        " входит в диапазон [ " + start + " ; " + end + " ]");

                    SaladSort.Add(i, new VegetableInf
                    {
                        VegName = MakeASalad.Salad[index].VegName,
                        VegСaloriesNumber100gr = MakeASalad.Salad[index].VegСaloriesNumber100gr,
                    });
                }
            }

            Console.Write("Here are the products that fall within the selected range [ " + 
                start + " ; " + end +" ] :");
            Console.ReadLine();

            foreach (var index in System.Linq.Enumerable.Range(1, SaladSort.Count))
            {
                Console.WriteLine($" {index} - {SaladSort[index].VegName} -" +
                    $" {SaladSort[index].VegСaloriesNumber100gr} kCal/100gr;");
            }
            Console.Write("Cool!");
            Console.ReadLine();
        }
    }
}
