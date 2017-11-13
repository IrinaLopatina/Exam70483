using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_4
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<Person> myCollection = new MyCollection<Person>
            {
                new Person { Name = "Karsten", Age = 46, Address = "Norway" },
                new Person { Name = "Nina", Age = 67, Address = "Russia" },
                new Person { Name = "Valeria", Age = 11, Address = "Norway" },
                new Person { Name = "Nikita", Age = 16, Address = "Russia" },
                new Person { Name = "Marina", Age = 4, Address = "Norway" },
                new Person { Name = "Irina", Age = 43, Address = "Norway" },
                new Person { Name = "Nikolai", Age = 68, Address = "Russia" },
                new Person { Name = "Viktor", Age = 7, Address = "Norway" }
            };

            Console.WriteLine("Total person: {0} \n\n", myCollection.Count());
            foreach (var person in myCollection)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Address: {2}", person.Name, person.Age, person.Address);
            }
        }

    }

    /* Yield return example 
       static void Main(string[] args)
       {
           foreach (string s in Foo())
           {
               Console.WriteLine("Printing.... {0}", s);
           }
       }

       static IEnumerable<string> Foo()
       {
           yield return "1 string";
           yield return "2 string";
           yield return "3 string";
           yield return "4 string";
       }
       */
}
