using static System.Console;
using System;
using System.Text;
using System.Collections.Generic;

public class Excercise
{
             public static void reverseString(string str)
         {
             char[] arr =str.ToCharArray();
             Array.Reverse(arr);
             string newStr = new String(arr);
             WriteLine(newStr);

         }
         
         public static void reverseStringTry(string str)     //method to reverse string
        {
            char[] arr = str.ToCharArray();
            for(int i = 0, j = str.Length - 1; i < str.Length; i++,j--){
               arr[i] = str[j];
            }
            string newStr = new string(arr);
            WriteLine(newStr);
        }

        // check palindrome 
        public static void checkPalindrome(string str)
        {
            char[] arr = str.ToCharArray();
            bool isPalindrome = true;
            for(int i = 0, j = str.Length - 1; i < j;i++, j--){
              if(arr[i] != str[j]) isPalindrome = false;
            }
            
           var result =  isPalindrome  ? $"{str} is palindrome" : $"{str} is Not palindrome" ;
            
            WriteLine(result);
        }

        public static void checkPalindromeTry(String str)
        {
            
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string newStr = new String(arr);
            var result =  str.Equals(newStr)  ? $"{str} is palindrome" : $"{str} is Not palindrome" ;
            
            WriteLine(result);

        }
        // reverse words in a string
        public static void reverseWordsTry(string str)
        {
            int newArrLength = 0;
            string[] arr = str.Split();
            newArrLength = arr.Length;
            string[] newArr = new string[newArrLength];
            for(int i = arr.Length - 1, j = 0; i >= 0; i--,j++){
                newArr[j] = arr[i];
            }
            
            string newStr = string.Join(" ",newArr);
            WriteLine(newStr);
            
        }

         public static void reverseWords(string str)
        {
           StringBuilder newStr = new StringBuilder();
           int start = str.Length - 1;
           int end = str.Length - 1;
           int i;

           while(start > 0){
               if(str[start]==' '){
                   i = start + 1;
                   while(i<=end)
                   {
                       newStr.Append(str[i]);
                       i++;
                   }
                   newStr.Append(' ');
                   end = start - 1;
               }
               start--;
           }
           for(i = 0; i <= end; i++)
           {
               newStr.Append(str[i]);
           }
           WriteLine(newStr.ToString());
   
        }

        public static void countOccurenceString(string str)
        {
            Dictionary<char,int> charCount = new Dictionary<char, int>();

            foreach( var c in str){
                if(c != ' '){
                    if(!charCount.ContainsKey(c)){
                        charCount.Add(c,1);
                    }else{
                        charCount[c]++;
                    }

                }

            }
            foreach(var v in charCount){
                WriteLine("{0} - {1}",v.Key,v.Value);
            }

        }

        public static void removeDuplicateChar(string str)
        {
            string newStr = string.Empty;
            foreach(var v in str){
                if(!newStr.Contains(v)){
                    newStr += v;
                }

            }
            WriteLine(newStr);

        }

        public static void subStringFormer(string str)
        {
            
            for(int i = 0; i < str.Length; i++){
               for(int j =  1; j <= str.Length - i; j++){
                    
                    WriteLine(str.Substring(i,j));
                }

            }
            

        }

        public static void leftRotateArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for(int i = 1,j = 0; i < arr.Length; i++,j++){
                newArr[arr.Length - 1] = arr[0];
                newArr[j] = arr[i];
            }

            foreach(var num in newArr){
                Write(num + "\t");

            }
        }

        public static void rightRotateArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for(int i = 0,j = 1; j < arr.Length; i++,j++){
                newArr[0] = arr[arr.Length - 1];
                newArr[j] = arr[i];
            }

            foreach(var num in newArr){
                Write(num + "\t");

            }
        }

        public static bool checkPrime(int num)
        {
            if(num <= 1){
                return false;
            }

            for(int i = 2; i <= Math.Sqrt(num); i++){
                if( num % i == 0){
                    return false;
                }
            }

            return true;
        }

        public static int sumOfDigit(int num)
        {
            
            int sum = 0;
            foreach(var v in num.ToString()){
                sum += (int)Char.GetNumericValue(v);

            }

            return sum;

        }

        public static int findSecondLargest(int[] arr)
        {
           if(arr.Length < 2){
               WriteLine("Invalid array");
               return -1;
           } 

           Array.Sort(arr);

           for(int i = arr.Length - 2; i >= 0; i--){
               if(arr[i] != arr[arr.Length -1]){
                   return arr[i];
               }
           }

           return -1;

           
        }

        public static void converToSingleArray(int[,] multiArr)
        {   int index = 0;
            int length0 = multiArr.GetLength(0);
            int length1 = multiArr.GetLength(1);
            int[] singleArr = new int[length0*length1];
            for(int i = 0; i < length1; i++){
                for(int j = 0; j < length0; j++){
                    singleArr[index] = multiArr[j,i];
                    
                    Write(singleArr[index] + " ");
                    index++;
                }

            }
        }

        public static void convertToMultiArray(int[] arr, int row, int column)
        {
            int index = 0;
            int[,] multiArr = new int[row,column];
            for(int i = 0; i < row; i++){
                for(int j = 0; j < column; j++){
                    multiArr[i,j] = arr[index];
                    index++;
                    Write(multiArr[i,j] + " ");
                }
                WriteLine();
            }

        }


}