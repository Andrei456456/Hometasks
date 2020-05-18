using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phone_AS
{
    class SubscribersBase
    {
        private static int phoneNumber = 700;
        public static int phoneNumberOut = phoneNumber;

        public static Dictionary<int, SubscribersInf> MainBase = new Dictionary<int, SubscribersInf>()
        {
                { phoneNumber, new SubscribersInf {
                    SubscriberName =                   "Rocky Balboa" ,
                    SubscriberPort =              1,
                    SubscriberAccess =                 1,
                    SubscriberRate =                   "m",
                    SubscriberConnectDate =            "05.04",
                    SubscriberMoneyAccount =           15.0m,
                    SubscriberOutgoingCallsLastMonth = 0,
                } },

                { phoneNumber + 1, new SubscribersInf {
                    SubscriberName =                   "Steve Jobs" ,
                    SubscriberPort =              1,
                    SubscriberAccess =                 1,
                    SubscriberRate =                   "s",
                    SubscriberConnectDate =            "07.04",
                    SubscriberMoneyAccount =           18.0m,
                    SubscriberOutgoingCallsLastMonth = 0,
                } },

                { phoneNumber + 2, new SubscribersInf {
                    SubscriberName =                   "Ringo Star" ,
                    SubscriberPort =              1,
                    SubscriberAccess =                 1,
                    SubscriberRate =                   "m",
                    SubscriberConnectDate =            "07.04",
                    SubscriberMoneyAccount =           18.0m,
                    SubscriberOutgoingCallsLastMonth = 0,
                } },

                { phoneNumber + 3, new SubscribersInf {
                    SubscriberName =                   "Kevin Kostner" ,
                    SubscriberPort =              333,
                    SubscriberAccess =                 1,
                    SubscriberRate =                   "m",
                    SubscriberConnectDate =            "07.04",
                    SubscriberMoneyAccount =           50.0m,
                    SubscriberOutgoingCallsLastMonth = 0,
                } },

                { phoneNumber + 4, new SubscribersInf {
                    SubscriberName =                   "Eric Clapton" ,
                    SubscriberPort =              1,
                    SubscriberAccess =                 1,
                    SubscriberRate =                   "m",
                    SubscriberConnectDate =            "07.04",
                    SubscriberMoneyAccount =           60.0m,
                    SubscriberOutgoingCallsLastMonth = 0,
                } },
        };
    }
}
