using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2_3kurs2.Model
{
    public record Company
        (
        string name,
        DateOnly companyFoundingDate,
        List<Employer> Employees
        );
    
    
}
