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
    public class Layer
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public string DOELibIdRef { get; set; }

        [XmlElement(IsNullable = false)]
        public string Name { get; set; }
        [XmlElement(IsNullable = false)]
        public string Description { get; set; }
        [XmlElement(IsNullable = false)]
        public Cost[] Cost { get; set; }
        [XmlElement(IsNullable = false)]
        public InsideAirFilmResistance InsideAirFilmResistance { get; set; }
        [XmlElement(IsNullable = true)]
        public MaterialId[] MaterialId { get; set; }
    }

}
