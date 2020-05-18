using System;
using System.Collections.Generic;
using System.Text;

namespace Phone_AS
{
    class AddMoney
    {
        public void AddMoneyMain()
        {
            int newPhoneNumber = SubscribersBase.phoneNumberOut + SubscribersBase.MainBase.Count;

            Console.WriteLine("Your current account is : " + (String.Format("{0:f2}",
                AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberMoneyAccount)) + " $.");
            

            int mist;
            int addSubscriberMoney;
            string numberMoney;
            do
            {
                Console.Write("Please, enter the amount of money you want to add to your account (int, > 1$) : ");
                numberMoney = Console.ReadLine();
                if (int.TryParse(numberMoney, out addSubscriberMoney) == false)
                {
                    mist = 1;
                    Console.Write("You enter incorrect data. Please, try again.");
                    Console.ReadLine();
                }
                else if ((addSubscriberMoney = Convert.ToInt32(numberMoney)) < 1) 
                {
                    mist = 2;
                    Console.Write("You enter incorrect number. Please, try again.");
                    Console.ReadLine();
                }
                else
                {
                    mist = 0;
                    addSubscriberMoney = Convert.ToInt32(numberMoney);
                    string resultaddSubscriberMoney = String.Format("{0:f2}", addSubscriberMoney);
                    Console.Write("You add to your account " + resultaddSubscriberMoney + " $.");
                    Console.ReadLine();
                }
            } while (mist == 1 || mist == 2);
            decimal addSubscriberMoneyAccount = Convert.ToDecimal(numberMoney);
            AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberMoneyAccount =
                 AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberMoneyAccount +
                 addSubscriberMoneyAccount;
           
            Console.WriteLine("Your current account is : " + (String.Format("{0:f2}",
                AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberMoneyAccount)) + " $.");
            Console.ReadLine();
        }
    }
}
