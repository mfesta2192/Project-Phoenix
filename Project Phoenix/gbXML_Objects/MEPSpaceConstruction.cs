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


namespace Project_Pheonix
{
    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = true)]
    public class : MEPSpaceConstruction
    [XmlAttribute]
    public MEPSpaceConstruction : CurrentConstruction { get; set; }
    [XmlAttribute]
    public MEPSpaceConstruction SpaceConstruction { get; }
}