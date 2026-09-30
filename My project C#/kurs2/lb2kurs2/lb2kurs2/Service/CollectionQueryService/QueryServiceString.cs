using lb2kurs2.Enum;
using lb2kurs2.Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lb2kurs2.Service.CollectionQueryService
{
    internal class QueryServiceString
    {
        
        public static List<Firm> QueryFirmNameFood(List<Firm> mylist) {
            var firmNameFood=mylist
                .Where(s=>s.name.Contains("Food"))
                .Select(s=>s).ToList();
           return firmNameFood;
        }
       
        public static List<Firm> FirmLocatedInLondon(List<Firm> mylist) { 
        var firmLocatedInLondon=mylist
                .Where(s=>s.address.Contains("London"))
                .Select(s => s).ToList();
            return firmLocatedInLondon;
        }
        public static List<Firm> FirmsWhereDirectorSurnameWhite(List<Firm> mylist) { 
        var firmsDirectorSurnameWhite=mylist
                .Where(s=>s.address.Contains("White"))
                .Select(s => s).ToList();
            return firmsDirectorSurnameWhite;
        }
       
        public static List<Firm> QueryFirmsBlackDirWhiteName(List<Firm> mylist) { 
        var firmsBlackDirWhiteName=mylist
                 .Where(s => s.DirectorFullName.Contains("Black")&&s.name.Contains("White"))
                .Select(s => s).ToList();
            return firmsBlackDirWhiteName;
        }
    }
}
