using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityNS
{
    public class City
    {
        public string _name;
        public double _square;
        public long _population;
        private List<CityArea> _list { get; set; }

        //static int count = 0;

        public City()
        {
            _name = "ничего";
            _square = 0;
            _population = 0;
        }

        public City(string name, double sq, long pop, List<CityArea> alist)
        {
            this._name = name;
            this._square = sq;
            this._population = pop;
            this._list = alist;
        }

        public string getName()
        {
            return _name;
        }
        public double getSquare()
        {
            return _square;
        }
        public long getPopulation()
        {
            return _population;
        }

        public class CityArea
        {
            public String areaName { get; set; }
            public String areaType { get; set; }
            public String areaIndex { get; set; }
            private List<SubArea> areaList { get; set; }

            public CityArea()
            {
                areaName = "город";
                areaType = "пуст";
                areaIndex = "error 404";
            }

            public CityArea(string name, string type, string index, List<SubArea> sblist)
            {
                this.areaName = name;
                this.areaType = type;
                this.areaIndex = index;
                this.areaList = sblist;
            }         

            public override string ToString()
            {
                StringBuilder s = new StringBuilder(100);
                s.Append(areaName + " " + areaType + ", Почтовый индекс: " + areaIndex);
                return s.ToString();
            }
        }

        public class SubArea
        {
            public String subAreaName { get; set; }
            public String subAreaType { get; set; }
            private List<int> subAreaHome { get; set; }

            public SubArea()
            {
                subAreaName = "район";
                subAreaType = "пуст";
            }

            public SubArea(string name, string type, List<int> ilist)
            {
                this.subAreaName = name;
                this.subAreaType = type;
                this.subAreaHome = ilist;
            }

            public override string ToString()
            {
                StringBuilder s = new StringBuilder(100);
                s.Append(subAreaName + " " + subAreaType);
                return s.ToString();
            }
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder(100);
            s.Append("Наименование города: '" + _name + "'\n");
            s.Append("   Площадь: '" + _square + "'  Население:  '" + _population + "'\n");
            return s.ToString();
        }
    }
}


