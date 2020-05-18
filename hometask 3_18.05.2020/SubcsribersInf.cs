using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phone_AS
{
    class SubscribersInf
    {
       // public string SubscriberPhoneNumber { get; set; }
        public string SubscriberName { get; set; }
        public int SubscriberPort { get; set; } // Состояние порта
        public int SubscriberAccess { get; set; } // Доступ к сети
        public string SubscriberRate { get; set; }//Тариф
        public string SubscriberConnectDate { get; set; }// Дата подключения
        public decimal SubscriberMoneyAccount { get; set; }// Денежный счет
        public int SubscriberOutgoingCallsLastMonth { get; set; }
        // Длительность исходящих вызовов за послдений месяц
        public int NewSubscriberPhoneNumber { get; set; }
        public int CallSubscriberPhoneNumber { get; set; }//вызываемый абонент
        public string CallDuration { get; set; }//продолжительность звонка
        public string CallDateStart { get; set; }//дата начала звонка
        public decimal CallCost { get; set; }












    }
}
