using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2_3kurs2.Model
{
    public class Employer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public double workExperience { get; set; }
        public bool haveHigherEducation { get; set; }
        public string professionalFocus { get; set; }

        public Employer(string firstName, string lastName, DateTime birthDate, decimal salary, double workExperience, bool haveHigherEducation, string professionalFocus)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Salary = salary;
            this.workExperience = workExperience;
            this.haveHigherEducation = haveHigherEducation;
            this.professionalFocus = professionalFocus;
        }

        public virtual decimal CalculateSalary()
        {
            decimal bonusRate = (decimal)this.workExperience * 0.02m;
            return this.Salary + (this.Salary * bonusRate);
        }
        public override string ToString()
        {
            return $"{GetType().Name} FirstName = {FirstName}, LastName = {LastName}, BirthDate = {BirthDate}, Salary = {Salary}, workExperience = {workExperience}, haveHigherEducation = {haveHigherEducation}, professionalFocus = {professionalFocus}";
        }
    }
}
