using System;
using System.Collections.Generic;
using System.Text;

namespace AdvConcepts
{
    class PersonLoader
    {
        public static List<Person> GetPeople(int numPeople)
        {
            string[] firstnames = { "John", "Billy", "Karan", "Alex", "Stan", "Edan", "Liron", "Ronel", "Lauren", "Katherine", "Jessica" };
            string[] lastnames = { "Smith", "Johnson", "Halt", "Brown", "Black", "Garcia", "Fernandez", "Hernandez", "Miller", "Davis" };

            Random gen = new Random();

            List<Person> people = new List<Person>();

            for (int i = 0; i < numPeople; i++)
            {

                string fname = firstnames[gen.Next(firstnames.Length)];
                string lname = lastnames[gen.Next(lastnames.Length)];
                int age = gen.Next(1,122);

                Person temp = new Person()
                {
                    FirstName = fname,
                    LastName = lname,
                    Age = age
                };

                people.Add(temp);

            }
            return people;
        }
    }
}
