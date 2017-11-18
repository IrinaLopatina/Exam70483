using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_6
{
    class Country
    {
        public string Name { get; set; }
        public float Area { get; set; }
        public long Population { get; set; }
        public string Language { get; set; }

        public Country(string name, float area, long population, string language)
        {
            Name = name;
            Area = area;
            Population = population;
            Language = language;
        }
    }

    class CountryList
    {
        List<Country> data = new List<Country>
        {
            new Country("Norway", 44, 5000000, "norwegian"),
            new Country("Greate Britain", 90, 40000000, "english"),
            new Country("Germany", 75, 60000000, "german"),
            new Country("Australia", 130, 62000000, "english"),
            new Country("Russia", 500, 144000000, "russian"),
            new Country("USA", 250, 300000000, "english"),
            new Country("Belarus", 30, 20000000, "russian"),
        };

        public List<Country> Get()
        {
            return data;
        }

        public void Print()
        {
            Console.WriteLine("*** Printing country list (total: {0}) ***", data.Count);
            data.ForEach(x => PrintCountry(x));
            Console.WriteLine("******************************************");
        }

        private void PrintCountry(Country x)
        {
            Console.WriteLine("Name : {0}, Area : {1}, Population : {2}, Language : {3}", x.Name, x.Area, x.Population, x.Language);
        }
    }
}
