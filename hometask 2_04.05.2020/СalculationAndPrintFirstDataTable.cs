using System;
using System.Collections.Generic;
using System.Text;

namespace Salad_Chef
{
    class СalculationAndPrintFirstDataTable  // Расчет вывода и вывод первой таблицы с исходными данными 
    {
        public void СalculationAndPrintFirstDataTableMain()      
        {
            int num = VegetablesFirstData.Vegetables.Count;
            Dictionary<int, VegetableInf>.KeyCollection keyColl = VegetablesFirstData.Vegetables.Keys;
            int[] arrayKeys = new int[num];
            int sum = 0;
            foreach (int s in keyColl)
            {
                arrayKeys[sum] = arrayKeys[sum] + s;
                sum = sum + 1;
            }
            int firstKey = arrayKeys[0];

            //задание шапки таблицы
            string[] HeadTableVegetables = new string[]{
                "Number","Food product name","kCal/100gr","Taste","Spicy","Color","Country",};

            //Номер
            //Console.WriteLine(HeadTableVegetables[0]);
            int NumberHeadlength = HeadTableVegetables[0].Length;
            //Console.WriteLine(NumberHeadVegnamelength);
            int[] ArrayKeyslength = new int[num];
            for (int i = 0; i < num; i++)
            {
                string s = arrayKeys[i].ToString();
                ArrayKeyslength[i] = s.Length;
            }
            Array.Sort(ArrayKeyslength);
            int MaxKeyslength = ArrayKeyslength[num - 1];//MaxArrayKeyslength
                                                         //Console.WriteLine(MaxKeyslength);
            int totalColumnWidthNumber;
            if (MaxKeyslength >= NumberHeadlength)
            {
                totalColumnWidthNumber = MaxKeyslength + 2;
            }
            else
            {
                totalColumnWidthNumber = NumberHeadlength + 2;
            }
            //Console.WriteLine(totalColumnWidthNumber);



            //Название овоща
            //Console.WriteLine(HeadTableVegetables[1]);
            int NameHeadlength = HeadTableVegetables[1].Length;
            //Console.WriteLine(NameHeadVegnamelength);

            int[] ArrayNumberVegnamelength = new int[num];
            for (int i = 0; i < num; i++)
            {
                int NumberVegnamelengthi = VegetablesFirstData.Vegetables[(firstKey + i)].VegName.Length;
                ArrayNumberVegnamelength[i] = ArrayNumberVegnamelength[i] + NumberVegnamelengthi;
                //Console.WriteLine(ArrayNumberVegnamelength[i]);
            }
            Array.Sort(ArrayNumberVegnamelength);
            int MaxVegnamelength = ArrayNumberVegnamelength[num - 1];//MaxArrayNumberVegnamelength
                                                                     //Console.WriteLine(MaxVegnamelength);
            int totalColumnWidthName;
            if (MaxVegnamelength >= NameHeadlength)
            {
                totalColumnWidthName = MaxVegnamelength + 2;
            }
            else
            {
                totalColumnWidthName = NameHeadlength + 2;
            }
            //Console.WriteLine(totalColumnWidthName);




            //Калорийность
            //Console.WriteLine(HeadTableVegetables[2]);
            int CaloriesHeadlength = HeadTableVegetables[2].Length;
            //Console.WriteLine(CaloriesHeadlength);
            int[] ArrayNumberVegСaloriesNumber100grlength = new int[num];
            for (int i = 0; i < num; i++)
            {
                string s = VegetablesFirstData.Vegetables[(firstKey + i)].VegСaloriesNumber100gr.ToString();
                int NumberVegСaloriesNumber100grlengthi = s.Length;
                ArrayNumberVegСaloriesNumber100grlength[i] =
                    ArrayNumberVegСaloriesNumber100grlength[i] + NumberVegСaloriesNumber100grlengthi;
                //Console.WriteLine(ArrayNumberVegnamelength[i]);
            }
            Array.Sort(ArrayNumberVegСaloriesNumber100grlength);
            int MaxVegСaloriesNumber100grlength =
                ArrayNumberVegСaloriesNumber100grlength[num - 1];//MaxArrayNumberVegСaloriesNumber100grlength
                                                                 //Console.WriteLine(MaxVegСaloriesNumber100grlength);
            int totalColumnWidthСalories;
            if (MaxVegСaloriesNumber100grlength >= CaloriesHeadlength)
            {
                totalColumnWidthСalories = MaxVegСaloriesNumber100grlength + 2;
            }
            else
            {
                totalColumnWidthСalories = CaloriesHeadlength + 2;
            }
            //Console.WriteLine(totalColumnWidthСalories);



            //Вкус
            //Console.WriteLine(HeadTableVegetables[3]);
            int TasteHeadlength = HeadTableVegetables[3].Length;
            //Console.WriteLine(TasteHeadlength);
            int[] ArrayNumberVegTastelength = new int[num];
            for (int i = 0; i < num; i++)
            {
                int NumberVegTastelengthi = VegetablesFirstData.Vegetables[(firstKey + i)].VegTaste.Length;
                ArrayNumberVegTastelength[i] = ArrayNumberVegTastelength[i] + NumberVegTastelengthi;
                //Console.WriteLine(ArrayNumberVegTastelength[i]);
            }
            Array.Sort(ArrayNumberVegTastelength);
            int MaxVegTastelength = ArrayNumberVegTastelength[num - 1];//MaxArrayNumberVegTastelength
                                                                       //Console.WriteLine(MaxVegTastelength);
            int totalColumnWidthTaste;
            if (MaxVegTastelength >= TasteHeadlength)
            {
                totalColumnWidthTaste = MaxVegTastelength + 2;
            }
            else
            {
                totalColumnWidthTaste = TasteHeadlength + 2;
            }
            //Console.WriteLine(totalColumnWidthTaste);






            //Острота
            //Console.WriteLine(HeadTableVegetables[4]);
            int SpicyHeadlength = HeadTableVegetables[4].Length;
            //Console.WriteLine(SpicyHeadlength);
            int[] ArrayNumberVegSpicylength = new int[num];
            for (int i = 0; i < num; i++)
            {
                int NumberVegSpicylengthi = VegetablesFirstData.Vegetables[(firstKey + i)].VegSpicy.Length;
                ArrayNumberVegSpicylength[i] = ArrayNumberVegSpicylength[i] + NumberVegSpicylengthi;
                //Console.WriteLine(ArrayNumberVegSpicylength[i]);
            }
            Array.Sort(ArrayNumberVegSpicylength);
            int MaxVegSpicylength = ArrayNumberVegSpicylength[num - 1];//MaxArrayNumberVegSpicylength
                                                                       //Console.WriteLine(MaxVegSpicylength);
            int totalColumnWidthSpicy;
            if (MaxVegSpicylength >= SpicyHeadlength)
            {
                totalColumnWidthSpicy = MaxVegSpicylength + 2;
            }
            else
            {
                totalColumnWidthSpicy = SpicyHeadlength + 2;
            }
            //Console.WriteLine(totalColumnWidthSpicy);



            //Цвет
            //Console.WriteLine(HeadTableVegetables[5]);
            int ColorHeadlength = HeadTableVegetables[5].Length;
            //Console.WriteLine(ColorHeadlength);
            int[] ArrayNumberVegColorlength = new int[num];
            for (int i = 0; i < num; i++)
            {
                int NumberVegColorlengthi = VegetablesFirstData.Vegetables[(firstKey + i)].VegColor.Length;
                ArrayNumberVegColorlength[i] = ArrayNumberVegColorlength[i] + NumberVegColorlengthi;
                //Console.WriteLine(ArrayNumberVegColorlength[i]);
            }
            Array.Sort(ArrayNumberVegColorlength);
            int MaxVegColorlength = ArrayNumberVegColorlength[num - 1];//MaxArrayNumberVegColorlength
                                                                       //Console.WriteLine(MaxVegColorlength);
            int totalColumnWidthColor;
            if (MaxVegColorlength >= ColorHeadlength)
            {
                totalColumnWidthColor = MaxVegColorlength + 2;
            }
            else
            {
                totalColumnWidthColor = ColorHeadlength + 2;
            }
            //Console.WriteLine(totalColumnWidthColor);


            //Console.WriteLine();
            //Страна
            //Console.WriteLine(HeadTableVegetables[6]);
            int CountryHeadlength = HeadTableVegetables[6].Length;
            //Console.WriteLine(CountryHeadlength);
            int[] ArrayNumberVegСountryOfOriginlength = new int[num];
            for (int i = 0; i < num; i++)
            {
                int NumberVegCountryOfOriginlengthi = VegetablesFirstData.Vegetables[(firstKey
                    + i)].VegСountryOfOrigin.Length;
                ArrayNumberVegСountryOfOriginlength[i] = ArrayNumberVegСountryOfOriginlength[i] +
                    NumberVegCountryOfOriginlengthi;
                //Console.WriteLine(ArrayNumberVegСountryOfOriginlength[i]);
            }
            Array.Sort(ArrayNumberVegСountryOfOriginlength);
            int MaxVegСountrylength =
                ArrayNumberVegСountryOfOriginlength[num - 1];//MaxArrayNumberVegСountryOfOriginlength
                                                             //Console.WriteLine(MaxVegСountrylength);
            int totalColumnWidthСountry;
            if (MaxVegСountrylength >= CountryHeadlength)
            {
                totalColumnWidthСountry = MaxVegСountrylength + 2;
            }
            else
            {
                totalColumnWidthСountry = CountryHeadlength + 2;
            }
            //Console.WriteLine(totalColumnWidthСountry);


            int TotalLongString = HeadTableVegetables.Length + 1 + totalColumnWidthNumber +
                totalColumnWidthName + totalColumnWidthСalories +
                totalColumnWidthTaste + totalColumnWidthSpicy +
                totalColumnWidthColor + totalColumnWidthСountry;
            //Console.WriteLine(TotalLongString);


            //расчет шапки таблицы
            string stringTotalLongStringLine = new string('-', TotalLongString);
            string[] HeadTableVegWrite = new string[29];

            HeadTableVegWrite[0] = "|";
            HeadTableVegWrite[1] = " ";
            HeadTableVegWrite[2] = HeadTableVegetables[0];
            string str = new string((char)32, totalColumnWidthNumber - 1 - NumberHeadlength);
            HeadTableVegWrite[3] = str;
            HeadTableVegWrite[4] = "|";

            string str1 = new string((char)32, (totalColumnWidthName - NameHeadlength) / 2);
            HeadTableVegWrite[5] = str1;
            HeadTableVegWrite[6] = HeadTableVegetables[1];
            string str2 = new string((char)32, (totalColumnWidthName -
                NameHeadlength - (totalColumnWidthName - NameHeadlength) / 2));
            HeadTableVegWrite[7] = str2;
            HeadTableVegWrite[8] = "|";

            HeadTableVegWrite[9] = " ";
            HeadTableVegWrite[10] = HeadTableVegetables[2];
            string str3 = new string((char)32, totalColumnWidthСalories - 1 - CaloriesHeadlength);
            HeadTableVegWrite[11] = str3;
            HeadTableVegWrite[12] = "|";

            string str4 = new string((char)32, (totalColumnWidthTaste - TasteHeadlength) / 2);
            HeadTableVegWrite[13] = str4;
            HeadTableVegWrite[14] = HeadTableVegetables[3];
            string str5 = new string((char)32, (totalColumnWidthTaste -
                TasteHeadlength - (totalColumnWidthTaste - TasteHeadlength) / 2));
            HeadTableVegWrite[15] = str5;
            HeadTableVegWrite[16] = "|";

            string str6 = new string((char)32, (totalColumnWidthSpicy - SpicyHeadlength) / 2);
            HeadTableVegWrite[17] = str6;
            HeadTableVegWrite[18] = HeadTableVegetables[4];
            string str7 = new string((char)32, (totalColumnWidthSpicy -
            SpicyHeadlength - (totalColumnWidthSpicy - SpicyHeadlength) / 2));
            HeadTableVegWrite[19] = str7;
            HeadTableVegWrite[20] = "|";

            string str8 = new string((char)32, (totalColumnWidthColor - ColorHeadlength) / 2);
            HeadTableVegWrite[21] = str8;
            HeadTableVegWrite[22] = HeadTableVegetables[5];
            string str9 = new string((char)32, (totalColumnWidthColor -
            ColorHeadlength - (totalColumnWidthColor - ColorHeadlength) / 2));
            HeadTableVegWrite[23] = str9;
            HeadTableVegWrite[24] = "|";

            string str10 = new string((char)32, (totalColumnWidthСountry - CountryHeadlength) / 2);
            HeadTableVegWrite[25] = str10;
            HeadTableVegWrite[26] = HeadTableVegetables[6];
            string str11 = new string((char)32, (totalColumnWidthСountry -
            CountryHeadlength - (totalColumnWidthСountry - CountryHeadlength) / 2));
            HeadTableVegWrite[27] = str11;
            HeadTableVegWrite[28] = "|";


            //public class FirstPrint 
            //{ 


            //печать шапки
            
            Console.WriteLine(stringTotalLongStringLine);
            {
                foreach (string s in HeadTableVegWrite)
                    Console.Write(s);
            }
            Console.WriteLine();

            Console.WriteLine(stringTotalLongStringLine);


            //печать таблицы
            foreach (var index in System.Linq.Enumerable.Range(firstKey, num))
            {


                string[] UsualStringVegWrite = new string[29];

                UsualStringVegWrite[0] = "|";
                UsualStringVegWrite[1] = " ";

                UsualStringVegWrite[2] = $"{index}";
                int keyLenght = $"{index}".Length;
                string str20 = new string((char)32, totalColumnWidthNumber - 1 - keyLenght);
                UsualStringVegWrite[3] = str20;
                UsualStringVegWrite[4] = "|";

                UsualStringVegWrite[5] = " ";
                UsualStringVegWrite[6] = VegetablesFirstData.Vegetables[index].VegName;
                string str22 = new string((char)32, (totalColumnWidthName - 1 -
                       VegetablesFirstData.Vegetables[index].VegName.Length));
                UsualStringVegWrite[7] = str22;
                UsualStringVegWrite[8] = "|";

                UsualStringVegWrite[9] = " ";
                UsualStringVegWrite[10] = VegetablesFirstData.Vegetables[index].VegСaloriesNumber100gr.ToString();
                string str23 = new string((char)32, totalColumnWidthСalories - 1 -
                    VegetablesFirstData.Vegetables[index].VegСaloriesNumber100gr.ToString().Length);
                UsualStringVegWrite[11] = str23;
                UsualStringVegWrite[12] = "|";

                UsualStringVegWrite[13] = " ";
                UsualStringVegWrite[14] = VegetablesFirstData.Vegetables[index].VegTaste;
                string str25 = new string((char)32, (totalColumnWidthTaste - 1 -
                    VegetablesFirstData.Vegetables[index].VegTaste.Length));
                UsualStringVegWrite[15] = str25;
                UsualStringVegWrite[16] = "|";

                UsualStringVegWrite[17] = " ";
                UsualStringVegWrite[18] = VegetablesFirstData.Vegetables[index].VegSpicy;
                string str27 = new string((char)32, (totalColumnWidthSpicy - 1 -
                VegetablesFirstData.Vegetables[index].VegSpicy.Length));
                UsualStringVegWrite[19] = str27;
                UsualStringVegWrite[20] = "|";

                UsualStringVegWrite[21] = " ";
                UsualStringVegWrite[22] = VegetablesFirstData.Vegetables[index].VegColor;
                string str29 = new string((char)32, (totalColumnWidthColor - 1 -
                VegetablesFirstData.Vegetables[index].VegColor.Length));
                UsualStringVegWrite[23] = str29;
                UsualStringVegWrite[24] = "|";

                UsualStringVegWrite[25] = " ";
                UsualStringVegWrite[26] = VegetablesFirstData.Vegetables[index].VegСountryOfOrigin;
                string str31 = new string((char)32, (totalColumnWidthСountry - 1 -
                VegetablesFirstData.Vegetables[index].VegСountryOfOrigin.Length));
                UsualStringVegWrite[27] = str31;
                UsualStringVegWrite[28] = "|";

                {
                    foreach (string st in UsualStringVegWrite)
                        Console.Write(st);
                }
                Console.WriteLine();
            }
            Console.WriteLine(stringTotalLongStringLine);




            //}

            //печать по простому

            // Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            // Console.WriteLine("Номер|       Название овоща      | Калорийность |         Вкус       |Острота |    Цвет     |    Страна   |");
            // Console.WriteLine("     |                           | Ккал/100 гр  |                    |        |             |происхождения|");
            // Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            //  foreach (var index in System.Linq.Enumerable.Range(firstKey, num))
            //  {
            //   Console.WriteLine($" {index} |{Vegetables[index].VegName}|      { Vegetables[index].VegСaloriesNumber100gr}      |" +
            //      $"{ Vegetables[index].VegTaste}|{ Vegetables[index].VegSpicy}|{ Vegetables[index].VegColor}|" +
            //      $"{ Vegetables[index].VegСountryOfOrigin}|");
            //  }

        }

    }
}
