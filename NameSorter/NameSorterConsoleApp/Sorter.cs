using System.Collections.Generic;
using NameSorterInterface;

namespace NameSorterConsoleApp
{
    public class NameSorter : SorterInterface
    {
        public static void Sorter(List<Name> nameList)
        {
            nameList.Sort();
        }
    }
}