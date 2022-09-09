using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    internal class program
    {
        public double CelsiusToFehrenheit(String celsiusTemp)
        {
            double celsious = double.Parse(celsiusTemp);
            double Fehrenheit = (celsious * 9 / 5) + 32;
            return Fehrenheit;
        }
        public double FehrenheitToFehrenheit(String FehrenheitTemp)
        {
            double Fehrenheit = double.Parse(FehrenheitTemp);
            double celsius = (Fehrenheit - 32) * 5 / 9;
            return celsius;
        }


    }
}

