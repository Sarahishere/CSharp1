using System;

namespace NameSorterConsoleApp
{
    public class Name:IComparable<Name>
    {
        public string LastName;
        public string OtherName; // all given names
        
        
        // Constructor
        public Name(string lastName,string otherName) 
          => (LastName,OtherName) = (lastName,otherName);

        public int CompareTo(Name other)
        {
            int result = this.LastName.CompareTo(other.LastName);
            if(result != 0) 
            {
                return result; // compare lastName when the lastNames are not the same
            }
            return this.OtherName.CompareTo(other.OtherName); // compare the given names when lastNames are the same
        }

        public override string ToString()
        {
            return $"{OtherName}{LastName}";
        }
    }

    
}