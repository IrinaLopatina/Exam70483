using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_6
{
    class CountryHelper
    {
        List<Country> countries;

        public CountryHelper()
        {
            countries = new List<Country>
            {
                new Country(1, "Norway", "Oslo", 44, 5000000, "norwegian"),
                new Country(2, "Greate Britain", "London", 90, 40000000, "english"),
                new Country(3, "Germany", "Berlin", 75, 60000000, "german"),
                new Country(4, "Australia", "Canberra", 130, 62000000, "english"),
                new Country(5, "Russia", "Moscow", 500, 144000000, "russian"),
                new Country(6, "USA", "Washington", 250, 300000000, "english"),
                new Country(7, "Belarus", "Minsk", 30, 20000000, "russian"),
            };
        }

        public List<Country> Get()
        {
            return countries;
        }

        public void Print()
        {
            Console.WriteLine("*** Printing country list (total: {0}) ***", countries.Count);
            countries.ForEach(x => PrintCountry(x));
            Console.WriteLine("******************************************");
        }

        internal void PrintCountry(Country x)
        {
            if (x == null)
            {
                Console.WriteLine("Can't print non-existing country!");
                return;
            }
            Console.WriteLine("Code : {0, -3}, Name : {1,-15}, Capital : {2,-10}, Area : {3, -5}, Population : {4, -10}, Language : {5}", x.Code, x.Name, x.Capital, x.Area, x.Population, x.Language);
        }

        internal Country GetCountry(string name)
        {
            //var country = countries.Where(c => c.Name == name).FirstOrDefault();

            var country = (from c in countries
                           where c.Name == name
                           select c).FirstOrDefault();
            return country;
        }

        internal Country GetCountry(int code)
        {
            //var country = countries.Where(c => c.Code == code).FirstOrDefault();

            var country = (from c in countries
                           where c.Code == code
                           select c).FirstOrDefault();
            return country;
        }

        internal void AddCountry(int code, string name, string capital, float area, long population, string language)
        {
            var country = new Country(code, name, capital, area, population, language);
            countries.Add(country);
        }

        internal void UpdateCountry(int code, string name, string capital, float area, long population, string language)
        {
            var country = GetCountry(name);
            if (country != null)
            {
                country.Code = code;
                country.Capital = capital;
                country.Area = area;
                country.Population = population;
                country.Language = language;
            }
        }

        internal void RemoveCountries(string language)
        {
            countries.RemoveAll(c => c.Language == language);
        }
    }
}
