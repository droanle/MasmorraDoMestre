using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasmorraDoMestre.Model
{
    public class AttributesListValues
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string color { get; set; }
    }

    public class SecAttributesList
    {
        private List<AttributesListValues> values = new List<AttributesListValues>();
        public AttributesListValues ListValues { set => values.Add(value); }
        public List<AttributesListValues> List { get { return values; } }
    }

}
