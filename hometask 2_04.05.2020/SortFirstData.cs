using System;
using System.Collections.Generic;
using System.Text;

namespace Salad_Chef
{
    class SortFirstData : VegetablesFirstData
    {
        public static Dictionary<int, VegetableInf> SaladSortFirstData = new Dictionary<int, VegetableInf>();
        public void SortFirstDataMain()
        {
            VegetablesFirstData keyStart = new VegetablesFirstData();
            int keyStartSort = keyStart.keyOut;

            Console.Write("Now we sort all the products by calorie content :");
            Console.ReadLine();

            //Сортируем все значения калорийности через массив

            int count = VegetablesFirstData.Vegetables.Count;
            //Console.WriteLine("Count = " + count);
            int[] ArrayNumberVegСaloriesNumber100gr = new int[count];
            for (int i = 0; i < count; i++)
            {
                int number = VegetablesFirstData.Vegetables[keyStartSort + i].VegСaloriesNumber100gr;
                ArrayNumberVegСaloriesNumber100gr[i] =
                    ArrayNumberVegСaloriesNumber100gr[i] + number;
                //Console.WriteLine(ArrayNumberVegСaloriesNumber100gr[i]);
            }
            //Console.WriteLine("Sorted");
            Array.Sort(ArrayNumberVegСaloriesNumber100gr);
           // for (int j = 0; j < count; j++)
           // {
           //     Console.WriteLine(ArrayNumberVegСaloriesNumber100gr[j]);
           // }

            //Новый уже отсортированный словарь
            int k = 0;
            foreach (var index in System.Linq.Enumerable.Range(keyStartSort, count))
            {
                k++;
               // Console.WriteLine("k = " + k);
                int VegСaloriesNumber100gri = VegetablesFirstData.Vegetables[index].VegСaloriesNumber100gr;
              //  Console.WriteLine("VegСaloriesNumber100gri = " + VegСaloriesNumber100gri);
                int newKey = Array.IndexOf(ArrayNumberVegСaloriesNumber100gr, VegСaloriesNumber100gri);
              //  Console.WriteLine(newKey);
              //  Console.WriteLine(" ");
               

                SaladSortFirstData.Add(newKey, new VegetableInf
                {
                    VegName = VegetablesFirstData.Vegetables[index].VegName,
                    VegСaloriesNumber100gr = VegetablesFirstData.Vegetables[index].VegСaloriesNumber100gr,
                    VegTaste = VegetablesFirstData.Vegetables[index].VegTaste,
                    VegSpicy = VegetablesFirstData.Vegetables[index].VegSpicy,
                    VegColor = VegetablesFirstData.Vegetables[index].VegColor,
                    VegСountryOfOrigin = VegetablesFirstData.Vegetables[index].VegСountryOfOrigin,
                });
            }


            foreach (var newKey in System.Linq.Enumerable.Range(0, count))
            {
                Console.WriteLine(
                 $" {newKey + 1} - " +
                 $" {SaladSortFirstData[newKey].VegName} - " +
                 $" {SaladSortFirstData[newKey].VegСaloriesNumber100gr} kCal/100gr,"); //+
                // $" {SaladSortFirstData[newKey].VegTaste} |" +
                // $" {SaladSortFirstData[newKey].VegSpicy} |" +
                // $" {SaladSortFirstData[newKey].VegColor} |" +
                // $" {SaladSortFirstData[newKey].VegСountryOfOrigin} |");
            }
        }
    }
}


