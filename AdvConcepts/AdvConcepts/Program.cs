using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvConcepts
{
    class Program
    {
        static void Main(string[] args)
        {




            List<Person> people = PersonLoader.GetPeople(20);

            // LINQ -> language integrated query

            // Order the people by age

            // data -> order, filter, project (look at certain properties/columns)

            //foreach (var person in people.OrderByDescending(x => x.Age))
            //{
            //    Console.WriteLine(person);
            //}

            foreach (var person in people.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ThenByDescending(x => x.Age))
            {
                Console.WriteLine(person);
            }


            int sumOfAllAges = people.Sum(x => x.Age);

            Console.WriteLine($"Sum of the ages of all people is {sumOfAllAges}");

            double averageAge = people.Average(x => x.Age);

            Console.WriteLine($"The average age was {averageAge}");
            Console.WriteLine($"Here are all the people whose age is greater than the average age: ");
            foreach (var person in people.Where(x => x.Age >= averageAge).OrderByDescending(x => x.Age).ThenBy(x => x.LastName))
            {
                Console.WriteLine(person);
            }

            // print out all the people who are less than the average and have them ordered by ascending age and descending last name
            Console.WriteLine($"Here are all the people whose age is less than the average age: ");
            foreach (var person in people.Where(x => x.Age < averageAge).OrderBy(x => x.Age).ThenByDescending(x => x.LastName))
            {
                Console.WriteLine(person);
            }

            // get a list of all the unique first names in the people list

            var uniqueNames = people.OrderBy(x => x.FirstName).Select(x => x.FirstName);//.Distinct();

            people.Add(new Person { FirstName = "Kal", LastName = "El", Age = 35 });
            ;

            foreach (var firstname in uniqueNames)
            {
                Console.WriteLine(firstname);
            }


            var myArray = uniqueNames.ToArray();

            var myValues = Array.FindAll(myArray, (name) => (name.Length > 2));

            ;


            var allLastNames = from person in people
                               where person.LastName.ToLower().StartsWith('b')
                               orderby person.LastName
                               select person;
            ;

            Console.WriteLine(myValues);


        }
    }
}
