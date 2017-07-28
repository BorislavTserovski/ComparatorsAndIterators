using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class StartUp
    {
       public static void Main()
       {
           int n = int.Parse(Console.ReadLine());
            PersonNameComparator nameComp = new PersonNameComparator();
            PersonAgeComparator ageComp = new PersonAgeComparator();
            SortedSet<Person> sortedByName = new SortedSet<Person>(nameComp);
            SortedSet<Person> sortedByAge = new SortedSet<Person>(ageComp);
           for (int i = 0; i < n; i++)
           {
               string[] input = Console.ReadLine().Split();
               string name = input[0];
               int age = int.Parse(input[1]);
               Person person = new Person(name, age);
               sortedByName.Add(person);
               sortedByAge.Add(person);
           }

           foreach (var person in sortedByName)
           {
               Console.WriteLine($"{person.Name} {person.Age}");
           }

           foreach (var person in sortedByAge)
           {
               Console.WriteLine($"{person.Name} {person.Age}");
           }
        }
    }
}
