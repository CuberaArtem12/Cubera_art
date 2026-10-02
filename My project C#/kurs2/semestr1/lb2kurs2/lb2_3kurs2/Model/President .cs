using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2_3kurs2.Model
{
    public class President : Employer
    {
        public President(string firstName, string lastName, DateTime birthDate, decimal salary, double workExperience, bool hasHigherEducation, string professionalFocus)
            : base(firstName, lastName, birthDate, salary, workExperience, hasHigherEducation, professionalFocus)
        {
        }

        public override decimal CalculateSalary()
        {
            decimal bonusRate = (decimal)this.workExperience * 0.1m;
            return this.Salary + (this.Salary * bonusRate);
        }
    }

}
