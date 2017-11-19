using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_6
{
    class Country
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public float Area { get; set; }
        public long Population { get; set; }
        public string Language { get; set; }

        public Country(int code, string name, string capital, float area, long population, string language)
        {
            Code = code;
            Name = name;
            Capital = capital;
            Area = area;
            Population = population;
            Language = language;
        }
    }
}
