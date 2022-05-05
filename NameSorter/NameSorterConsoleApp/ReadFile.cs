using System;
using System.Collections.Generic;
using System.IO;
using NameSorterInterface;

namespace NameSorterConsoleApp
{
    public class ReadFile : ReadInterface
    {
        public string[] Lines;
       
       // read all text and store in string array
        public ReadFile(string inputFileName)
        {
            try
            {
                Lines = File.ReadAllLines(inputFileName);
            }
            catch(Exception e)
            {
                Console.WriteLine("\nFailed to Read File");
                Console.WriteLine(e.Message);
            }
        }

        // output the content to List<Name>
        public List<Name> GetNameList()
        {  
            
            List<Name> nameList = new List<Name>();
            foreach(var line in Lines)
               {   string otherName = null;
                   string lastName = null;
                   string[] namesArr = line.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                   for (int i = 0;  i < namesArr.Length - 1;i++)
                   {
                       
                       otherName += namesArr[i] + " ";
                   }
                   lastName = namesArr[namesArr.Length - 1];
                   nameList.Add(new Name(lastName,otherName)); //add new name instances to List
               }
                
                return nameList;
        }
    }
}