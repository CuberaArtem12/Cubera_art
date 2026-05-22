using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPp
{
    internal abstract class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TreatmentNumber { get; set; }
        public string NumberPhone { get; set; }
        private const int maximumDisciplin = 7;
        public Disciplines[] DisciplinElist = new Disciplines[maximumDisciplin];
        public Student() {
            FirstName = "Unspecified";
            LastName = "Unspecified";
            TreatmentNumber= "00000000";
            NumberPhone = "+00000000000";
        }
        public Student(string FirstName,string LastName,string TreatmentNumber,string NumberPhone, Disciplines[] DisciplinElist) { 
        this.FirstName = FirstName;
            this.LastName = LastName;
            this.TreatmentNumber = TreatmentNumber;
            this.NumberPhone = NumberPhone;
            this.DisciplinElist = DisciplinElist;
        }
        public Disciplines HightRanting() {
        Array.Sort(this.DisciplinElist);
            return DisciplinElist[0];
        }
        public Disciplines LowerRanting()
        {
            Array.Sort(this.DisciplinElist);
            return DisciplinElist[maximumDisciplin - 1];
        }
        public int AverageScore()
        {
            int total = 0;
            for (int i = 0; i < DisciplinElist.Length; i++)
            {
                if (DisciplinElist[i] != null)
                    foreach (var Disciplin in DisciplinElist)
                    {
                        if (Disciplin != null)
                            total += Disciplin.Rating;
                    }
            }
            return total/ maximumDisciplin;
        }
    }

    
}
