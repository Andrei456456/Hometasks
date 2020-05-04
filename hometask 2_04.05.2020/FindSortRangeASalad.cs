using System;
using System.Collections.Generic;
using System.Text;

namespace Salad_Chef
{
    public class FindSortRangeASalad
    {
        private static int startRange;
        private static int endRange;

        public void FindSortRangeASaladMain()
        {
            //int startRange;
            //int endRange;
            int mist;
            Console.Write("Let's move to the next steps.");
            Console.ReadLine();
            Console.Write("We can work with the ingredients of the salad.");
            Console.ReadLine();
            Console.Write("Let's look for certain ingredients based on their calorie content.");
            Console.Read();

            //Диапазон калорийности для поиска - max


            int[] ArraySaladVegСaloriesNumber100gr = new int[MakeASalad.Salad.Count];
            for (int i = 0; i < MakeASalad.Salad.Count; i++)
            {
                int SaladVegСaloriesNumber100gri =
                    MakeASalad.Salad[i + 1].VegСaloriesNumber100gr;
                ArraySaladVegСaloriesNumber100gr[i] =
                    ArraySaladVegСaloriesNumber100gr[i] + SaladVegСaloriesNumber100gri;
                //Console.WriteLine(ArraySaladVegСaloriesNumber100gr[i]);
            }
            Array.Sort(ArraySaladVegСaloriesNumber100gr);
            int MaxSaladVegСaloriesNumber100gr =
                ArraySaladVegСaloriesNumber100gr[MakeASalad.Salad.Count - 1]; //max calories
            int MinSaladVegСaloriesNumber100gr =
                ArraySaladVegСaloriesNumber100gr[0]; //min calories

            //Console.WriteLine(MaxSaladVegСaloriesNumber100gr);

            int maxSaladRangeCaloriesNumber100gr = Convert.ToInt32((Math.Round(
                decimal.Parse((MaxSaladVegСaloriesNumber100gr).ToString())) / 100) + 1) * 100; // max range

            Console.WriteLine("Please, enter a search range based on calories - int - from 0 to "
            + maxSaladRangeCaloriesNumber100gr + " :");
            Console.Read();
            //Ввод диапазона
            //ввод начала
            do
            {
                Console.Write("Start of range from : ");
                string startRangeStr = Console.ReadLine();


                if (int.TryParse(startRangeStr, out startRange) &&
                ((startRange = int.Parse(startRangeStr)) <= MaxSaladVegСaloriesNumber100gr) &&
                (startRange = int.Parse(startRangeStr)) >= 0)
                {
                    startRange = int.Parse(startRangeStr);
                    mist = 0;
                }
                else if (int.TryParse(startRangeStr, out startRange) == false)
                {
                    mist = 1;
                    Console.WriteLine("it's not a number or not int-number. Try again:");
                }
                else if ((startRange = int.Parse(startRangeStr)) > MaxSaladVegСaloriesNumber100gr)
                {
                    mist = 2;
                    Console.WriteLine("This is too much - all elements are smaller. " +
                        "There will be nothing to look for!. Try again:");
                }
                else
                {
                    mist = 3;
                    Console.WriteLine("The number is not in the suggested range. Try again:");
                }
            } while (mist == 1 ^ mist == 2 ^ mist == 3);

            //ввод окончания
            //(MakeASalad.Salad.Vegetables


            //int tryMark;
            do
            {
                Console.Write("End of range : ");
                string endRangeStr = Console.ReadLine();


                if ((int.TryParse(endRangeStr, out endRange)) == false)
                {
                    mist = 1;
                    Console.WriteLine("it's not a number or not int-number. Try again:");
                }
                else if (startRange >= (endRange = int.Parse(endRangeStr)))
                {
                    mist = 2;
                    Console.WriteLine("This is too small!" +
                        " End of range must be greater than start of range. Try again:");
                }
                else if (MinSaladVegСaloriesNumber100gr > (endRange = int.Parse(endRangeStr)))
                {
                    mist = 3;
                    Console.WriteLine("This is too small - all elements are greater. " +
                        "There will be nothing to look for!. Try again:");
                }
                else if ((endRange = int.Parse(endRangeStr)) > maxSaladRangeCaloriesNumber100gr)
                {

                    mist = 4;
                    Console.WriteLine("The number is not in the suggested range. Try again:");
                }
                else if ((endRange = int.Parse(endRangeStr)) <= maxSaladRangeCaloriesNumber100gr)
                {
                    int tryMark = 0;
                    for (int i = 0; i < MakeASalad.Salad.Count; i++)
                    {
                        //Console.WriteLine("ArraySaladVegСaloriesNumber100gr[i] - " +
                        //   ArraySaladVegСaloriesNumber100gr[i]);

                        bool tryAnswerLeft = (startRange <= ArraySaladVegСaloriesNumber100gr[i]);
                        //Console.WriteLine("tryAnswerLeft - " + tryAnswerLeft);
                        bool tryAnswerRight = (ArraySaladVegСaloriesNumber100gr[i] <= endRange);
                        //Console.WriteLine("tryAnswerRight - " + tryAnswerRight);

                        if ((tryAnswerLeft == false && tryAnswerRight == true) ^
                            (tryAnswerLeft == true && tryAnswerRight == false))
                        {
                            tryMark++;
                            // Console.WriteLine("tryMark - " + tryMark);
                        }
                    }
                    int answer = tryMark;
                    //Console.WriteLine("answer - " + answer);
                    //Console.WriteLine("MakeASalad.Salad.Count - " + MakeASalad.Salad.Count);

                    if (answer == MakeASalad.Salad.Count)
                    {
                        mist = 5;
                        Console.WriteLine("This is an empty range. Try again:");
                    }
                    else
                    {
                        mist = 0;
                        endRange = int.Parse(endRangeStr);
                    }
                }

            } while (mist == 1 ^ mist == 2 ^ mist == 3 ^ mist == 4 ^ mist == 5);

            Console.Write("You choose range  [ " + startRange + " ; " + endRange + " ]");
            Console.ReadLine();

        }
        public int startRangeReady = startRange;
        public int endRangeReady = endRange;
       
    }
}
    


