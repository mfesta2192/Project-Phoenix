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
    public class Space
    {
        [XmlAttribute]
        public string id;
        [XmlAttribute]
        public string zoneIdRef;
        [XmlAttribute]
        public string conditionType;
        [XmlAttribute]
        public string buildingStoreyIdRef;
        [XmlIgnore]
        public double Area { get; set; }
        [XmlElement("Area")]
        public Area spacearea { get; set; }
        [XmlIgnore]
        public double Volume { get; set; }
        [XmlElement("Volume")]
        public Volume spacevol { get; set; }
        [XmlElement("PlanarGeometry")]
        public string PlanarGeometry PlanarGeo { get; set; }
        [XmlElement("ShellGeometry")]
        public string ShellGeometry ShellGeo { get; set; }
        [XmlElement("CADObjectId")]
        public string CADObjectId cadid { get; set; }
        [XmlElement("SpaceBoundary")]
        public SpaceBoundary[] spbound { get; set; }
        [XmlElement("uniqueId")]
        public string UniqueId { get; }
    }
}
