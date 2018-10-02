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
    public class Gap
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public gasTypeEnum gas { get; set; }
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public string Description { get; set; }
        [XmlElement]
        public Thickness Thickness { get; set; }
        [XmlElement]
        public Density Density { get; set; }
        [XmlElement]
        public Conductivity Conductivity { get; set; }

    }
}
