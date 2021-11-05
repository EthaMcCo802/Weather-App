using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTime, location,  
            windSpeed, windDirection, precipitation, visibility, icon;
        public decimal currentTemp, tempHigh, tempLow;
        public int condition;

        public Day()
        {
            date = currentTime = location = windSpeed = windDirection = precipitation = visibility = icon = "";
            currentTemp = tempHigh = tempLow;
            condition = condition;
        }
    }
}
