using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phone_AS
{
    class OnOffSubscriberPort
    {
        public void OnOffSubscriberPortMain()
        {
           
            string SubscriberPortOnOff;
            NewSubscriberDataPrint newSubscriberDataPrint = new NewSubscriberDataPrint();
            
            int newPhoneNumber = SubscribersBase.phoneNumberOut + SubscribersBase.MainBase.Count;
          //  newSubscriberDataPrint.NewSubscriberDataPrintMain();
          //  Console.WriteLine("SubscriberPort = " +
          //      AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberPort);
            int mist;

            if (AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberPort == 0)
            {
                Console.Write("Your Port is disable. ");
                Console.Read();
                Console.Write("If you want to make a call you need to enable the Port. It's absolutely free.");
                Console.ReadLine();
               
                do
                {
                    Console.Write("To exit the 'On/Off Port' function enter < e > . " +
                        "To enable the Port enter - < 1 >. You choose : ");
                    SubscriberPortOnOff = Console.ReadLine();
                    if (SubscriberPortOnOff != "e" && SubscriberPortOnOff != "1")
                    {
                        mist = 2;
                        Console.Write("You enter incorrect data. Please, try again.");
                        Console.ReadLine();
                    }
                    else if (SubscriberPortOnOff == "e")
                    {
                        mist = 0;

                       // newSubscriberDataPrint.NewSubscriberDataPrintMain();
                        Console.Write("You choose - 'exit' -" +
                            " Your Port is still disable. You can't make a call.");
                        Console.ReadLine();
                    }
                    else
                    {
                        mist = 1;
                        AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberPort = 1;
                       // newSubscriberDataPrint.NewSubscriberDataPrintMain();
                        Console.Write("You choose - '1' - You enable the Port. Now you can make a call!");
                        Console.ReadLine();
                    }

                } while (mist == 2);

            }
            else 
            {
                Console.Write("Your Port is enable.");
                Console.ReadLine();
                do
                {
                    Console.Write("To disable the Port enter - < 0 >. " +
                    " To exit the 'On/Off Port' function enter - < e >. You choose: ");
                    SubscriberPortOnOff = Console.ReadLine();
                    if (SubscriberPortOnOff != "e" && SubscriberPortOnOff != "0")
                    {
                        mist = 2;
                        Console.Write("You enter incorrect data. Please, try again.");
                        Console.ReadLine();
                    }
                    else if (SubscriberPortOnOff == "e")
                    {
                        mist = 1;
                   //   newSubscriberDataPrint.NewSubscriberDataPrintMain();
                        Console.Write("You choose - 'exit' - Your Port is still enable. You can make a call");
                        Console.ReadLine();
                    }
                    else
                    {
                        mist = 0;
                        AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberPort = 0;
                   //   newSubscriberDataPrint.NewSubscriberDataPrintMain();
                        Console.Write("You choose - '0' - You disable the Port. Now you can't make a call!");
                        Console.ReadLine();
                    }
                } while (mist == 2);
            }
        }
    }
}
