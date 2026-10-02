using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lb2_3kurs2.Model
{
    public class Company
    {
        public string name { get; set; }
        public DateOnly companyFoundingDate { get; set; }
        public List<Employer> Employees { get; set; }

        public Company(string name, DateOnly companyFoundingDate, List<Employer> employees)
        {
            this.name = name;
            this.companyFoundingDate = companyFoundingDate;
            this.Employees = employees;
        }
        public void updateSalaryEmploee() {
            foreach (var e in Employees) 
            {
                e.Salary = e.CalculateSalary();
            }
            
        }
        public string ShowCompanyEmployers() {
        StringBuilder p = new StringBuilder();
            foreach (var e in Employees) {
                p.Append(e).Append("\n");
            }
            return p.ToString();
        }
        public override string ToString()
        {
            return $"Name cmpany: {name}, company founding date: {companyFoundingDate}  Employees:\n{ShowCompanyEmployers()} ";
        }
    }


}
