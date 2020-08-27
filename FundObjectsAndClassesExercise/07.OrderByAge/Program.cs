using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> people = new List<Person>();

            while (input != "End")
            {
                string[] personInfo = input.Split();
                Person person = new Person(personInfo[0], personInfo[1], int.Parse(personInfo[2]));
                people.Add(person);

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, people.OrderBy(person => person.Age)));
        }
    }

    public class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
