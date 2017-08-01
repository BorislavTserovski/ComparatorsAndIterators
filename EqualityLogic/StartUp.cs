using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityLogic
{
    public class StartUp
    {
       public static void Main()
       {
           int n = int.Parse(Console.ReadLine());
            SortedSet<Person> peopleSorted = new SortedSet<Person>();
            HashSet<Person> peopleHash = new HashSet<Person>();
           for (int i = 0; i < n; i++)
           {
               string[] input = Console.ReadLine().Split();
               string name = input[0];
               int age = int.Parse(input[1]);
               Person person = new Person(name, age);
               peopleSorted.Add(person);
               peopleHash.Add(person);
           }
           Console.WriteLine(peopleSorted.Count);
           Console.WriteLine(peopleHash.Count);
       }
    }
}
