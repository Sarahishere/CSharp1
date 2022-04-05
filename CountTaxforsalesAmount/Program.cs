using System;
using static System.Console;

namespace experiment3
{
    class Program
    {
        static void Main(string[] args)
        {
            
          RunCalculateTax();
       
        }

        static void RunCalculateTax()
        { 
            decimal amount = 0.00M,tax;
            string region;
            
            WriteLine("\nEnter a sales amount:");
            if(decimal.TryParse(ReadLine(),out decimal input)){
                amount = input;
            }else{
                WriteLine("Invalid input for tax");
            }

            WriteLine("Enter a region code e.g.QLD:");
           region = ReadLine();

           tax = CalculateTax(amount,region);

           WriteLine($"\nThe sales tax for {amount:C} is: {tax:C}");

           ReadKey();



            
        }

        static decimal CalculateTax(decimal amount, string region)
        {
            decimal rate;
            switch(region){
                case "QLD": rate = 0.08M;break;
                case "NSW": rate = 0.25M;break;
                case "VC" : rate = 0.27M;break;
                default: rate = 0.00M;break;
                
            }

            return amount * rate;


        }






    }
}
