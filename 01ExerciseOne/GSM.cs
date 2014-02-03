using System;
using System.Collections.Generic;

namespace Mobile
{
    public class GSM
    {
        private static IPhone4S iPhone;

        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private GSMBattery battery;
        private Display display;
        private Call call;




        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = 0;
            this.owner = null;
            this.battery = null;
            this.display = null;
            iPhone = new IPhone4S("black");
            this.call = null;
        }
        public GSM(string model, string manufacturer, int price)
            : this(model, manufacturer)
        {
            this.price = price;
        }

        public static IPhone4S IPhone
        {
            get
            {
                return iPhone;
            }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public int Price
        {
            get { return this.price; }
            set
            {
                if (this.price < 0)
                {
                    throw new Exception("Price must be positive integer");
                }

                this.price = value;
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public GSMBattery Battery
        {
            get
            {
                return this.battery;
            }
            set { this.battery = value; }
        }
        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public Call Call
        {
            get
            {
                return this.call;
            }
            set
            {
                this.call = value;
                AddCallInHistory(this.call);
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return Call.CallHystory;
            }
        }

        public void Info(GSM gsm)
        {
            Console.WriteLine(gsm.ToString());
        }

        public static void IPhoneInfo()
        {
            Console.WriteLine("iPhone4 Info: \n" + "Color: " + iPhone.Color + "\n"
                + "Memory: " + iPhone.InternalMemory + "GB" + "\n" +
                "Weight: " + iPhone.Weight + "gr");

        }

        public void AddCallInHistory(Call call)
        {
            Call.CallHystory.Add(call);
        }

        public void DeleteCallFromhistory(Call call)
        {
            Call.CallHystory.Remove(call);
        }

        public void ClearCallHistory()
        {
            Call.CallHystory.Clear();
        }

        public decimal CallPrice(decimal pricePerMinute)
        {
            decimal totalPrice = 0;

            for (int i = 0; i < Call.CallHystory.Count; i++)
            {
                totalPrice += Call.CallHystory[i].CallDuration * pricePerMinute;
            }
            return totalPrice;
        }

        public override string ToString()
        {
            return Manufacturer + " " + Model;
        }
    }
}


