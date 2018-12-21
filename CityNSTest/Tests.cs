using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CityNS;

namespace CityNSTest
{


    [TestClass]
    public class CityTest
    {
        static List<City.CityArea> Area1 = new List<City.CityArea>();
        static List<City.CityArea> Area2 = new List<City.CityArea>();
        List<List<City.SubArea>> subArea1 = new List<List<City.SubArea>>();
        List<List<City.SubArea>> subArea2 = new List<List<City.SubArea>>();
        List<City.SubArea> adrSubArea1 = new List<City.SubArea>();
        List<City.SubArea> adrSubArea2 = new List<City.SubArea>();
        List<int> numb = new List<int>();
        List<int> one = new List<int>();
        City city1 = new City();
        City city2 = new City();

        [TestMethod]
        public void City_NotNull_TrueReturned()
        {
            City city = new City();

            Assert.IsNotNull(city);
        }

        [TestMethod]
        public void City_CityArea_NotNull_TrueReturned()
        {
            City.CityArea cityArea = new City.CityArea();

            Assert.IsNotNull(cityArea);
        }

        [TestMethod]
        public void City_SubArea_NotNull_TrueReturned()
        {
            City.SubArea citySubArea = new City.SubArea();

            Assert.IsNotNull(citySubArea);
        }

        [TestMethod]
        public void SubArea_AreNotEqual_TrueReturned()
        {
            for (int i = 0; i < 5; i++)
            {
                numb.Add(i);
            }
            one.Add(1);

            City.SubArea ad = new City.SubArea("Центральная", "Улица", numb);
            adrSubArea1.Add(ad);
            ad = new City.SubArea("Центральный", "Проспект", numb);
            adrSubArea1.Add(ad);
            ad = new City.SubArea("Центральная", "Площадь", one);
            adrSubArea1.Add(ad);

            ad = new City.SubArea("Московская", "Улица", numb);
            adrSubArea2.Add(ad);
            ad = new City.SubArea("Московский", "Проспект", numb);
            adrSubArea2.Add(ad);
            ad = new City.SubArea("Московская", "Площадь", one);
            adrSubArea2.Add(ad);

            Assert.AreNotEqual(adrSubArea1, adrSubArea2);
        }

        [TestMethod]
        public void SubArea_AreEqual_TrueReturned()
        {
            for (int i = 0; i < 5; i++)
            {
                numb.Add(i);
            }
            one.Add(1);

            City.SubArea ad = new City.SubArea("Центральная", "Улица", numb);
            adrSubArea1.Add(ad);
            ad = new City.SubArea("Центральный", "Проспект", numb);
            adrSubArea1.Add(ad);
            ad = new City.SubArea("Центральная", "Площадь", one);
            adrSubArea1.Add(ad);

            List<City.SubArea> adrSubAreaA = new List<City.SubArea>();
            List<City.SubArea> adrSubAreaB = new List<City.SubArea>();

            adrSubAreaA = adrSubArea1;
            adrSubAreaB = adrSubArea1;

            Assert.AreEqual(adrSubAreaA, adrSubAreaB);
        }

        [TestMethod]
        public void CityArea_AreNotEqual_TrueReturned()
        {
            for (int i = 0; i < 5; i++)
            {
                numb.Add(i);
            }
            one.Add(1);

            City.SubArea ad = new City.SubArea("Центральная", "Улица", numb);
            adrSubArea1.Add(ad);
            ad = new City.SubArea("Центральный", "Проспект", numb);
            adrSubArea1.Add(ad);
            ad = new City.SubArea("Центральная", "Площадь", one);
            adrSubArea1.Add(ad);

            ad = new City.SubArea("Московская", "Улица", numb);
            adrSubArea2.Add(ad);
            ad = new City.SubArea("Московский", "Проспект", numb);
            adrSubArea2.Add(ad);
            ad = new City.SubArea("Московская", "Площадь", one);
            adrSubArea2.Add(ad);

            City.CityArea add = new City.CityArea("Центральный", "Район", "00001", adrSubArea1);
            Area1.Add(add);
            add = new City.CityArea("Московский", "Район", "00002", adrSubArea2);
            Area2.Add(add);

            Assert.AreNotEqual(Area1, Area2);
        }

        [TestMethod]
        public void CityArea_AreEqual_TrueReturned()
        {
            for (int i = 0; i < 5; i++)
            {
                numb.Add(i);
            }
            one.Add(1);

            City.SubArea ad = new City.SubArea("Центральная", "Улица", numb);
            adrSubArea1.Add(ad);
            ad = new City.SubArea("Центральный", "Проспект", numb);
            adrSubArea1.Add(ad);
            ad = new City.SubArea("Центральная", "Площадь", one);
            adrSubArea1.Add(ad);

            City.CityArea add = new City.CityArea("Центральный", "Район", "00001", adrSubArea1);
            Area1.Add(add);

            List<City.CityArea> AreaA = new List<City.CityArea>();
            List<City.CityArea> AreaB = new List<City.CityArea>();

            AreaA = Area1;
            AreaB = Area1;

            Assert.AreEqual(AreaA, AreaB);
        }

        [TestMethod]
        public void City_AreNotEqual_TrueReturned()
        {
            for (int i = 0; i < 5; i++)
            {
                numb.Add(i);
            }
            one.Add(1);

            City.SubArea ad = new City.SubArea("Центральная", "Улица", numb);
            adrSubArea1.Add(ad);
            ad = new City.SubArea("Центральный", "Проспект", numb);
            adrSubArea1.Add(ad);
            ad = new City.SubArea("Центральная", "Площадь", one);
            adrSubArea1.Add(ad);

            ad = new City.SubArea("Московская", "Улица", numb);
            adrSubArea2.Add(ad);
            ad = new City.SubArea("Московский", "Проспект", numb);
            adrSubArea2.Add(ad);
            ad = new City.SubArea("МОсковская", "Площадь", one);
            adrSubArea2.Add(ad);
            City.CityArea add = new City.CityArea("Центральный", "Район", "00001", adrSubArea1);
            Area1.Add(add);
            add = new City.CityArea("Московский", "Район", "00002", adrSubArea2);
            Area2.Add(add);

            city1 = new City("Минск", 100000, 1000000, Area1);
            city2 = new City("Москва", 200000, 2000000, Area2);

            Assert.AreNotEqual(city1, city2);
        }

        [TestMethod]
        public void City_AreEqual_TrueReturned()
        {
            for (int i = 0; i < 5; i++)
            {
                numb.Add(i);
            }
            one.Add(1);

            City.SubArea ad = new City.SubArea("Центральная", "Улица", numb);
            adrSubArea1.Add(ad);
            ad = new City.SubArea("Центральный", "Проспект", numb);
            adrSubArea1.Add(ad);
            ad = new City.SubArea("Центральная", "Площадь", one);
            adrSubArea1.Add(ad);

            City.CityArea add = new City.CityArea("Центральный", "Район", "00001", adrSubArea1);
            Area1.Add(add);
            city1 = new City("Минск", 100000, 1000000, Area1);


            City СityA = new City();
            City СityB = new City();

            СityA = city1;
            СityB = city1;

            Assert.AreEqual(СityA, СityB);
        }
    }
}
