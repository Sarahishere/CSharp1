using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using static System.Console;

namespace ReadCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Attendants> attendantsList;
            var config = new CsvConfiguration(CultureInfo.InvariantCulture){
                PrepareHeaderForMatch = args => args.Header.ToLower(),
            };

            #region Read csv file and display data
            using(var reader = new StreamReader(@"../ReadCSV/Attendants.csv"))
            using(var csvReader = new CsvReader(reader,config))
            {
                var csvRecords = csvReader.GetRecords<Attendants>();
                attendantsList = new List<Attendants>(csvRecords);

            }

            foreach(var v in attendantsList){
                WriteLine($"{v.ID}  {v.Name}  {v.Phone}");
            }
            #endregion Read csv file and display data

            #region writing to file
            var attendant1 = new Attendants("157","Tom Flute","233656");
            var attendant2 = new Attendants("117","Vic Tenct","313656");
            attendantsList.Add(attendant1);
            attendantsList.Add(attendant2);
            
            WriteLine("\n New Attendants list:");
            foreach(var v in attendantsList){
                WriteLine($"{v.ID}  {v.Name}  {v.Phone}");
            }

            string fileName = DateTime.Now.Ticks + "Attendants.csv";

            using(var writer = new StreamWriter(@"../ReadCSV/"+fileName))
            using(var csvWriter = new CsvWriter(writer,config)){
                csvWriter.WriteRecords(attendantsList);
            }



            #endregion writing to file

        }
    }
}
