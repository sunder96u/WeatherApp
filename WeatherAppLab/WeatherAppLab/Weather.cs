﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherAppLab
{
    public class Weather
    {
        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Humidity { get; set; }
        public string Visibility { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }

        public Weather()
        {
            //Because labels bind to there values, set theem to an empty string to ensure that the label appears on all platforms by default
            Title = "";
            Temperature = "";
            Wind = "";
            Humidity = "";
            Visibility = "";
            Sunrise = "";
            Sunset = "";
        }
    }


}
