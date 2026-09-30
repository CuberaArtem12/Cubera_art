using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2_3kurs2.Model
{
    public record Employer
        (
        string FirstName,
        string LastName,
        DateTime BirthDate,
        decimal Salary,
        double workExperience,
        bool haveHigherEducation,
        string professionalFocus
        );
}
