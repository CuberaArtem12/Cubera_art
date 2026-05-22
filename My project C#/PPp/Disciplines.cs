using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPp
{
    internal class Disciplines: IComparable<Disciplines>
    {
      public string NameDisciplines { get; set; }
        public int Rating { get; set; }
        public Disciplines() {
            NameDisciplines = "Unspecified";
            Rating = 0;
        }
        public Disciplines(string NameDisciplines, int Ranting) { 
        this.NameDisciplines = NameDisciplines;
            this.Rating = Ranting;
        }
        public override string ToString() {
            return "Disciplin: " + NameDisciplines + "Ranting: " + Rating;
        }
        public int CompareTo(Disciplines other)
        {
            if (other == null) return 1;
            return this.Rating.CompareTo(other.Rating);

        }
    }
}
