using MasmorraDoMestre.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasmorraDoMestre.Controller
{
    
    public class SystemFormatter
    {
        private List<PropertiesFormatter> propertiesInfos = new List<PropertiesFormatter>();
        private PropertiesList propertiesList = new PropertiesList();
        private SecAttributesList secAttributesList = new SecAttributesList();
        private string name;
        private string description;

        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }

        public void setF(string Id, string name, string propertie_Type)
        {
            PropertiesFormatter propertiesInfos = new PropertiesFormatter(propertie_Type);
            propertiesInfos.Name = name;
            propertiesInfos.Id = Id;

            this.propertiesInfos.Add(propertiesInfos);
        }

        public void setAttributes(string id, string name, string description , string color)
        {
            AttributesListValues attributesListValues = new AttributesListValues();
            attributesListValues.id = id;
            attributesListValues.name = name;
            attributesListValues.description = description;  
            attributesListValues.color = color;

            secAttributesList.ListValues = attributesListValues;
        }

        public void setPropertie(string id, string name, string description)
        {
            PropertiesListValues propertiesListValues = new PropertiesListValues();
            propertiesListValues.name = name;
            propertiesListValues.description = description;
            propertiesListValues.abbreviation = id;
            
            propertiesList.ListValues = propertiesListValues;

            propertiesInfos.Add(new PropertiesFormatter(id));
        }

    }
}
