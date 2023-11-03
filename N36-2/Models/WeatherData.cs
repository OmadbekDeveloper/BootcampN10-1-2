using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Models
{
    public class WeatherData
    {
        public static (double Temperature, double Humidity, double WindSpeed) CreateWeatherDate(double temperature, double humidity, double winSpeed)
        {
            return (temperature, humidity, winSpeed);
        }
    }
}
