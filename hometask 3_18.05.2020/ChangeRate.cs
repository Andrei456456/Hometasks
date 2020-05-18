using System;
using System.Collections.Generic;
using System.Text;

namespace Phone_AS
{
    class ChangeRate
    {
        public void ChangeRateMain()
        {
            int newPhoneNumber = SubscribersBase.phoneNumberOut + SubscribersBase.MainBase.Count;
            string minute = " M - per-minute billing, cost - 1 $ / minute.";
            string second = " S - per-second billing, cost - 0.2 $ / second.";
            string subRate;
            if (AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberRate == "m")
            {
                subRate = minute;
            }
            else
            {
                subRate = second;
            }

            Console.WriteLine("Your current rate is - " + subRate);



            NewSubscriberDataPrint newSubscriberDataPrint = new NewSubscriberDataPrint();
            newSubscriberDataPrint.NewSubscriberDataPrintMain();

            DateTime date1 = Convert.ToDateTime(
                AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberConnectDate);

            DateTime date2 = DateTime.Now;
            Console.WriteLine("Now time is : {0:G}", date2);
            TimeSpan interval = date2 - date1;
            // Console.WriteLine("Call duration : {0}", interval);
            // Console.ReadLine();

            Console.WriteLine("interval: {0} - {1} = {2}", date2, date1, interval.TotalDays + " Days");
            if (interval.TotalDays < 30)
            {
                Console.WriteLine("Sorry, you can't change your rate now. You can do it only once in month.");
                Console.WriteLine("Last time you did it - " + date1 + ".");
                Console.WriteLine("You should wait for - " + (30 - interval.TotalDays) + " Days.");

            }
            else
            {
                string changeSubscriberRate;
                int mist;
                do
                {
                    Console.WriteLine("Our network uses 2 different rates for paying for calls : ");
                    Console.WriteLine("M - per-minute billing, cost - 1 $ / minute.");
                    Console.WriteLine("S - per-second billing, cost - 0.2 $ / second.");
                    Console.ReadLine();
                    Console.Write("Choose your new rate, please - enter 'm' or 's' : ");
                    changeSubscriberRate = Console.ReadLine();
                    if (changeSubscriberRate != "m" && changeSubscriberRate != "s")
                    {
                        mist = 1;
                        Console.WriteLine("You enter incorrect data. Please, try again.");

                    }
                    else if (changeSubscriberRate == "m")
                    {
                        mist = 0;
                        AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberRate = changeSubscriberRate;
                        //Console.Write("You choose - M - per-minute billing, cost - 1 $ / minute.");
                        //Console.ReadLine();
                    }
                    else
                    {
                        mist = 0;
                        AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberRate = changeSubscriberRate;
                        //Console.Write("You choose - S - per-second billing, cost - 0.2 $ / second.");
                        //Console.ReadLine();
                    }

                } while (mist == 1);

                if (AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberRate == "m")
                {
                    subRate = minute;
                }
                else
                {
                    subRate = second;
                }

                Console.Write("Your new current rate is - " + subRate);
                Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
