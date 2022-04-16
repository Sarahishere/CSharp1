using static System.Console;
using System;

namespace Excercises
{
    class Program
    {
        static void Main(string[] args)
        {   
           
            Excercise.reverseStringTry("Hello, Sarah! Everything is gonna be ok.");  
            Excercise.reverseString("Hello, Sarah! Everything is gonna be ok.");  
            Excercise.checkPalindrome("SamamaS");
            Excercise.reverseWordsTry(" Welcome  to     Earth");
            
            Excercise.reverseWords(" Welcome  to     Earth");

            Excercise.checkPalindromeTry("SamamaS"); 
            Excercise.countOccurenceString("Hello  World Helowd"); 
            Excercise.removeDuplicateChar("CharrReeCmmovveE"); 
            Excercise.subStringFormer("abge"); 
            int[] arr = {5,4,3,2,1,0};
            Excercise.leftRotateArray(arr);
            WriteLine();
            Excercise.rightRotateArray(arr); 
            WriteLine(Excercise.checkPrime(18)); 
            WriteLine(Excercise.sumOfDigit(23112));  
            int[] arr2 = {53,53,33,32,12,30};
             Excercise.convertToMultiArray(arr2,2,3);
            WriteLine(Excercise.findSecondLargest(arr2));  
            int[,] arr3 = new int[,]{{1,2,3},{4,5,6},{7,8,9}};
            Excercise.converToSingleArray(arr3);
           
            
        }
       

    }
}
