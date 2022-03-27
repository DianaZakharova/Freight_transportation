using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_tranportation
{
    class ChelANDgood
    {
        public Pilots Pilots { get; set; }
        public Drivers Drivers { get; set; }
        public Goods Goods { get; set; }
    }

    public class Pilots
    {
        public Pilot[] PilotsArray { get; set; }
    }
    public class Pilot
    {
        public int id { get; set; }

        public ulong IdEducation { get; set; }

        public string NamePilot { get; set; }

        public string SurnamePilot { get; set; }

        public int StagePilot { get; set; }

    }
    public class Drivers
    {
        public Driver[] DriversArray { get; set; }
    }
    public class Driver
    {
        public int id { get; set; }

        public string NameDriver { get; set; }

        public string SurnameDriver { get; set; }

        public int StageDriver { get; set; }
    }

    public class Goods
    {
        public Good[] GoodsArray { get; set; }
    }
    public class Good
    {
        public int id { get; set; }

        public string NameGood { get; set; }

        public float Weight { get; set; }
    }
}
