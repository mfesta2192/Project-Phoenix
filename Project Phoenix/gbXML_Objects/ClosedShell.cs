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

[Serializable]
[XmlRootAttribute(ElementName = "gbXML", IsNullable = true)]
public class ClosedShell
{
    [XmlElement(IsNullable = false, ElementName = "PolyLoop")]
    public PolyLoop[] PolyLoops { get; set; }
}