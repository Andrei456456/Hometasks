using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Phone_AS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in our telephone network!");

            AddNewSubscriber addNewSubscriber = new AddNewSubscriber();
            addNewSubscriber.AddNewSubscriberMain();
            int j=1;
            string answer;
            do
            {
                Console.WriteLine("Main menu of our application: " +
                    "< 1 > - make a call; " +
                    "< 2 > - print our phone book; " +
                    "< 3 > - On/Off your Port; " +
                    "< 4 > - change your rate;" +
                    "< 5 > - add some money to your account;" +
                    "< 6 > - print list your calls;" +
                    "< 0 > - exit from application. You choose : ");
                answer = Console.ReadLine();


                if (answer == "1")
                {
                    j = 1;
                    MakeACall makeACall = new MakeACall();
                    makeACall.MakeACallMain();
                }
                else if (answer == "2")
                {
                    j = 1;
                    PhoneBookPrint phoneBookPrint1 = new PhoneBookPrint();
                    phoneBookPrint1.PhoneBookPrintMain();

                }
                else if (answer == "3")
                {
                    j = 1;
                    OnOffSubscriberPort onOffSubscriberPort = new OnOffSubscriberPort();
                    onOffSubscriberPort.OnOffSubscriberPortMain();
                }
                else if (answer == "4")
                {
                    j = 1;
                    ChangeRate changeRate = new ChangeRate();
                    changeRate.ChangeRateMain();
                }
                else if (answer == "5")
                {
                    j = 1;
                    AddMoney addMoney = new AddMoney();
                    addMoney.AddMoneyMain();
                }
                else if (answer == "6")
                {
                    j = 1;
                    PrintCallList printCallList = new PrintCallList();
                    printCallList.PrintCallListMain();
                }
                else if (answer == "0")
                {
                    j = 0;
                    Console.WriteLine("Good bye! Thank you for choosing our application!");
                }

            } while (j == 1);
        }
    }
}
