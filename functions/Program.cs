using System;
using static System.Console;


namespace experiment
{
    class Program
    {

  

        static void Main(string[] args)
        { 

         //RunTimesTable();
         //RunCardinalToOrdinal();
         //RunFactorial();
         RunFibonacci();
         

        } 

        static void TimesTable(byte num)
        {
            WriteLine($"This is the times table for number: {num}");

            for(int row = 1; row < num + 1; row++){
                WriteLine($"{row} x {num} = {row * num}");

            }



        }
        static void RunTimesTable()
        {
            bool validNum;
            
         
        do{ 
            WriteLine("Enter a number between 0 and 255 to get the times table for:");
            validNum = byte.TryParse(ReadLine(), out byte num);

            if(validNum) TimesTable(num);
            else WriteLine("Invalid input for number");
        
        }while(validNum);

        }


        static void RunCardinalToOrdinal()
        {
            for(int num = 1; num < 31; num++ ){
                string ordinal = CardinalToOrdinal(num);
                Write($" {ordinal} ");

            }
        }

        static string CardinalToOrdinal(int num)
        {
            

            switch(num){
                case 11:
                case 12:
                case 13:
                  return $"{num}th";
                default:
                  int lastDigit = num % 10;
                  string suffix = lastDigit switch{
                      1 => "st",
                      2 => "nd",
                      3 => "rd",
                      _ => "th"
                 
                  };

                  return $"{num}{suffix}";

                 

            }
        } 




        static void RunFactorial()
        {
            for(int i = 1; i < 16; i++){
                try{
                    WriteLine($"{i}! = {Factorial(i):N0}");
                }catch(Exception e){
                    //WriteLine($"An overflow happened with {i}");
                    WriteLine($"For number {i} {e.GetType()} says {e.Message}");

                }

            } 
            ReadKey();
        } 

        static int Factorial(int num)
        { 
            int factorial = 1;
            checked
            {
                for(int i = num; i > 0; i--){
                factorial *= i;
                }
            
                return factorial;
            }
        }

        static void RunFibonacci()
        {
            // output all the finonacci numbers for 25 terms

            for(int i = 1; i < 26;i++ ){
                int fiboNumber = Fibonacci(i);
                WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is: {fiboNumber}");

            }

        }

        static int Fibonacci(int term)
        {
            switch(term){
                case 1: return 0; 
                case 2: return 1; 
                default: return (Fibonacci(term - 1) + Fibonacci(term - 2)); 

            }


        }






    } 

    
}
