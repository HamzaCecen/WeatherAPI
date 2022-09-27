using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Weather
{
    class Program
    {
        static void Main(string [] args)
        {
            string api = "da2f5c3711ebaece9ca89418e8969159";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument weather = XDocument.Load(connection);
            var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var weatherstate = weather.Descendants("weather").ElementAt(0).Attribute("value");
            Console.Write("İstanbul için sıcaklık: " + temp + "-- hava durum: " + weatherstate);
            Console.ReadLine();
        }
    }
}