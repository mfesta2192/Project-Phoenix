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
    public class SpaceBoundary
    {
        [XmlAttribute]
        public string surfaceIdRef { get; set; }
        public PlanarGeometry PlanarGeometry { get; set; }
    }
}