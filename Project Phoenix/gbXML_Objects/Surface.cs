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
    public class Surface
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public surfaceTypeEnum surfaceType { get; set; }
        [XmlAttribute]
        public string constructionIdRef { get; set; }
        public string Name { get; set; }
        [XmlElement(IsNullable = false, ElementName = "AdjacentSpaceId")]
        public AdjacentSpaceId[] AdjacentSpaceId { get; set; }
        public RectangularGeometry RectangularGeometry { get; set; }
        [XmlElement]
        public PlanarGeometry PlanarGeometry { get; set; }
        [XmlElement(ElementName = "Opening", IsNullable = false)]
        public Opening[] Opening { get; set; }
        [XmlIgnore]
        public bool exposedToSunField;
        [XmlElement(IsNullable = false)]
        public CADObjectId CADObjectId { get; set; }
    }
}
