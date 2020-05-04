using System;
using System.Collections.Generic;
using System.Text;

namespace Salad_Chef
{
    class PrintASalad
    {
        public void PrintASaladMain()
        {

            int num = MakeASalad.Salad.Count;
            Dictionary<int, VegetableInf>.KeyCollection keyColl = MakeASalad.Salad.Keys;
            int[] arrayKeys = new int[num];
            int sum = 0;
            foreach (int s in keyColl)
            {
                arrayKeys[sum] = arrayKeys[sum] + s;
                sum = sum + 1;
            }
            int firstKey = arrayKeys[0];

            //задание шапки таблицы
            string[] HeadTableSalad = new string[]{
                "Number","Food product name","kCal/100gr","Mass, gr","Taste","Spicy","Color","Country"};


            //Номер
            //Console.WriteLine(HeadTableSalad[0]);
            int NumberHeadSaladlength = HeadTableSalad[0].Length;
            //Console.WriteLine(NumberHeadSaladlength);
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
            if (MaxKeyslength >= NumberHeadSaladlength)
            {
                totalColumnWidthNumber = MaxKeyslength + 2;
            }
            else
            {
                totalColumnWidthNumber = NumberHeadSaladlength + 2;
            }
            //Console.WriteLine(totalColumnWidthNumber);


            //Название овоща
            //Console.WriteLine(HeadTableSalad[1]);
            int NameHeadSaladlength = HeadTableSalad[1].Length;
            //Console.WriteLine(NameHeadSaladlength);

            int[] ArrayNumberSaladlength = new int[num];
            for (int i = 0; i < num; i++)
            {
                int NumberSaladlengthi = MakeASalad.Salad[(firstKey + i)].VegName.Length;
                ArrayNumberSaladlength[i] = ArrayNumberSaladlength[i] + NumberSaladlengthi;
                //Console.WriteLine(ArrayNumberVegnamelength[i]);
            }
            Array.Sort(ArrayNumberSaladlength);
            int MaxVegnamelength = ArrayNumberSaladlength[num - 1];//MaxArrayNumberVegnamelength
            //Console.WriteLine(MaxVegnamelength);
            int totalColumnWidthName;
            if (MaxVegnamelength >= NameHeadSaladlength)
            {
                totalColumnWidthName = MaxVegnamelength + 2;
            }
            else
            {
                totalColumnWidthName = NameHeadSaladlength + 2;
            }
            //Console.WriteLine(totalColumnWidthName);

            //Калорийность
            //Console.WriteLine(HeadTableSalad[2]);
            int CaloriesHeadSaladlength = HeadTableSalad[2].Length;
            //Console.WriteLine(CaloriesHeadSaladlength);
            int[] ArrayNumberSaladVegСaloriesNumber100grlength = new int[num];
            for (int i = 0; i < num; i++)
            {
                string s = MakeASalad.Salad[(firstKey + i)].VegСaloriesNumber100gr.ToString();
                int NumberSaladVegСaloriesNumber100grlengthi = s.Length;
                ArrayNumberSaladVegСaloriesNumber100grlength[i] =
                    ArrayNumberSaladVegСaloriesNumber100grlength[i] + NumberSaladVegСaloriesNumber100grlengthi;
                //Console.WriteLine(ArrayNumberVegnamelength[i]);
            }
            Array.Sort(ArrayNumberSaladVegСaloriesNumber100grlength);
            int MaxSaladVegСaloriesNumber100grlength =
                ArrayNumberSaladVegСaloriesNumber100grlength[num - 1];//MaxArrayNumberVegСaloriesNumber100grlength
            //Console.WriteLine(MaxSaladVegСaloriesNumber100grlength);
            int totalColumnWidthСalories;
            if (MaxSaladVegСaloriesNumber100grlength >= CaloriesHeadSaladlength)
            {
                totalColumnWidthСalories = MaxSaladVegСaloriesNumber100grlength + 2;
            }
            else
            {
                totalColumnWidthСalories = CaloriesHeadSaladlength + 2;
            }
            //Console.WriteLine(totalColumnWidthСalories);



            //Масса
            //Console.WriteLine(HeadTableSalad[3]);
            int MassHeadSaladlength = HeadTableSalad[3].Length;
            //Console.WriteLine(MassHeadSaladlength);
            int[] ArrayNumberSaladVegMasslength = new int[num];
            for (int i = 0; i < num; i++)
            {
                int NumberSaladVegTastelengthi = MakeASalad.Salad[(firstKey + i)].SaladVegMass.Length;
                ArrayNumberSaladVegMasslength[i] = ArrayNumberSaladVegMasslength[i]
                    + NumberSaladVegTastelengthi;
                //Console.WriteLine(ArrayNumberVegTastelength[i]);
            }
            Array.Sort(ArrayNumberSaladVegMasslength);
            int MaxSaladVegMasslength = ArrayNumberSaladVegMasslength[num - 1];//MaxArrayNumberVegTastelength
            //Console.WriteLine(MaxSaladVegMasslength);
            int totalColumnWidthMass;
            if (MaxSaladVegMasslength >= MassHeadSaladlength)
            {
                totalColumnWidthMass = MaxSaladVegMasslength + 2;
            }
            else
            {
                totalColumnWidthMass = MassHeadSaladlength + 2;
            }
            //Console.WriteLine(totalColumnWidthMass);


            //Вкус
            //Console.WriteLine(HeadTableSalad[4]);
            int TasteHeadSaladlength = HeadTableSalad[4].Length;
            //Console.WriteLine(TasteHeadSaladlength);
            int[] ArrayNumberSaladVegTastelength = new int[num];
            for (int i = 0; i < num; i++)
            {
                int NumberSaladVegTastelengthi = MakeASalad.Salad[(firstKey + i)].VegTaste.Length;
                ArrayNumberSaladVegTastelength[i] = ArrayNumberSaladVegTastelength[i]
                    + NumberSaladVegTastelengthi;
                //Console.WriteLine(ArrayNumberVegTastelength[i]);
            }
            Array.Sort(ArrayNumberSaladVegTastelength);
            int MaxSaladVegTastelength = ArrayNumberSaladVegTastelength[num - 1];//MaxArrayNumberVegTastelength
            //Console.WriteLine(MaxSaladVegTastelength);
            int totalColumnWidthTaste;
            if (MaxSaladVegTastelength >= TasteHeadSaladlength)
            {
                totalColumnWidthTaste = MaxSaladVegTastelength + 2;
            }
            else
            {
                totalColumnWidthTaste = TasteHeadSaladlength + 2;
            }
            //Console.WriteLine(totalColumnWidthTaste);



            //Острота
            //Console.WriteLine(HeadTableSalad[5]);
            int SpicyHeadSaladlength = HeadTableSalad[5].Length;
            //Console.WriteLine(SpicyHeadSaladlength);
            int[] ArrayNumberSaladVegSpicylength = new int[num];
            for (int i = 0; i < num; i++)
            {
                int NumberSaladVegSpicylengthi = MakeASalad.Salad[(firstKey + i)].VegSpicy.Length;
                ArrayNumberSaladVegSpicylength[i] = ArrayNumberSaladVegSpicylength[i] +
                    NumberSaladVegSpicylengthi;
                //Console.WriteLine(ArrayNumberVegSpicylength[i]);
            }
            Array.Sort(ArrayNumberSaladVegSpicylength);
            int MaxSaladVegSpicylength = ArrayNumberSaladVegSpicylength[num - 1];//MaxArrayNumberVegSpicylength
            //Console.WriteLine(MaxSaladVegSpicylength);
            int totalColumnWidthSpicy;
            if (MaxSaladVegSpicylength >= SpicyHeadSaladlength)
            {
                totalColumnWidthSpicy = MaxSaladVegSpicylength + 2;
            }
            else
            {
                totalColumnWidthSpicy = SpicyHeadSaladlength + 2;
            }
            //Console.WriteLine(totalColumnWidthSpicy);

            //Цвет
            //Console.WriteLine(HeadTableSalad[6]);
            int ColorHeadSaladlength = HeadTableSalad[6].Length;
            //Console.WriteLine(ColorHeadSaladlength);
            int[] ArrayNumberSaladVegColorlength = new int[num];
            for (int i = 0; i < num; i++)
            {
                int NumberSaladVegColorlengthi = MakeASalad.Salad[(firstKey + i)].VegColor.Length;
                ArrayNumberSaladVegColorlength[i] = ArrayNumberSaladVegColorlength[i] +
                    NumberSaladVegColorlengthi;
                //Console.WriteLine(ArrayNumberVegColorlength[i]);
            }
            Array.Sort(ArrayNumberSaladVegColorlength);
            int MaxSaladVegColorlength = ArrayNumberSaladVegColorlength[num - 1];//MaxArrayNumberVegColorlength
            //Console.WriteLine(MaxSaladVegColorlength);
            int totalColumnWidthColor;
            if (MaxSaladVegColorlength >= ColorHeadSaladlength)
            {
                totalColumnWidthColor = MaxSaladVegColorlength + 2;
            }
            else
            {
                totalColumnWidthColor = ColorHeadSaladlength + 2;
            }
            //Console.WriteLine(totalColumnWidthColor);


            //Страна
            //Console.WriteLine(HeadTableSalad[7]);
            int CountryHeadSaladlength = HeadTableSalad[7].Length;
            //Console.WriteLine(CountryHeadSaladlength);
            int[] ArrayNumberSaladVegСountryOfOriginlength = new int[num];
            for (int i = 0; i < num; i++)
            {
                int NumberSaladVegCountryOfOriginlengthi = MakeASalad.Salad[(firstKey + i)].VegСountryOfOrigin.Length;
                ArrayNumberSaladVegСountryOfOriginlength[i] = ArrayNumberSaladVegСountryOfOriginlength[i] +
                    NumberSaladVegCountryOfOriginlengthi;
                //Console.WriteLine(ArrayNumberVegСountryOfOriginlength[i]);
            }
            Array.Sort(ArrayNumberSaladVegСountryOfOriginlength);
            int MaxSaladVegСountrylength =
                ArrayNumberSaladVegСountryOfOriginlength[num - 1];//MaxArrayNumberVegСountryOfOriginlength
            //Console.WriteLine(MaxSaladVegСountrylength);
            int totalColumnWidthСountry;
            if (MaxSaladVegСountrylength >= CountryHeadSaladlength)
            {
                totalColumnWidthСountry = MaxSaladVegСountrylength + 2;
            }
            else
            {
                totalColumnWidthСountry = CountryHeadSaladlength + 2;
            }
            //Console.WriteLine(totalColumnWidthСountry);

            int TotalLongString = HeadTableSalad.Length + 1 + totalColumnWidthNumber +
                totalColumnWidthName + totalColumnWidthСalories +
                totalColumnWidthMass +
                totalColumnWidthTaste + totalColumnWidthSpicy +
                totalColumnWidthColor + totalColumnWidthСountry;
            //Console.WriteLine(TotalLongString);






            //расчет шапки таблицы
            string stringTotalLongStringLine = new string('-', TotalLongString);
            string[] HeadTableSaladVegWrite = new string[33];

            HeadTableSaladVegWrite[0] = "|";
            HeadTableSaladVegWrite[1] = " ";
            HeadTableSaladVegWrite[2] = HeadTableSalad[0];
            string str = new string((char)32, totalColumnWidthNumber - 1 - NumberHeadSaladlength);
            HeadTableSaladVegWrite[3] = str;
            HeadTableSaladVegWrite[4] = "|";

            string str1 = new string((char)32, (totalColumnWidthName - NameHeadSaladlength) / 2);
            HeadTableSaladVegWrite[5] = str1;
            HeadTableSaladVegWrite[6] = HeadTableSalad[1];
            string str2 = new string((char)32, (totalColumnWidthName -
                NameHeadSaladlength - (totalColumnWidthName - NameHeadSaladlength) / 2));
            HeadTableSaladVegWrite[7] = str2;
            HeadTableSaladVegWrite[8] = "|";

            HeadTableSaladVegWrite[9] = " ";
            HeadTableSaladVegWrite[10] = HeadTableSalad[2];
            string str3 = new string((char)32, totalColumnWidthСalories - 1 - CaloriesHeadSaladlength);
            HeadTableSaladVegWrite[11] = str3;
            HeadTableSaladVegWrite[12] = "|";


            HeadTableSaladVegWrite[13] = " ";
            HeadTableSaladVegWrite[14] = HeadTableSalad[3];
            string str31 = new string((char)32, totalColumnWidthMass - 1 - MassHeadSaladlength);
            HeadTableSaladVegWrite[15] = str31;
            HeadTableSaladVegWrite[16] = "|";

            string str4 = new string((char)32, (totalColumnWidthTaste - TasteHeadSaladlength) / 2);
            HeadTableSaladVegWrite[17] = str4;
            HeadTableSaladVegWrite[18] = HeadTableSalad[4];
            string str5 = new string((char)32, (totalColumnWidthTaste -
                TasteHeadSaladlength - (totalColumnWidthTaste - TasteHeadSaladlength) / 2));
            HeadTableSaladVegWrite[19] = str5;
            HeadTableSaladVegWrite[20] = "|";

            string str6 = new string((char)32, (totalColumnWidthSpicy - SpicyHeadSaladlength) / 2);
            HeadTableSaladVegWrite[21] = str6;
            HeadTableSaladVegWrite[22] = HeadTableSalad[5];
            string str7 = new string((char)32, (totalColumnWidthSpicy -
            SpicyHeadSaladlength - (totalColumnWidthSpicy - SpicyHeadSaladlength) / 2));
            HeadTableSaladVegWrite[23] = str7;
            HeadTableSaladVegWrite[24] = "|";

            string str8 = new string((char)32, (totalColumnWidthColor - ColorHeadSaladlength) / 2);
            HeadTableSaladVegWrite[25] = str8;
            HeadTableSaladVegWrite[26] = HeadTableSalad[6];
            string str9 = new string((char)32, (totalColumnWidthColor -
            ColorHeadSaladlength - (totalColumnWidthColor - ColorHeadSaladlength) / 2));
            HeadTableSaladVegWrite[27] = str9;
            HeadTableSaladVegWrite[28] = "|";

            string str10 = new string((char)32, (totalColumnWidthСountry - CountryHeadSaladlength) / 2);
            HeadTableSaladVegWrite[29] = str10;
            HeadTableSaladVegWrite[30] = HeadTableSalad[7];
            string str11 = new string((char)32, (totalColumnWidthСountry -
            CountryHeadSaladlength - (totalColumnWidthСountry - CountryHeadSaladlength) / 2));
            HeadTableSaladVegWrite[31] = str11;
            HeadTableSaladVegWrite[32] = "|";


            //печать шапки

            Console.WriteLine(stringTotalLongStringLine);
            {
                foreach (string s in HeadTableSaladVegWrite)
                    Console.Write(s);
            }
            Console.WriteLine();

            Console.WriteLine(stringTotalLongStringLine);

            //печать таблицы
            foreach (var index in System.Linq.Enumerable.Range(firstKey, num))
            {


                string[] UsualStringSaladVegWrite = new string[33];

                UsualStringSaladVegWrite[0] = "|";
                UsualStringSaladVegWrite[1] = " ";

                UsualStringSaladVegWrite[2] = $"{index}";
                int keyLenght = $"{index}".Length;
                string str20 = new string((char)32, totalColumnWidthNumber - 1 - keyLenght);
                UsualStringSaladVegWrite[3] = str20;
                UsualStringSaladVegWrite[4] = "|";

                UsualStringSaladVegWrite[5] = " ";
                UsualStringSaladVegWrite[6] = MakeASalad.Salad[index].VegName;
                string str22 = new string((char)32, (totalColumnWidthName - 1 -
                       MakeASalad.Salad[index].VegName.Length));
                UsualStringSaladVegWrite[7] = str22;
                UsualStringSaladVegWrite[8] = "|";

                UsualStringSaladVegWrite[9] = " ";
                UsualStringSaladVegWrite[10] = MakeASalad.Salad[index].VegСaloriesNumber100gr.ToString();
                string str23 = new string((char)32, totalColumnWidthСalories - 1 -
                    MakeASalad.Salad[index].VegСaloriesNumber100gr.ToString().Length);
                UsualStringSaladVegWrite[11] = str23;
                UsualStringSaladVegWrite[12] = "|";

                UsualStringSaladVegWrite[13] = " ";
                UsualStringSaladVegWrite[14] = MakeASalad.Salad[index].SaladVegMass.ToString();
                string str231 = new string((char)32, totalColumnWidthMass - 1 -
                    MakeASalad.Salad[index].SaladVegMass.ToString().Length);
                UsualStringSaladVegWrite[15] = str231;
                UsualStringSaladVegWrite[16] = "|";



                UsualStringSaladVegWrite[17] = " ";
                UsualStringSaladVegWrite[18] = MakeASalad.Salad[index].VegTaste;
                string str25 = new string((char)32, (totalColumnWidthTaste - 1 -
                    MakeASalad.Salad[index].VegTaste.Length));
                UsualStringSaladVegWrite[19] = str25;
                UsualStringSaladVegWrite[20] = "|";

                UsualStringSaladVegWrite[21] = " ";
                UsualStringSaladVegWrite[22] = MakeASalad.Salad[index].VegSpicy;
                string str27 = new string((char)32, (totalColumnWidthSpicy - 1 -
                MakeASalad.Salad[index].VegSpicy.Length));
                UsualStringSaladVegWrite[23] = str27;
                UsualStringSaladVegWrite[24] = "|";

                UsualStringSaladVegWrite[25] = " ";
                UsualStringSaladVegWrite[26] = MakeASalad.Salad[index].VegColor;
                string str29 = new string((char)32, (totalColumnWidthColor - 1 -
                MakeASalad.Salad[index].VegColor.Length));
                UsualStringSaladVegWrite[27] = str29;
                UsualStringSaladVegWrite[28] = "|";

                UsualStringSaladVegWrite[29] = " ";
                UsualStringSaladVegWrite[30] = MakeASalad.Salad[index].VegСountryOfOrigin;
                string str32 = new string((char)32, (totalColumnWidthСountry - 1 -
                MakeASalad.Salad[index].VegСountryOfOrigin.Length));
                UsualStringSaladVegWrite[31] = str32;
                UsualStringSaladVegWrite[32] = "|";

                {
                    foreach (string st in UsualStringSaladVegWrite)
                        Console.Write(st);
                }
                Console.WriteLine();
            }
            Console.WriteLine(stringTotalLongStringLine);

        }
    }
}
