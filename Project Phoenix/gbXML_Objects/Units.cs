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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gbxml.org/schema")]
    public enum lengthUnitEnum
    {
        Kilometers,
        Meters,
        Centimeters,
        Millimeters,
        Miles,
        Yards,
        Feet,
        Inches,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gbxml.org/schema")]
    public enum areaUnitEnum
    {
        SqaureKilometers,
        SquareMeters,
        SquareCentimeters,
        SquareMillimeters,
        SquareMiles,
        SquareYards,
        SquareFeet,
        SquareInches,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gbxml.org/schema")]
    public enum volumeUnitEnum
    {
        CubicKilometers,
        CubicMeters,
        CubicCentimeters,
        CubicMillimeters,
        CubicMiles,
        CubicYards,
        CubicFeet,
        CubicInches,
    }
}
