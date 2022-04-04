using System;

namespace experiment3
{
    class Program
    {
        static void Main(string[] args)
        {
            
           var distance1 = Distance.FromMeter(7);
           var distance2 = Distance.FromMeter(13);
           var distance3 = distance1 + distance2;

           Console.WriteLine(distance3.AsMeter());
           Console.ReadKey();
           

        



        }
    }
}
