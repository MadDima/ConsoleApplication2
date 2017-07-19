using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        struct City
        {
            public string Name;
            public int Population;
            public int Density;
        }
        static void Main(string[] args)
        {
            GetCitiesInfo(Console.ReadLine());
        }
        public static void GetCitiesInfo(string cityStr)
        {
            string str = "";
            string name;
            int population;
            int density;
            City[] cities = new City[10];
            int cityIndex = 0;

            for (int i = 0; i < cityStr.Length; i++)
            {
                while (cityStr[i] != '=')
                {
                    str = str + cityStr[i];
                    i++;
                }
                name = str;
                i++;
                str = "";
                while (cityStr[i] != ',')
                {
                    str = str + cityStr[i];
                    i++;
                }
                population = int.Parse(str);
                i++;
                str = "";
                while (cityStr[i] != ';')
                {
                    str = str + cityStr[i];
                    i++;
                }
                density = int.Parse(str);
                str = "";

                cities[cityIndex] = new City { Name = name, Population = population, Density = density };
                cityIndex++;
            }
            for (int i = 0; i < cityIndex; i++)
            {
                Console.WriteLine(cities[i].Name + "---" + cities[i].Population + "---" + cities[i].Density);
                //should contain ";" in the end of the string, and should not contain scaces, but it's only a parsing... ='(
            }
        }
    }
}
