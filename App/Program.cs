using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityNS;

namespace App
{
    class Program
    {

        public static List<List<T>> Chunk<T>(List<T> theList, int chunkSize)
        {
            List<List<T>> result = theList
                .Select((x, i) => new {
                    data = x,
                    indexgroup = i / chunkSize
                })
                .GroupBy(x => x.indexgroup, x => x.data)
                .Select(g => new List<T>(g))
                .ToList();

            return result;
        }

        static void Main(string[] args)
        {
            string[] areaNameM = new string[9];
            string[] areaNameF = new string[9];
            string[] areaIndex = new string[9];
            string[] areaType = new string[4];

            List<List<City.SubArea>> subArea = new List<List<City.SubArea>>();
            List<City.SubArea> adrSubArea = new List<City.SubArea>();
            List<City.CityArea> Area = new List<City.CityArea>();
            List<int> numb = new List<int>();
            List<int> one = new List<int>();
            one.Add(1);

            areaType[0] = "Район";
            areaType[1] = "Улица";
            areaType[2] = "Проспект";
            areaType[3] = "Площадь";

            areaNameM[0] = "Центральный";  areaNameF[0] = "Центральная";  areaIndex[0] = "00001";
            areaNameM[1] = "Советский";    areaNameF[1] = "Советская";    areaIndex[1] = "00002";
            areaNameM[2] = "Первомайский"; areaNameF[2] = "Первомайская"; areaIndex[2] = "00003";
            areaNameM[3] = "Партизанский"; areaNameF[3] = "Партизанская"; areaIndex[3] = "00004";
            areaNameM[4] = "Заводской";    areaNameF[4] = "Заводская";    areaIndex[4] = "00005";
            areaNameM[5] = "Ленинский";    areaNameF[5] = "Ленинская";    areaIndex[5] = "00006";
            areaNameM[6] = "Октябрьский";  areaNameF[6] = "Октябрьская";  areaIndex[6] = "00007";
            areaNameM[7] = "Московский";   areaNameF[7] = "Московская";   areaIndex[7] = "00008";
            areaNameM[8] = "Фрунзенский";  areaNameF[8] = "Фрунзенская";  areaIndex[8] = "00009";

            for (int i = 0; i < 5; i++)
            {
                numb.Add(i);
            }

            for (int i = 0; i < 9; i++)
            {
                City.SubArea ad = new City.SubArea(areaNameF[i], areaType[1], numb);
                adrSubArea.Add(ad);
                ad = new City.SubArea(areaNameM[i], areaType[2], numb);
                adrSubArea.Add(ad);
                ad = new City.SubArea(areaNameF[i], areaType[3], one);
                adrSubArea.Add(ad);
            }

            subArea = Chunk(adrSubArea,3);

            for (int i = 0; i < 9; i++)
            {           
                City.CityArea add = new City.CityArea(areaNameM[i], areaType[0], areaIndex[i], subArea[i]);
                Area.Add(add);
            }

            City city = new City("Минск", 100000, 1000000, Area);

            Console.Write(city.ToString());
            foreach (City.CityArea area in Area)
            {
                Console.WriteLine(area.ToString());

            }

            foreach (City.SubArea sub in adrSubArea)
            {
                    Console.WriteLine(sub.ToString());
            }
        }
    }
}
