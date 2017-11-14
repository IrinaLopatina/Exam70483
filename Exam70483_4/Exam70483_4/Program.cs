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
            Console.BufferHeight = 1000;
            MyCollection <Box> myCollection = new MyCollection<Box>();

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
            DisplayArray(boxArray1);
            
            Console.WriteLine("Trying to get element collection[3] ...");
            var elem = myCollection[3];
            DisplayElement(elem);

            Console.WriteLine("Trying to set the box at collection[3]...");
            myCollection[3] = new Box(100, 200, 300, "Brown");
            DisplayCollection(myCollection);

            Console.WriteLine("Trying to determine index of Box 100*200*300 ...");
            var index = myCollection.IndexOf(new Box(100, 200, 300, "Brown"));
            Console.WriteLine("Index is {0}", index);

            Console.WriteLine("Trying to insert the box at collection[5]...");
            myCollection.Insert(5, new Box(40, 41, 42, "Blue"));
            DisplayCollection(myCollection);

            Console.WriteLine("Trying to remove the item at [5]...");
            myCollection.RemoveAt(5);
            DisplayCollection(myCollection);

            Console.WriteLine("Trying to clear the collection...");
            myCollection.Clear();
            DisplayCollection(myCollection);
        }

        private static void DisplayCollection(MyCollection<Box> collection)
        {
            Console.WriteLine("********************COLLECTION********************");
            Console.WriteLine("Total boxes: {0} \n", collection.Count());
            foreach (var box in collection)
            {
                Console.WriteLine("Length: {0}, Height: {1}, Width: {2}, Color: {3}", box.Length, box.Height, box.Width, box.Color);
            }
            Console.WriteLine("**************************************************");
        }

        private static void DisplayArray(Box[] array)
        {
            Console.WriteLine("**********************ARRAY***********************");
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    Console.WriteLine("Index {0}: Length: {1}, Height: {2}, Width: {3}, Color: {4}", i, array[i].Length, array[i].Height, array[i].Width, array[i].Color);
                }
                else
                {
                    Console.WriteLine("Index {0}: null", i);
                }
            }
            Console.WriteLine("**************************************************");
        }

        private static void DisplayElement(Box element)
        {
            Console.WriteLine("**********************ELEMENT***********************");

            if (element != null)
            {
                Console.WriteLine("Element: Length: {0}, Height: {1}, Width: {2}, Color: {3}", element.Length, element.Height, element.Width, element.Color);
            }
            else
            {
                Console.WriteLine("Element: null");
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
