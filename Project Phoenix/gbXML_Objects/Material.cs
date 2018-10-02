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
    public class Material
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
        public Thickness Thickness { get; set; }
        [XmlElement(IsNullable = false)]
        public Conductivity Conductivity { get; set; }
        [XmlElement(IsNullable = false)]
        public Density Density { get; set; }
        [XmlElement(IsNullable = false)]
        public SpecificHeat SpecificHeat { get; set; }
        [XmlElement(IsNullable = false)]
        public Permeance Permeance { get; set; }
        [XmlElement(IsNullable = false)]
        public Porosity Porosity { get; set; }
        [XmlElement(IsNullable = false, ElementName = "R-value")]
        public RValue RValue { get; set; }
        [XmlElement(IsNullable = false)]
        public RecycledContent RecycledContent { get; set; }
        [XmlElement(IsNullable = false)]
        public Fire Fire { get; set; }
        [XmlElement(IsNullable = false)]
        public Cost[] Cost { get; set; }
        [XmlElement(IsNullable = false)]
        public IndoorAirQuality IndoorAirQuality { get; set; }
        [XmlElement(IsNullable = false)]
        public CADMaterialId[] CADMaterialId { get; set; }
        [XmlElement(IsNullable = false)]
        public Reference[] Reference { get; set; }

    }
}
