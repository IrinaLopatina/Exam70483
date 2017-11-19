using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var countryHelper = new CountryHelper();
            countryHelper.Print();

            var country = countryHelper.GetCountry(2);         
            countryHelper.PrintCountry(country);

            country = countryHelper.GetCountry(54);
            countryHelper.PrintCountry(country);

            country = countryHelper.GetCountry("Ukraina");
            countryHelper.PrintCountry(country);

            country = countryHelper.GetCountry("Norway");
            countryHelper.PrintCountry(country);

            countryHelper.AddCountry(10, "Spain", "Madrid", 77, 66000000, "spanish");
            countryHelper.Print();

            countryHelper.UpdateCountry(20, "Germany", "Bonn", 76, 40000000, "german");
            countryHelper.Print();

            countryHelper.RemoveCountries("english");
            countryHelper.Print();
        }
    }
}
