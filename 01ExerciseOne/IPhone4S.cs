
using System;
namespace Mobile
{
    public class IPhone4S
    {
        private string color;
        private int internalMemory;
        private int weight;

        public IPhone4S(string color)
        {
            this.color = color;
            internalMemory = 8;
            weight = 140;

        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                if(this.color != "white" && this.color != "black")
                {
                    throw new ArgumentException("Te color of IPhone4S is white or black");
                }

                this.color = value;
            }
        }

        public int InternalMemory
        {
            get
            {
                return this.internalMemory;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
        }

      
    }
}
