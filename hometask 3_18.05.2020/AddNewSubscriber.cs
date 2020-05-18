using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phone_AS
{
    class AddNewSubscriber
    {

       
        public int newPhoneNumber;
        
        public static Dictionary<int, SubscribersInf> MainBaseAdd = new Dictionary<int, SubscribersInf>();
        
        public void AddNewSubscriberMain()
        {
            
            int phoneNumberAdd = SubscribersBase.phoneNumberOut-1;
              
            for (int i=1; i <= SubscribersBase.MainBase.Count; i++ ) 
            {
                phoneNumberAdd++;
                AddNewSubscriber.MainBaseAdd.Add(phoneNumberAdd, new SubscribersInf
                {
                    SubscriberName = SubscribersBase.MainBase[phoneNumberAdd].SubscriberName,
                    SubscriberPort = SubscribersBase.MainBase[phoneNumberAdd].SubscriberPort,
                    SubscriberAccess = SubscribersBase.MainBase[phoneNumberAdd].SubscriberAccess,
                    SubscriberRate = SubscribersBase.MainBase[phoneNumberAdd].SubscriberRate,
                    SubscriberConnectDate = SubscribersBase.MainBase[phoneNumberAdd].SubscriberConnectDate,
                    //Convert.ToString(DateTime.Now),
                    SubscriberMoneyAccount = SubscribersBase.MainBase[phoneNumberAdd].SubscriberMoneyAccount,
                    //newSubscriberMoneyAccount,
                    SubscriberOutgoingCallsLastMonth = SubscribersBase.
                    MainBase[phoneNumberAdd].SubscriberOutgoingCallsLastMonth,
                });
              //  Console.WriteLine($"{phoneNumberAdd} -" +
              //      $" {AddNewSubscriber.MainBaseAdd[phoneNumberAdd].SubscriberName} - " +
              //      $"{ AddNewSubscriber.MainBaseAdd[phoneNumberAdd].SubscriberPort} - " +
              //      $"{ AddNewSubscriber.MainBaseAdd[phoneNumberAdd].SubscriberAccess} - " +
              //      $"{ AddNewSubscriber.MainBaseAdd[phoneNumberAdd].SubscriberRate} - " +
              //      $"{ AddNewSubscriber.MainBaseAdd[phoneNumberAdd].SubscriberConnectDate} - " +
              //      $"{ AddNewSubscriber.MainBaseAdd[phoneNumberAdd].SubscriberMoneyAccount}$ - " +
              //      $"{ AddNewSubscriber.MainBaseAdd[phoneNumberAdd].SubscriberOutgoingCallsLastMonth}");
            }
           
            // PrintDictionary print1 = new PrintDictionary();
            //print1.PrintDic("phoneNumberAdd", SubscribersBase.phoneNumberOut,
           //     AddNewSubscriber, "MainBaseAdd");

            Console.Write("Do you want to became a new subscriber in our community? Of course you want!!!");
            Console.ReadLine();
            Console.Write("It will takes you only some easy steps.");
            Console.ReadLine();
            Console.Write("Enter your name, please : ");
            string newName = Console.ReadLine();
            newPhoneNumber = (SubscribersBase.phoneNumberOut + SubscribersBase.MainBase.Count);
            Console.Write("Your phone number will be: " + newPhoneNumber );
            Console.ReadLine();
            Console.Write("We provide you with a device to access our network(telephone) and Port.");
            Console.ReadLine();
            Console.Write(" You can disconnect yourself or connect to the network at your convenience" +
                " at a convenient time — using the Port.");
            Console.ReadLine();


            Console.Write("Now about the rates. Our network uses 2 different rates for paying for calls.");
            Console.ReadLine();
            Console.Write("M - per-minute billing, cost - 1 $ / minute.  ");
            Console.ReadLine();
            Console.Write(" S - per-second billing, cost - 0.2 $ / second.");
            Console.ReadLine();
            Console.Write("!!!В реальной жизни было бы 0,02 $/сек. Но для проверки программы ждать 100 сек - долго :)");
            Console.ReadLine();
            Console.Write("Next time you will be able to change the rate no earlier than in one month.");
            Console.ReadLine();
            int mist;
            string newSubscriberRate;
            
            do
            {
                Console.Write("Choose your rate, please - enter 'm' or 's' : ");
                newSubscriberRate = Console.ReadLine();
                if (newSubscriberRate != "m" && newSubscriberRate != "s")
                {
                    mist = 1;
                    Console.WriteLine("You enter incorrect data. Please, try again.");
                   
                }
                else if(newSubscriberRate == "m")
                {
                    mist = 0;
                    Console.Write("You choose per-minute billing, cost - 1 $ / minute.");
                    Console.ReadLine();
                }
                else 
                {
                    mist = 0;
                    Console.Write("You choose per-second billing, cost - 0.2 $ / second.");
                    Console.ReadLine();
                }

            } while (mist == 1);

           
            int newSubscriberMoney;
            string numberMoney;
            do
            {
                Console.Write("Please, add some money to your account. It must be a number from 1 to 100 : ");
                numberMoney = Console.ReadLine();
                if (int.TryParse(numberMoney, out newSubscriberMoney) == false) 
                {
                    mist = 1;
                    Console.WriteLine("You enter incorrect data. Please, try again.");
                   
                }
                else if (((newSubscriberMoney = Convert.ToInt32(numberMoney)) < 1) ||  
                         (newSubscriberMoney = Convert.ToInt32(numberMoney)) > 100)
                     {
                             mist = 2;
                             Console.WriteLine("You enter incorrect number. Please, try again.");
                            
                     }
                else
                {
                    mist = 0;
                    newSubscriberMoney = Convert.ToInt32(numberMoney);
                    string resultnewSubscriberMoney = String.Format("{0:f2}", newSubscriberMoney);
                    Console.Write("You add to your account " + resultnewSubscriberMoney + " $.");
                    Console.ReadLine();
                }
            } while (mist == 1 || mist == 2);
            decimal newSubscriberMoneyAccount = Convert.ToDecimal(numberMoney);
            //Console.WriteLine((String.Format("{0:f2}", newSubscriberMoneyAccount)) + " $.");
            

            phoneNumberAdd = newPhoneNumber;
                AddNewSubscriber.MainBaseAdd.Add(phoneNumberAdd, new SubscribersInf
            {
                SubscriberName = newName,
                SubscriberPort = 0,
                SubscriberAccess = 1,
                SubscriberRate = newSubscriberRate,
                SubscriberConnectDate = Convert.ToString(DateTime.Now),
                SubscriberMoneyAccount = newSubscriberMoneyAccount,
                SubscriberOutgoingCallsLastMonth = 0,
            }) ;
            //Console.Write(AddNewSubscriber.MainBaseAdd.Count);
            Console.WriteLine("Fine! You have become a member of our telephone network!");
            Console.ReadLine();
            
        // foreach (var index in System.Linq.Enumerable.Range
        //     (SubscribersBase.phoneNumberOut, AddNewSubscriber.MainBaseAdd.Count))
        // {
        //     Console.WriteLine($"{index} -" +
        //          $" {AddNewSubscriber.MainBaseAdd[index].SubscriberName} - " +
        //          $"{ AddNewSubscriber.MainBaseAdd[index].SubscriberPort} - " +
        //          $"{ AddNewSubscriber.MainBaseAdd[index].SubscriberAccess} - " +
        //          $"{ AddNewSubscriber.MainBaseAdd[index].SubscriberRate} - " +
        //          $"{ AddNewSubscriber.MainBaseAdd[index].SubscriberConnectDate} - " +
        //          $"{ AddNewSubscriber.MainBaseAdd[index].SubscriberMoneyAccount} - " +
        //          $"{ AddNewSubscriber.MainBaseAdd[index].SubscriberOutgoingCallsLastMonth}");
        // }
    }
    }
}
