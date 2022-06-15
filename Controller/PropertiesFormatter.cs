using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasmorraDoMestre.Controller
{
    internal class PropertiesFormatter
    {
        private string id;
        private string name;
        private string propertie_Type;

        public PropertiesFormatter(string propertie_Type)        {            this.propertie_Type = propertie_Type;        }

        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Propertie_Type { get { return propertie_Type; } set { propertie_Type = value; } }

    }
}
