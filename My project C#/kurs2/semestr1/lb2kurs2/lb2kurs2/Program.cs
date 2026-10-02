using lb2kurs2.Enum;
using lb2kurs2.Model;
using lb2kurs2.Service;
using lb2kurs2.Service.CollectionQueryService;

namespace lb2kurs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Firm> firmList = new List<Firm>() {
             new Firm("Food", new DateTime(2018, 1, 15),  BusinessProfile.FoodIndustry, "Black John", 250, "London, Baker Street 10"),
             new Firm("IT Sphere", new DateTime(2020, 6, 10),  BusinessProfile.IT, "White David", 150, "London, Oxford Street 45"),
             new Firm("White Market", new DateTime(2026, 3, 12),  BusinessProfile.Marketing, "Black Robert", 50, "Kyiv, Khreshchatyk 15"),
             new Firm("Global Marketing", new DateTime(2026, 9, 1), BusinessProfile.Marketing, "Smith White Alex", 400, "London, Regent Street 8"),
             new Firm("Tech Food Solutions", new DateTime(2022, 3, 1), BusinessProfile.IT, "White Sarah", 80, "Lviv, Svobody Ave 20"),
             new Firm("London Design Studio", new DateTime(2025, 12, 20), BusinessProfile.Design, "Johnson Michael", 120, "London, Piccadilly 3"),
             new Firm("Retail Master", new DateTime(2021, 2, 5), BusinessProfile.Retail, "Brown James", 20, "Warsaw, Main Street 1")
            };
           
            Console.WriteLine("all information: ");
            CollectionShow.ShowCollection(QueryServiceAllinfo.QueryAllinformation(firmList));
            Console.WriteLine("all firm with name Food: ");
            CollectionShow.ShowCollection(QueryServiceString.QueryFirmNameFood(firmList));
            Console.WriteLine("marketing firms: ");
            CollectionShow.ShowCollection( QueryServiceDateBuisnessProfile.QueryFirmMarketing(firmList));
            Console.WriteLine("marketing or IT firms: ");
            CollectionShow.ShowCollection(QueryServiceDateBuisnessProfile.QueryFirmMarketingOrIT(firmList));
            Console.WriteLine("companies with more than one hundred employees: ");
            CollectionShow.ShowCollection(QueryServiceEmployees.QueryFirmsWithOver100Employees(firmList));
            Console.WriteLine("firms with between one hundred and three hundred employees: ");
            CollectionShow.ShowCollection(QueryServiceEmployees.QueryFirms100To300Employees(firmList));
            Console.WriteLine("firms located in London: ");
            CollectionShow.ShowCollection(QueryServiceString.FirmLocatedInLondon(firmList));
            Console.WriteLine("firms where the director's surname is White: ");
            CollectionShow.ShowCollection(QueryServiceString.FirmsWhereDirectorSurnameWhite(firmList));
            Console.WriteLine("firms founded more than two years ago: ");
            CollectionShow.ShowCollection(QueryServiceDate.FirmsFoundedTwoYearsAgo(firmList));
            Console.WriteLine("firms established more than 150 days ago: ");
            CollectionShow.ShowCollection(QueryServiceDate.QueryFirmsOlderThan150Days(firmList));
            Console.WriteLine("companies where the director's surname is Black and the company name contains the word White: ");
            CollectionShow.ShowCollection(QueryServiceString.QueryFirmsBlackDirWhiteName(firmList));
        }
    }
}
