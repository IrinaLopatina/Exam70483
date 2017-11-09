using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_2
{
    class FahrenheitTemperature
    {
        public double value;
        public FahrenheitTemperature(double fahrenheitTemperature)
        {
            value = fahrenheitTemperature;
        }

        public static implicit operator CelsiusTemperature (FahrenheitTemperature temp)
        {
            var celsiusTemp = (temp.value -32) * 5 / 9;
            return new CelsiusTemperature(celsiusTemp);
        }
    }
}
