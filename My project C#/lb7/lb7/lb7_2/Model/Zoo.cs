using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7_2.Model
{
    public class Zoo
    {
        private string name { get; set; }
        private Terrarium[] terrariumList { get; set; }
        public Zoo() {
            name = "NoName";
            terrariumList= null;
        }
        public Zoo(string name, Terrarium[] terrariumList) { 
        this.name = name;
            this.terrariumList= terrariumList;
        }


    }
}
