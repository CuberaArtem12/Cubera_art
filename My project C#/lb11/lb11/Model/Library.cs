using lb11.Myinterface;
using lb11.Service.ServicePrintFolger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.Model
{
    public class Library
    {
       public string Name { get; set; }
       public ICatalogItem[] CatalogItems { get; set; }
        public Library() {
            Name = "unspecified";
        }
        public Library(string Name, ICatalogItem[] CatalogItems) { 
        this.Name= Name;
            this.CatalogItems = CatalogItems;
        
        }
        public override string ToString()
        {
            return "Name: " + Name +"\n===Catalog===\n" + ServicePrintMass.PrintHorizontalMass(CatalogItems);
        }
       

    }
}
