using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_4
{
   
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<Box> myCollection = new MyCollection<Box>();

            myCollection.Add(new Box(10, 12, 12, "Green"));
            myCollection.Add(new Box(5, 67, 2, "Red"));
            myCollection.Add(new Box(16, 11, 45, "Green"));
            myCollection.Add(new Box(100, 16, 1, "Pink"));
            myCollection.Add(new Box(45, 4, 4, "Blue"));
            myCollection.Add(new Box(20, 43, 10, "Green"));
            myCollection.Add(new Box(75, 68, 90, "Black"));
            myCollection.Add(new Box(24, 7, 15, "Yellow"));

            Console.WriteLine("Trying to add the same box...");
            myCollection.Add(new Box(20, 43, 10, "Green"));

            DisplayCollection(myCollection);

            Console.WriteLine("Trying to remove non-existing box from collection...");
            myCollection.Remove(new Box(1, 1, 1, "Green"));
            DisplayCollection(myCollection);

            Console.WriteLine("Trying to remove existing box from collection...");
            myCollection.Remove(new Box(20, 43, 10, "Green"));
            DisplayCollection(myCollection);

            Console.WriteLine("Trying to copy collection to the array ...");
            Box[] boxArray1 = new Box[10];
            myCollection.CopyTo(boxArray1, 7);

            DisplayCollection(myCollection);

            /*
            Console.WriteLine("Trying to clear the collection...");
            myCollection.Clear();
            DisplayCollection(myCollection);
            */
        }

        private static void DisplayCollection(MyCollection<Box> collection)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("Total boxes: {0} \n", collection.Count());
            foreach (var box in collection)
            {
                Console.WriteLine("Length: {0}, Height: {1}, Width: {2}, Color: {3}", box.Length, box.Height, box.Width, box.Color);
            }
            Console.WriteLine("**************************************************");
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
