using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Phoenix
{
    [Serializable]
    [XmlRootAttribute(ElementName = "gbXML", IsNullable = false, Namespace = "http://www.gbxml.org/schema")]
    public class MaterialId
    {
        [XmlAttribute]
        public string materialIdRef { get; set; }
        [XmlAttribute]
        public double percentOfLayer { get; set; }
    }
}
