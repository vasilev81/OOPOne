
namespace Mobile
{
    using System;
    public class Display
    {
        private int size;
        private int colors;

        public Display(int displaySize)
        {
            this.size = displaySize;
            this.colors = 256;
        }
        public Display(int displaySize, int displayColors)
        {
            this.size = displaySize;
            this.colors = displayColors;
        }
       public int Size
        {
           get
            {
                return this.size;
            }
            set
            {
                if(this.size <= 0)
                {
                    throw new ArgumentException("No display with such size");
                }              
                this.size = value;
               
            }
        }
        public int Colors
       {
            get
           {
               return this.colors;
           }
           set
           {
               this.colors = value;
           }
       }
    }
}
