using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityLogic
{
   public class Person:IComparable<Person>
    {

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (this.Name.ToLower()==other.Name.ToLower()&&this.Age==other.Age)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public override bool Equals(object obj)
        {
            Person objAsPerson = obj as Person;
            return this.Name.ToLower() == objAsPerson.Name.ToLower() && this.Age == objAsPerson.Age;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode();
        }
    }
}
