using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using System.ComponentModel;
using System.Runtime.Remoting.Metadata.W3cXsd2001;


namespace Project_Phoenix
{
   
    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class AdjacentSpaceId
    {
        [XmlAttribute]
        public string spaceIdRef { get; set; }
        public surfaceTypeEnum surfaceTypeField { get; set; }
        [XmlIgnore]
        public bool surfaceTypeFieldSpecified { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class Area
    {
        [XmlText]
        public string val { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class Building
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public buildingTypeEnum buildingType { get; set; }
        public double Area { get; set; }
        [XmlElement("BuildingStorey")]
        public BuildingStorey[] bldgStories { get; set; }
        [XmlElement("Space")]
        public Space[] Spaces { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class BuildingStorey
    {
        [XmlAttribute]
        public string id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        [XmlElement("PlanarGeometry")]
        public PlanarGeometry PlanarGeo { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class CADMaterialId
    {
        [XmlAttribute]
        public string CADMaterialIdRef { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class CADObjectId
    {
        [XmlText]
        public string id { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class Campus
    {
        [XmlAttribute]
        public string id;
        public Location Location;
        [XmlElement(ElementName = "Building", IsNullable = false)]
        public Building[] Buildings { get; set; }
        [XmlElement(ElementName = "Surface", IsNullable = false)]
        public Surface[] Surface { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class CartesianPoint
    {
        [XmlElement(ElementName = "Coordinate", IsNullable = false)]
        public string[] Coordinate;
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class ClosedShell
    {
        [XmlElement(IsNullable = false, ElementName = "PolyLoop")]
        public PolyLoop[] PolyLoops { get; set; }
    }
        
    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class Construction
    {

        public Construction()
        {
            //an empty constructor
        }

        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public string DOELibIdRef { get; set; }

        [XmlElement(IsNullable = false)]
        public Absorptance[] Absorptance { get; set; }
        [XmlElement(IsNullable = false)]
        public Albedo Albedo { get; set; }
        [XmlArray(IsNullable = false)]
        public Cost[] Cost { get; set; }
        [XmlElement(IsNullable = false)]
        public string Description;
        [XmlElement(IsNullable = false)]
        public Emittance[] Emittance { get; set; }
        [XmlElement(IsNullable = false)]
        public ExtEquipId ExtEquipId { get; set; }
        [XmlElement(IsNullable = false)]
        public FireFace[] FireFace { get; set; }


        [XmlElement(IsNullable = false)]
        public LayerId[] LayerId { get; set; }
        //need loadcalc parameters class defined and added
        [XmlElement(IsNullable = false)]
        public string Name;
        [XmlElement(IsNullable = false)]
        public PercentExisting PercentExisting { get; set; }
        [XmlElement(IsNullable = false)]
        public Reflectance[] Reflectance { get; set; }
        [XmlElement(IsNullable = false)]
        public Roughness Roughness { get; set; }
        [XmlElement(IsNullable = false)]
        public Transmittance[] Transmittance { get; set; }
        [XmlElement(IsNullable = false, ElementName = "U-Value")]
        public UValue Uvalue { get; set; }


    }
      
    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
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

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
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
        [XmlElement(IsNullable = false, ElementName = "Schedule")]
        public Schedule[] Schedule;
        [XmlElement(IsNullable = false, ElementName = "WeekSchedule")]
        public WeekSchedule[] WeekSchedule;
        [XmlElement(IsNullable = false, ElementName = "DaySchedule")]
        public DaySchedule[] DaySchedule;
        //[XmlElement(IsNullable = false, ElementName = "Layer")]
        //public Layer[] Layers;
        //[XmlElement(IsNullable = false, ElementName = "Material")]
        //public Material[] Materials;

    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
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

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class HighLimit
    {
        [XmlAttribute]
        public unitlessSmallUnitEnum unit { get; set; }
        [XmlText]
        public double value { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
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

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class LayerId
    {
        [XmlAttribute]
        public string layerIdRef { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class Length
    {

        public lengthUnitEnum unitField { get; set; }

        public bool unitFieldSpecified { get; set; }

        public decimal valueField { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public lengthUnitEnum unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

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

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
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

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class MaterialId
    {
        [XmlAttribute]
        public string materialIdRef { get; set; }
        [XmlAttribute]
        public double percentOfLayer { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class Opening
    {
        [XmlAttribute]
        public string id { get; set; }

        [XmlAttribute]
        public string constructionIdRef { get; set; }

        [XmlAttribute]
        public string ifcGUID { get; set; }

        [XmlAttribute]
        public string windowTypeIdRef { get; set; }

        [XmlElement(IsNullable = false)]
        public string Description { get; set; }

        [XmlElement(IsNullable = true)]
        public string Name { get; set; }

        [XmlAttribute]
        public openingTypeEnum openingType { get; set; }

        [XmlElement(IsNullable = false, ElementName = "RectangularGeometry")]
        public RectangularGeometry rg { get; set; }

        [XmlElement(ElementName = "PlanarGeometry")]
        public PlanarGeometry pg { get; set; }

    }

    public enum openingTypeEnum
    {
        FixedWindow,
        OperableWindow,
        FixedSkylight,
        OperableSkylight,
        SlidingDoor,
        NonSlidingDoor,
        Air
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class PlanarGeometry
    {
        public PolyLoop PolyLoop { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class Porosity
    {
        [XmlAttribute]
        public unitlessUnitEnum unit { get; set; }
        [XmlText]
        public double value { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class ProgramInfo
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlElement("CompanyName")]
        public string CompanyName { get; set; }
        [XmlElement("ProductName")]
        public string ProductName { get; set; }
        [XmlElement("Version")]
        public string Version { get; set; }
        [XmlElement]
        public string Platform { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class PolyLoop
    {
        [XmlElement(IsNullable = false, ElementName = "CartesianPoint")]
        public CartesianPoint[] Points { get; set; }
    }

    
    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class RValue
    {
        [XmlAttribute]
        public resistanceUnitEnum unit { get; set; }
        [XmlText]
        public double value { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class RectangularGeometry
    {
        public string Azimuth { get; set; }
        public CartesianPoint CartesianPoint { get; set; }
        public string Tilt { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class Reference
    {
        [XmlText]
        public string value { get; set; }
    }
    
    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class Roughness
    {
        [XmlAttribute]
        public roughnessValueEnum value { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public enum roughnessValueEnum
    {
        VeryRough,
        MediumRough,
        Rough,
        Smooth,
        MediumSmooth,
        VerySmooth,
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class ShellGeometry
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public lengthUnitEnum unit { get; set; }
        public ClosedShell ClosedShell;
    }

    
    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class Space
    {
        [XmlAttribute]
        public string id;
        [XmlAttribute]
        public string zoneIdRef;
        [XmlAttribute]
        public string buildingStoreyIdRef;

        public string Name { get; set; }
        public PeopleNumber PeopleNumber { get; set; }
        [XmlElement("PeopleHeatGain")]
        public PeopleHeatGain[] PeopleHeatGains { get; set; }
        [XmlIgnore]
        public double peoplenum { get; set; }
        [XmlIgnore]
        public double totalpeoplegain { get; set; }
        [XmlIgnore]
        public double senspeoplegain { get; set; }
        [XmlIgnore]
        public double latpeoplegain { get; set; }

        public LightPowerPerArea LightPowerPerArea { get; set; }
        [XmlIgnore]
        public double lpd { get; set; }
        public EquipPowerPerArea EquipPowerPerArea { get; set; }
        [XmlIgnore]
        public double epd { get; set; }

        [XmlIgnore]
        public double Area { get; set; }
        [XmlElement("Area")]
        public Area spacearea { get; set; }

        [XmlIgnore]
        public double Volume { get; set; }
        [XmlElement("Volume")]
        public Volume spacevol { get; set; }

        [XmlElement("PlanarGeometry")]
        public PlanarGeometry PlanarGeo { get; set; }
        [XmlElement("ShellGeometry")]
        public ShellGeometry ShellGeo { get; set; }
        [XmlElement("CADObjectId")]
        public CADObjectId cadid { get; set; }
        [XmlElement("SpaceBoundary")]
        public SpaceBoundary[] spbound { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class SpaceBoundary
    {
        [XmlAttribute]
        public string surfaceIdRef { get; set; }
        public PlanarGeometry PlanarGeometry { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class Surface
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public surfaceTypeEnum surfaceType { get; set; }
        [XmlAttribute]
        public string constructionIdRef { get; set; }
        public string Name { get; set; }
        [XmlElement(IsNullable = false, ElementName = "AdjacentSpaceId")]
        public AdjacentSpaceId[] AdjacentSpaceId { get; set; }
        public RectangularGeometry RectangularGeometry { get; set; }
        [XmlElement]
        public PlanarGeometry PlanarGeometry { get; set; }
        [XmlElement(ElementName = "Opening", IsNullable = false)]
        public Opening[] Opening { get; set; }
        [XmlIgnore]
        public bool exposedToSunField;
        [XmlElement(IsNullable = false)]
        public CADObjectId CADObjectId { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public enum surfaceTypeEnum
    {
        InteriorWall,
        ExteriorWall,
        Roof,
        InteriorFloor,
        Shade,
        UndergroundWall,
        UndergroundSlab,
        Ceiling,
        Air,
        UndergroundCeiling,
        RaisedFloor,
        SlabOnGrade,
        FreestandingColumn,
        EmbeddedColumn,
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class Thickness
    {
        [XmlAttribute]
        public lengthUnitEnum unit { get; set; }
        [XmlText]
        public double value { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gbxml.org/schema")]
    public enum unitlessUnitEnum
    {
        Percent,
        Fraction,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gbxml.org/schema")]
    public enum unitlessSmallUnitEnum
    {
        Percent,
        PartPerMillionByVolumeaction,
        milliGramsPerCubicMeter,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gbxml.org/schema")]
    public enum versionEnum
    {
        [Description("0.35")]
        OhThreeFive = 0,
        [Description("0.36")]
        OhThreeSix = 1,
        [Description("0.37")]
        OhThreeSeven = 2,
        [Description("5.00")]
        FiveOhOh = 3,
        [Description("5.01")]
        FiveOhOne = 4,
        [Description("5.10")]
        FiveOneOh = 5,
        [Description("5.11")]
        FiveOneOne = 6,
        [Description("5.12")]
        FiveOneTwo = 7,
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
    public class Volume
    {
        [XmlText]
        public string val { get; set; }
    }

    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false)]
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


    public static class gb
    {
        public static CultureInfo gbci;
        //this should not be serializable
        public static string FormatDoubleToString(double number)
        {

            string ret;
            ret = string.Format(gb.gbci, "{0:0.000000}", number);
            return ret;
        }
    }
}