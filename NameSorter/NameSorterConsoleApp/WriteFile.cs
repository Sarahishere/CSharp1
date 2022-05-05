using System;
using System.Collections.Generic;
using System.IO;
using NameSorterInterface;

namespace NameSorterConsoleApp
{
    public class WriteFile : WriteInterFace
    {
        public void WriteToFile(List<Name> nameList)
        {
           try
           {
               using (StreamWriter writer = new StreamWriter(@"sorted-names-list.txt"))
               {
                   foreach(var name in nameList)
                   {
                       Console.WriteLine(name.ToString());
                       writer.WriteLine(name.ToString());
                   }
               }
           }
           catch(Exception e)
           {
               Console.WriteLine("Failed to Write the File");
               Console.WriteLine(e.Message);
           }
        }
    }
}