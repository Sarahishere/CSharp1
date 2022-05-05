using System.Collections.Generic;
using NameSorterConsoleApp;
using Xunit;

namespace NameSorterUnitTest
{
    public class Sorter_UnitTest
    {
        [Fact]
    public void Should_SortList()
    {
        List<Name> actualList = new List<Name>
        {
            new Name("Cat","Alen"), 
            new Name("Ali","Helen Ha"),
            new Name("Ali","Aaron"),
            new Name("Bo","Cathy Na")
        };

        List<Name> expected = new List<Name>
        {
            new Name("Ali","Aaron"),
            new Name("Ali","Helen Ha"),
            new Name("Bo","Cathy Na"),
            new Name("Cat","Alen")
        };

        NameSorter.Sorter(actualList);
        Assert.Equal(expected,actualList);
    }
    }

    
}