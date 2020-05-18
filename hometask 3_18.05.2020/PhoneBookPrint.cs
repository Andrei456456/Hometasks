using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phone_AS
{
    class PhoneBookPrint
    {
        public void PhoneBookPrintMain()
        {
            Console.WriteLine("This is our Phone book :");

            foreach (var index in System.Linq.Enumerable.Range
                (SubscribersBase.phoneNumberOut, AddNewSubscriber.MainBaseAdd.Count))
            {
                Console.WriteLine($"Tel.{index} -" +
                     $" {AddNewSubscriber.MainBaseAdd[index].SubscriberName} ;");
            }

           // foreach (var index in System.Linq.Enumerable.Range(700, SubscribersBase.MainBase.Count))
           // {
           //     Console.WriteLine($"{index} - {SubscribersBase.MainBase[index].SubscriberName} - " +
           //         $"{ SubscribersBase.MainBase[index].SubscriberPort} - " +
           //        $"{ SubscribersBase.MainBase[index].SubscriberAccess} - " +
           //         $"{ SubscribersBase.MainBase[index].SubscriberRate} - " +
           //         $"{ SubscribersBase.MainBase[index].SubscriberConnectDate} - " +
           //        $"{ SubscribersBase.MainBase[index].SubscriberMoneyAccount}$ - " +
           //        $"{ SubscribersBase.MainBase[index].SubscriberOutgoingCallsLastMonth}");
           // }
        }
    }
}
