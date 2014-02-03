
namespace Mobile
{
    using System;
    class Test
    {
        static void Main()
        {
            GSMBattery nokiaBattery = new GSMBattery("BL-5BT",6);

            //nokiaBattery.BatteryModel = "BL-5BT";
            //nokiaBattery.HoursTalk = 6;
            //nokiaBattery.HoursIdle = 24;
            

            Display display = new Display();

            display.Size = 3;
            display.Colors = 4096;

            GSM nokia = new GSM("3310", "Nokia", 350);

            nokia.Battery = nokiaBattery;
            nokia.Display = display;

            //nokia.Owner = "Ivo";

            //nokia.Price = 350;
            //Console.WriteLine(nokia.Battery.Type);

            nokia.GSMInfo(nokia);
            //Console.WriteLine("Manifacturer: {0}", nokia.Manufacturer);
            //Console.WriteLine("Model: {0}",nokia.Model);
            //Console.WriteLine("Price: {0}lv",nokia.Price);
            //Console.WriteLine("Owner: {0}",nokia.Owner);
            //Console.WriteLine("Battery Characteristics:\n"+"Model: "+nokia.Battery.BatteryModel+"\n"+
            //    "Hours Talk: "+nokia.Battery.HoursTalk + "\n" +"Hours Idle: "+nokia.Battery.HoursIdle);
            //Console.WriteLine("Display Characteristics:\n"+ "Size: " + nokia.Display.Size +"\n"+
            //    "Colors: "+nokia.Display.Colors);
        }
    }
}


