using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_2
{
    class CelsiusTemperature
    {
        public double value;
        public CelsiusTemperature(double celsiusTemperature)
        {
            value = celsiusTemperature;
        }

        public static implicit operator FahrenheitTemperature(CelsiusTemperature temp)
        {
            var fahrenheitTemp = temp.value * 9 / 5 + 32;
            return new FahrenheitTemperature(fahrenheitTemp);
        }
    }
}
