using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasmorraDoMestre.Model
{
    public class ListValues
    {
        public string name { get; set; }
        public string description { get; set; }
        public string abbreviation { get; set; }
    }

    public class PropertiesList
    {
        private List<ListValues> values = new List<ListValues>();
        public ListValues ListValues { set => values.Add(value); }
        public List<ListValues> List { get { return values; } }
    }
}
