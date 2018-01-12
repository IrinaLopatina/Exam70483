using System;
using System.IO;
using System.Xml.Serialization;

namespace Exam70483_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = null;

            using (var stream = new FileStream(@"../../Data.txt", FileMode.Open))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Catalog), new Type[]{typeof(Book)});
                catalog = (Catalog)xml.Deserialize(stream);
            }

            foreach (var book in catalog.Books)
            {
                Console.WriteLine("Book id: {0}", book.Id);
                Console.WriteLine("Author: {0}", book.Title);
                Console.WriteLine("Author: {0}", book.Author);
                Console.WriteLine("Price: {0}", book.Price);
                Console.WriteLine("Publish date: {0}", book.Publish_date);

                Console.WriteLine("**********************************************");
            }
        }
    }
}
