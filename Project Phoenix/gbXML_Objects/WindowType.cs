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
    public class WindowType
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
        public UValue UValue { get; set; }
        [XmlElement]
        public ShadingCoeff ShadingCoeff { get; set; }
        [XmlElement]
        public SolarHeatGainCoeff[] SolarHeatGainCoeff { get; set; }
        [XmlElement]
        public Transmittance Transmittance { get; set; }
        [XmlElement]
        public Reflectance Reflectance { get; set; }
        [XmlElement]
        public Emittance Emittance { get; set; }
        //Gaps and Glazing from outside to Inside
        [XmlElement]
        public Gap[] Gap { get; set; }
        [XmlElement]
        public Glaze[] Glaze { get; set; }


    }

}
