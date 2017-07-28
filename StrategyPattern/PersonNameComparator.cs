using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PersonNameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        if (x.Name.Length != y.Name.Length)
        {
            return x.Name.Length - y.Name.Length;
        }
        return x.Name[0].ToString().ToLower()
            .CompareTo(y.Name[0].ToString().ToLower());
    }
}

