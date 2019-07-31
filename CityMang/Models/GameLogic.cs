using System.Collections.Generic;
using CityMang.Models;

namespace CityMang
{


    public class City
    {
        public static Dictionary<string,int> myCity = new Dictionary<string, int>() {{"Cash", 1000},{"Food", 100},{"Metal", 10},{"Wood", 10},{"Farms", 1},{"Mines", 1},{"Housing", 1},{"Commercial", 1},{"Sawmills", 1}};

        public static int resourceProduction(int owned, Building building)
        {
            return owned * building.gain;
        }
        public static void constructBuilding(int number, string building) //farms
        {
            myCity[building] += number;
        }
    }
    public class Population
    {
        public int popTotal { get; set; }

        public Population(int Pop)
        {
            this.popTotal = Pop;
        }
    }


}



