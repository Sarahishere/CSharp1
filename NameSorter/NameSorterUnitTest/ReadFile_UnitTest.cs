using System;
using System.Collections.Generic;
using NameSorterConsoleApp;
using Xunit;

namespace NameSorterUnitTest
{
    public class ReadFile_UnitTest
    {
        [Fact]
        public void Should_ReturnListOfName()
        {
            string inputFileName = "TestFile.txt";
            ReadFile reader = new ReadFile(inputFileName);
            List<Name> actual = new List<Name>
            {
                new Name("Cat","Alen "),
                new Name("Ali","Aaron Gu ")
            };
            
            List<Name> expected = reader.GetNameList();
            Assert.Equal(expected,actual);
        }
    }
}
