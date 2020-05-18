using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phone_AS
{
    class MakeACall
    {
        public void MakeACallMain()
        {
            int mist; 
            int newPhoneNumber = SubscribersBase.phoneNumberOut + SubscribersBase.MainBase.Count;
           
            //Console.WriteLine("1. Checking your own port");

            if (AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberPort == 0)
            {
                OnOffSubscriberPort onOffSubscriberPort1 = new OnOffSubscriberPort();
                onOffSubscriberPort1.OnOffSubscriberPortMain();
                if (AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberPort == 0)
                {  
                    mist = 1;
                    Console.Write("Ok. Maby next time.");
                    Console.ReadLine();
                }
                else // иначе 1 - и можно звонить.
                {
                    mist = 0;
                    Console.Write("Your Port is enable.");
                    Console.ReadLine();
                }
            }
            else // иначе 1 - и можно звонить.
            {
                mist = 0;
                Console.Write("Your Port is enable.");
                Console.ReadLine();
            }

            if (mist == 0)
            {

                //Console.WriteLine("2. choice to whom to call");

                 Console.Write("If you want to look in the phone book - enter 'y'," +
                     " or anything else to no : ");
                 string answer = Console.ReadLine();
                if (answer == "y")
                {
                     PhoneBookPrint phoneBookPrint1 = new PhoneBookPrint();
                     phoneBookPrint1.PhoneBookPrintMain();
                        Console.ReadLine();
                }

                int telephoneNumberInt;
                int mist1;
                string telephoneNumberStr;
                bool result;
                decimal cost;
                do
                {
                    Console.Write("Please, enter the telephone number of the subscriber you want to call" +
                    " and press <Enter> to start a call :  ");
                    telephoneNumberStr = Console.ReadLine();
                    if (int.TryParse(telephoneNumberStr, out telephoneNumberInt) == false)
                    {
                        mist1 = 1;
                        Console.Write("You enter incorrect data - it's not a number. Please, try again.");
                        Console.ReadLine();
                    }
                    result = SubscribersBase.MainBase.Keys.Any(k => k == Convert.ToInt32(telephoneNumberStr));
                    //Console.WriteLine(" result =  " + result);
                    if (result == false)
                    {
                        mist1 = 2;
                        Console.WriteLine("Incorrectly dialed phone number. Please, try again.");
                        Console.Write("и таким вредным голоском...Неправильно набран номер :) :) :) ");
                        Console.ReadLine();
                    }
                    else //
                    {
                        //Console.WriteLine("3. called Port check ");
                        if (AddNewSubscriber.MainBaseAdd[Convert.
                            ToInt32(telephoneNumberStr)].SubscriberPort == 0)
                        {
                            mist1 = 0;
                            Console.Write("The subscriber to whom you are calling " +
                                "is temporarily unavailable. Please, call back later.");
                            Console.ReadLine();
                        }
                        else if ((AddNewSubscriber.MainBaseAdd[Convert.
                            ToInt32(telephoneNumberStr)].SubscriberPort == 333))
                        {
                            mist1 = 0;
                            Console.Write("The subscriber is temporarily busy. Please, call back later.");
                            Console.ReadLine();
                        }
                        // Now we are calling!!!!!!
                        else
                        {
                            mist1 = 0;
                            AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberPort = 333;
                            AddNewSubscriber.MainBaseAdd[Convert.ToInt32(telephoneNumberStr)].
                                SubscriberPort = 333;
                            DateTime date1 = DateTime.Now;//стартовало время вызова.
                            Console.WriteLine();
                            Console.WriteLine("Call start time : {0:G}", date1);
                            Console.WriteLine("Now you are colling to " + AddNewSubscriber.MainBaseAdd[Convert.
                            ToInt32(telephoneNumberStr)].SubscriberName +
                                ". Press <Enter> to exit... ");
                            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
                            // Console.WriteLine();
                            DateTime date2 = DateTime.Now;//закончилось время вызова.
                            Console.WriteLine("Call end time: {0:G}", date2);
                            TimeSpan interval = date2 - date1;
                            Console.WriteLine("Call duration : {0}", interval);
                            Console.ReadLine();

                            AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberPort = 1;
                            AddNewSubscriber.MainBaseAdd[Convert.ToInt32(telephoneNumberStr)].
                                SubscriberPort = 1;

                            if (AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberRate == "m")
                            {
                                int intervalMin = Convert.ToInt32(Math.Ceiling
                                    ((Math.Floor(interval.TotalSeconds)) / 60));
                                //  Console.Write("intervalMin = " + intervalMin + " Min");
                                //  Console.ReadLine();
                                AddNewSubscriber.MainBaseAdd[newPhoneNumber].
                                    SubscriberOutgoingCallsLastMonth =
                                    AddNewSubscriber.MainBaseAdd[newPhoneNumber].
                                    SubscriberOutgoingCallsLastMonth + intervalMin;
                                cost = intervalMin * 1m;
                                AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberMoneyAccount =
                                   AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberMoneyAccount - cost;

                            }
                            else
                            {
                                int intervalSec = Convert.ToInt32(Math.Floor(interval.TotalSeconds));
                                //  Console.Write("intervalSec = " + intervalSec + " Sec");
                                //  Console.ReadLine();
                                AddNewSubscriber.MainBaseAdd[newPhoneNumber].
                                    SubscriberOutgoingCallsLastMonth =
                                    AddNewSubscriber.MainBaseAdd[newPhoneNumber].
                                    SubscriberOutgoingCallsLastMonth + intervalSec;
                                cost = intervalSec * 0.2m;
                                AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberMoneyAccount =
                                    AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberMoneyAccount - cost;
                            }

                            ListSubscriberCalls.ListCalls.Add(new SubscribersInf
                            {
                                NewSubscriberPhoneNumber = newPhoneNumber,
                                CallSubscriberPhoneNumber = Convert.ToInt32(telephoneNumberStr),
                                CallDateStart = Convert.ToString(date1),
                                CallDuration = Convert.ToString(interval),
                                CallCost = cost
                            });

                        }
                    }
                } while (mist1 == 2 || mist1 == 1);
             
            }
        }
    }
}
