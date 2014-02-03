using System;
using System.Collections.Generic;

namespace Mobile
{
    public class Call
    {
        private static List<Call> callHystory = new List<Call>();
        private string date;
        private string time;
        private string dealedPoneNumber;
        private Random duration;
        private int callDuration;

        public Call()
        {

        }
        public Call(string dealedNumber)
        {
            this.duration = new Random();
            this.DealedPhoneNumber = dealedNumber;
            this.Date = DateTime.Today.ToShortDateString();
            this.Time = DateTime.Now.AddMinutes(duration.Next(1, 10)).ToShortTimeString();
            this.CallDuration = 1;

        }
        public int CallDuration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                int temp = (int)duration.Next(1, 600) / 60;
                if(temp == 0)
                {
                    this.callDuration = 1;
                }
                else
                {
                    this.callDuration = temp;
                }
                
            }
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }
        public string DealedPhoneNumber { get; private set; }

        public static List<Call> CallHystory
        {
            get
            {
                return callHystory;
            }
            set
            {
                callHystory = value;
            }
        }

        public Call LongestCall()
        {
            Call tempCall = new Call();
            for (int i = 0; i < callHystory.Count; i++)
            {
                if(callHystory[i].CallDuration > tempCall.CallDuration)
                {
                    tempCall = callHystory[i];
                }
            }
            return tempCall;
        }

        public override string ToString()
        {
            return DealedPhoneNumber + " " + this.Date + " " + this.Time + " " + this.CallDuration +
                " minutes";
        }
    }
}
