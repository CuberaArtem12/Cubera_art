using lb2kurs2.Enum;
using lb2kurs2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2kurs2.Service.CollectionQueryService
{
    internal class QueryServiceDateBuisnessProfile
    {
        public static List<Firm> QueryFirmMarketing(List<Firm> mylist)
        {
            var firmMarketing = mylist
                    .Where(s => s.businessProfile == BusinessProfile.Marketing)
                    .Select(s => s).ToList();
            return firmMarketing;

        }
        public static List<Firm> QueryFirmMarketingOrIT(List<Firm> mylist)
        {
            var firmMarketingOrIT = mylist
                .Where(s => s.businessProfile == BusinessProfile.Marketing || s.businessProfile == BusinessProfile.IT)
                .Select(s => s).ToList();
            return firmMarketingOrIT;
        }

    }
}
