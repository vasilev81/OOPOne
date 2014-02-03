

namespace Mobile
{
    using System;

    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }
    public class GSMBattery
    {
        private string batteryModel;
        private int hourseIdle;
        private int hourseTalk;
        private BatteryType type;

        public GSMBattery(string model)
        {
            this.batteryModel = model;
            this.HourseIdle = 48;
            this.hourseTalk = 8;

        }
        public GSMBattery(string model, int idle)
            : this(model)
        {
            this.HourseIdle = idle;
        }
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        public int HourseIdle
        {
            get { return this.hourseIdle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The battery is dead");
                }
                this.hourseIdle = value;

                
            }
        }

        public int HoursTalk
        {
            get { return this.hourseTalk; }
            set { this.hourseTalk = value; }
        }
        public BatteryType Type
        {
            get
            {
                return type;
            }
        }
    }
}
   

