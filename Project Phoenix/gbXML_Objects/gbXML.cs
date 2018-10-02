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
    public class gbXML
    {
        [XmlAttribute]
        public temperatureUnitEnum temperatureUnit { get; set; }
        [XmlAttribute]
        public lengthUnitEnum lengthUnit { get; set; }
        [XmlAttribute]
        public areaUnitEnum areaUnit { get; set; }
        [XmlAttribute]
        public volumeUnitEnum volumeUnit { get; set; }
        [XmlAttribute]
        public versionEnum version { get; set; }
        [XmlAttribute]
        public string useSIUnitsForResults { get; set; }

        [XmlElement(IsNullable = false)]
        public Campus Campus;
        [XmlElement(IsNullable = false, ElementName = "Construction")]
        public Construction[] Constructions;
        [XmlElement(IsNullable = false, ElementName = "Layer")]
        public Layer[] Layers;
        [XmlElement(IsNullable = false, ElementName = "Material")]
        public Material[] Materials;
        [XmlElement(IsNullable = false, ElementName = "WindowType")]
        public WindowType[] WindowTypes;
        [XmlElement(IsNullable = false, ElementName = "Glaze")]
        public Glaze[] Glazing;
        [XmlElement(IsNullable = false, ElementName = "Gap")]
        public Gap[] Gaps;
        //[XmlElement(IsNullable = false, ElementName = "Layer")]
        //public Layer[] Layers;
        //[XmlElement(IsNullable = false, ElementName = "Material")]
        //public Material[] Materials;

    }
}
