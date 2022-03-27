using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [System.Xml.Serialization.XmlRoot("ChelANDgood")]
    public class ChelANDgood
    {
        [System.Xml.Serialization.XmlElement("Pilots")]
        public Pilots Pilots { get; set; }

        [System.Xml.Serialization.XmlElement("Drivers")]
        public Drivers Drivers { get; set; }

        [System.Xml.Serialization.XmlElement("Goods")]
        public Goods Goods { get; set; }
    }
  
    public class Pilots
    {
        [System.Xml.Serialization.XmlElement("Pilot")]
        public Pilot[] PilotsArray { get; set; }
    }
    public class Pilot 
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int id { get; set; }

        [System.Xml.Serialization.XmlElement("IdEdu", Namespace ="")]
        public ulong IdEdu { get; set; }

        [System.Xml.Serialization.XmlElement("Name_pilot", Namespace = "")]
        public string Name_pilot { get; set; }

        [System.Xml.Serialization.XmlElement("Surname_pilot", Namespace = "")]
        public string Surname_pilot { get; set; }

        [System.Xml.Serialization.XmlElement("Stage_pilot", Namespace = "")]
        public int Stage_pilot { get; set; }

    }
    public class Drivers
    {
        [System.Xml.Serialization.XmlElement("Driver")]
        public Driver[] DriversArray{ get; set; }
    }
    public class Driver
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int id { get; set; }

        [System.Xml.Serialization.XmlElement("Name_driver", Namespace = "")]
        public string Name_driver { get; set; }

        [System.Xml.Serialization.XmlElement("Surname_driver", Namespace = "")]
        public string Surname_driver { get; set; }

        [System.Xml.Serialization.XmlElement("Stage_driver", Namespace = "")]
        public int Stage_driver { get; set; }
    }
    
    public class Goods
    {
        [System.Xml.Serialization.XmlElement("Good")]
        public Good[] GoodsArray { get; set; }
    }
    public class Good
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int id { get; set; }

        [System.Xml.Serialization.XmlElement("Name_good", Namespace = "")]
        public string Name_good { get; set; }

        [System.Xml.Serialization.XmlElement("Weight", Namespace = "")]
        public float Weight { get; set; }
    }
}
