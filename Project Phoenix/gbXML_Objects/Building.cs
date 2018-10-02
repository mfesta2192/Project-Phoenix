using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Mechanical;
using Autodesk.Revit.UI;
using System;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project_Phoenix
{
    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = true)]
    public class Building
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public buildingTypeEnum buildingType { get; set; }
        public double Area { get; set; }
        [XmlElement("BuildingStorey")]
        public BuildingStorey[] bldgStories { get; set; }
        [XmlElement("Space")]
        public Space[] Spaces { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = true)]
    public class BuildingStorey
    {
        [XmlAttribute]
        public string id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        [XmlElement("PlanarGeometry")]
        public PlanarGeometry PlanarGeo { get; set; }
    }
}
