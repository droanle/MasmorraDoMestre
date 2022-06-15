using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasmorraDoMestre.Model
{
    public class PropertiesListValues
    {
        public string name { get; set; }
        public string description { get; set; }
        public string abbreviation { get; set; }
    }

    public class PropertiesList
    {
        public List<PropertiesListValues> values = new List<PropertiesListValues>();

        public PropertiesListValues ListValues { set => values.Add(value); }
        public List<PropertiesListValues> List { get { return values; } }
    }
}
