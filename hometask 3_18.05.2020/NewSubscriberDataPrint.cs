using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phone_AS
{
    class NewSubscriberDataPrint
    {
        public void NewSubscriberDataPrintMain()
        {
            int newPhoneNumber = SubscribersBase.phoneNumberOut + SubscribersBase.MainBase.Count;
            Console.WriteLine($"Tel.{newPhoneNumber} - " +
                     $"{AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberName} - " +
                     $"{ AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberPort} - " +
                     $"{ AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberAccess} - " +
                     $"{ AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberRate} - " +
                     $"{ AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberConnectDate} - " +
                     $"{ AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberMoneyAccount} - " +
                     $"{ AddNewSubscriber.MainBaseAdd[newPhoneNumber].SubscriberOutgoingCallsLastMonth}");
                    
        }
    }
}
