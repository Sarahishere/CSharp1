using System;
using static System.Console;


namespace experiment
{
    class Program
    {

  

        static void Main(string[] args)
        { 

         RunTimesTable();

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

    } 

    
}
