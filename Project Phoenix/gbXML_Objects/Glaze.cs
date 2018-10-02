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
    public class Glaze
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public string DOELibIdRef { get; set; }
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public string Description { get; set; }
        [XmlElement]
        public Transmittance[] Transmittance { get; set; }
        [XmlElement]
        public Reflectance[] Reflectance { get; set; }
        [XmlElement]
        public Emittance[] Emittance { get; set; }
        [XmlElement]
        public Thickness Thickness { get; set; }
        [XmlElement]
        public Conductivity Conductivity { get; set; }
        [XmlElement]
        public Reference Reference { get; set; }

    }
}
