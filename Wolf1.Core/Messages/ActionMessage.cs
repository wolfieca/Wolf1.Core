using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Formatters;
using Wolf1.Core.Management;
using Wolf1.Core.Model;

namespace Wolf1.Core.Messages
{
    public class ActionMessage : MessageBody
    {
        public ActionCode Action {get; private set;}
        public ResultCode Result {get; private set;}
        public Account Account {get; private set;}
        public Collector Collector {get; private set;}
        public Priority ScheduledPriority {get; private set;}
        public Boolean IsHold {get; private set;}
        public Boolean IsReminder {get; private set;}
        public Decimal Amount {get; private set;}
        public Client Client {get; private set; }
        public PhoneNumber SchedPhone {get; private set;}
        public Boolean IsDialerCollector {get; private set;}
        public Boolean CollectorMayGetNoPhones {get; private set;}
        public Boolean DialerAccountWithPhone {get; private set;}
        public DateTime SortDate {get; private set;}
        public DateTime QueueDate {get; private set;}
        public DateTime StartTime {get; private set;}
        public DateTime EndTime {get; private set;}
        public Priority OriginalPriority { get; private set;}
        public Boolean WasOriginallyReminder {get; private set;}
        public Boolean WasOriginallyHold {get; private set;}
        public User UserCode { get; private set;}
        public DateTime QueueControl {get; private set;}
        public ResultCode OriginalResultCode {get; private set}
    }
}
