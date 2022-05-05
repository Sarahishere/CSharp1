using System;
using System.Collections.Generic;

namespace NameSorterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           if (args.Length == 0)
            {
                // No argument found, so give the user a clue
                System.Console.WriteLine("name-sorter : No file name argument found");
                Environment.Exit(-1);
            }
            
            string fileName = args[0];
            //read file and get list of Name instances
            
            List<Name> nameList = new ReadFile(fileName).GetNameList(); 
            //sort the list of Name instances
            NameSorter.Sorter(nameList);
            //write and display sorted file
            new WriteFile().WriteToFile(nameList);

            Environment.Exit(0); 
        }
    }
}
