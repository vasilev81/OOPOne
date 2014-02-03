
namespace Mobile
{
    using System;
    using System.Threading;
    class GSMTest
    {
        static void Main()
        {    
            
            GSM gsm = new GSM("3212", "Nokia");
         
            gsm.Call = new Call("0889675432");

            Thread.Sleep(200);

            gsm.Call = new Call("0898765412");

            Thread.Sleep(20);

            gsm.Call = new Call("0889562134");

            Console.WriteLine("Call history:");
                      
            foreach (var call in Call.CallHystory)
            {
                Console.WriteLine(call);
            }

            Console.WriteLine();

            Console.WriteLine("The price for the calls is: " + gsm.CallPrice(0.37M) + "lv");

            Console.WriteLine();

            gsm.CallHistory.Remove(gsm.Call.LongestCall());

            Console.WriteLine("Call history after removing the longest call:");           

            foreach (var call in Call.CallHystory)
            {
                Console.WriteLine(call);
            }

            Console.WriteLine();

            Console.WriteLine("The price for the calls is: " + gsm.CallPrice(0.37M) + "lv");

            Console.WriteLine();

            gsm.ClearCallHistory();

            Console.WriteLine("Call history after clearing: ");

            foreach (var call in Call.CallHystory)
            {
                Console.WriteLine(call);
            }
            
        }
    }
}


