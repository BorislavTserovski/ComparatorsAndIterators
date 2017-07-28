using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{
   public class StartUp
    {
       public static void Main()
       {
           string input = Console.ReadLine();
            List<Person> people = new List<Person>();
           while (input!="END")
           {
               string[] args = input.Split();
               string name = args[0];
               int age = int.Parse(args[1]);
               string town = args[2];
               Person person = new Person(name, age, town);
               people.Add(person);
               input = Console.ReadLine();
           }

           int n = int.Parse(Console.ReadLine());

           Person comparer = people[n -1];
           people.Remove(comparer);
           if (people.All(p => p.CompareTo(comparer) != 0))
           {
                Console.WriteLine("No matches");
           }
           else
           {
               people.Add(comparer);
               int equal = 0;
               foreach (var person in people)
               {
                   if (person.CompareTo(comparer)==0)
                   {
                       equal++;
                   }
               }
               Console.WriteLine($"{equal} {people.Count - equal} {people.Count}");
           }
       }
    }
}
