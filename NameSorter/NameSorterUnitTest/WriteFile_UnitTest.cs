using System.Collections.Generic;
using NameSorterConsoleApp;
using Xunit;

namespace NameSorterUnitTest
{
    public class WriteFile_UnitTest
    {
        
        [Fact]
        public void Should_WriteToFile()
        {
            
            List<Name> nameList = new List<Name>
            {
                new Name("Ama","Mand "),
                new Name("Beli","Bob "),
                new Name("Cat","Do ")
            };

            WriteFile writer = new WriteFile();
            writer.WriteToFile(nameList);

            ReadFile reader = new ReadFile(@"sorted-names-list.txt");
            List<Name> actualList = reader.GetNameList();
            Assert.Equal(nameList,actualList);

        }
    }
}