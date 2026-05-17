using lb9.MyStruct;

namespace lb9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Birthday db=new Birthday();
            int year = 2008;
            int day = 4;
            int month = 7;

            db.birthDay=new DateOnly(2008, 7, 4);
            Console.WriteLine($"Day of week: {db.GetBirthDayOfWeek()}");
            db.AfterYear = 2030;
            Console.WriteLine($"Nex Birthday: {db.GetDayOfWeekInYear()}");
            Console.WriteLine($"days Until Birthday: {db.daysUntilBirthday()}");
        }
    }
}
