using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Phone_AS
{
    class PrintCallList
    {
        public void PrintCallListMain()
        {
            //Console.WriteLine("ListSubscriberCalls.ListCalls.Count = " + ListSubscriberCalls.ListCalls.Count);

            int mist = 0;
            //Console.WriteLine("ListSubscriberCalls.ListCalls.Count = " + ListSubscriberCalls.ListCalls.Count);
            do
            {
                Console.WriteLine("Menu to work with your call list : " +
                "< 1 > - print your call list, " +
                "< 2 > - sort your call list by phone numbers of called subscribers and print it," +
                "< 3 > - sort your call list by call dates and print it," +
                "< 4 > - sort your call list by call costs and print it," +
                "< 0 > - exit to main menu.");
                string answer = Console.ReadLine();
                
                if (answer == "1")
                {
                    mist = 1;
                    int i = 0;
                    int number = ListSubscriberCalls.ListCalls.Count;
                    for (i = 0; i < number; i++)
                    {
                       // Console.WriteLine("i = " + i);
                        Console.WriteLine($"from Tel.{ListSubscriberCalls.ListCalls[i].NewSubscriberPhoneNumber} - " +
                            $"to tel.{ListSubscriberCalls.ListCalls[i].CallSubscriberPhoneNumber} - " +
                            $"Date start {ListSubscriberCalls.ListCalls[i].CallDateStart} - " +
                            $"Duration {ListSubscriberCalls.ListCalls[i].CallDuration} - " +
                            $"Cost {ListSubscriberCalls.ListCalls[i].CallCost} $;");
                        //Console.ReadLine();
                    }
                }
                else if (answer == "2")
                { 
                    mist = 1;
                    var sortedPhoneNumbersListCalls = 
                        from n in ListSubscriberCalls.ListCalls
                        orderby n.CallSubscriberPhoneNumber
                        select n;
                //    foreach (SubscribersInf n in sortedPhoneNumbersListCalls)
                //    { 
                //        Console.WriteLine(n.CallSubscriberPhoneNumber);
                //    }
                    foreach (SubscribersInf n in sortedPhoneNumbersListCalls)
                    {
                        Console.WriteLine($"from Tel.{n.NewSubscriberPhoneNumber} - " +
                          $"to tel.{n.CallSubscriberPhoneNumber} - " +
                          $"Date start {n.CallDateStart} - " +
                          $"Duration {n.CallDuration} - " +
                          $"Cost {n.CallCost} $;");
                    }
                      

                }
                else if (answer == "3")
                {
                    mist = 1;
                    var sortedCallDateStart = 
                        from n in ListSubscriberCalls.ListCalls
                        orderby n.CallDateStart
                        select n;
               
                    foreach (SubscribersInf n in sortedCallDateStart)
                    {
                        Console.WriteLine($"from Tel.{n.NewSubscriberPhoneNumber} - " +
                          $"to tel.{n.CallSubscriberPhoneNumber} - " +
                          $"Date start {n.CallDateStart} - " +
                          $"Duration {n.CallDuration} - " +
                          $"Cost {n.CallCost} $;");
                    }
                    
                }
                else if (answer == "4")
                {
                    mist = 1;

                     var sortedCallCost = 
                        from n in ListSubscriberCalls.ListCalls
                        orderby n.CallCost
                        select n;
               
                    foreach (SubscribersInf n in sortedCallCost)
                    {
                        Console.WriteLine($"from Tel.{n.NewSubscriberPhoneNumber} - " +
                          $"to tel.{n.CallSubscriberPhoneNumber} - " +
                          $"Date start {n.CallDateStart} - " +
                          $"Duration {n.CallDuration} - " +
                          $"Cost {n.CallCost} $;");
                    }
                }
                else if (answer == "0")
                {
                    mist = 0;
                }
            } while (mist == 1);
    }   }
}