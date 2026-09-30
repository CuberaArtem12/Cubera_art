using lb2_3kurs2.Model;

namespace lb2_3kurs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var company = new Company(
                "Tech Corp",
                new DateOnly(2010, 4, 15),
                new List<Employer> {
                new President("Alexander", "Petrenko", new DateTime(1975, 5, 12), 120000m, 20.5, true, "Executive Management"),
                new Manager("Volodymyr", "Sydorenko", new DateTime(1990, 10, 15), 45000m, 8.0, true, "Project Management"),
                new Manager("Zhenya", "Hnatiuk", new DateTime(1985, 3, 22), 50000m, 12.0, true, "HR"),
                new Manager("Michael", "Moroz", new DateTime(1998, 7, 30), 35000m, 3.5, true, "Sales"),
                new Worker("Hlib", "Romenskyi", new DateTime(2001, 10, 5), 55000m, 2.0, true, "Software Engineer"),
                new Worker("Artem", "Cubera", new DateTime(1995, 1, 18), 60000m, 6.0, true, "DevOps Engineer"),
                new Worker("Volodymyr", "Zaitsev", new DateTime(2001, 10, 5), 22000m, 2.0, true, "Electrician"),
                new Worker("Volodymyr", "Kravchenko", new DateTime(1995, 1, 18), 28000m, 6.0, false, "Locksmith"),
                new Worker("Ihor", "Melnyk", new DateTime(1988, 10, 11), 30000m, 15.0, true, "Locksmith"),
                new Worker("Serhii", "Bondarenko", new DateTime(1982, 4, 25), 32000m, 18.0, true, "Electrician"),
                new Worker("Oleh", "Shevchenko", new DateTime(1993, 10, 20), 27000m, 7.5, false, "Turner"),
                new Worker("Andrew", "Tkachenko", new DateTime(1980, 9, 14), 34000m, 21.0, true, "Turner"),
                new Worker("Dmytro", "Kovalov", new DateTime(1985, 11, 2), 29000m, 14.0, false, "Welder"),
                new Worker("Paul", "Oliynyk", new DateTime(1978, 6, 8), 36000m, 23.0, true, "Welder"),
                new Worker("Roman", "Rudenko", new DateTime(1991, 10, 29), 26000m, 9.0, true, "Locksmith"),
                new Worker("Vitalii", "Boiko", new DateTime(1983, 12, 17), 31000m, 16.0, true, "Electrician"),
                new Worker("Artem", "Lysenko", new DateTime(1996, 2, 24), 25000m, 5.0, false, "Turner")
                }
            );
            var workerCount = company.Employees.OfType<Worker>().Count();
            Console.WriteLine($"Count worker company:{workerCount} ");
            decimal totalSalary = company.Employees.Sum(s => s.Salary);
            Console.WriteLine($"Total salary: {totalSalary}");
            var longest10WorkesExperience = company.Employees.OfType<Worker>().OrderByDescending(s => s.workExperience).Take(10).ToList();
            var youngestInTop10Experience = longest10WorkesExperience.Where(s=>s.HasHigherEducation==true).MaxBy(s => s.BirthDate);
            Console.WriteLine($"The youngest person with a higher education among the ten workers with the longest tenure:\n {youngestInTop10Experience}");
            var managers = company.Employees.OfType<Manager>();
            var youngestManager = managers.MaxBy(s=>s.BirthDate);
            var oldestManager = managers.MinBy(s=>s.BirthDate);
            Console.WriteLine($"youngest manager: {youngestManager}\nand\noldest manager{oldestManager}");
            var workersBornInOctoberGrouped = company.Employees.OfType<Worker>().Where(s => s.BirthDate.Month == 10).GroupBy(s=>s.ProfessionalFocus);
            Console.WriteLine("Career paths of workers born in October: ");
            foreach (var group in workersBornInOctoberGrouped) {
                Console.WriteLine($"professional focus: {group.Key}");
                foreach (var worker in group) {
                    Console.WriteLine(worker);
                }
            
            }
            var allVolodymyresInCompany=company.Employees.Where(s=>s.FirstName == "Volodymyr").ToList();
            var youngestVolodymyr = allVolodymyresInCompany.MaxBy(s => s.BirthDate);
            if (youngestVolodymyr != null) {
                decimal bonus = youngestVolodymyr.Salary / 3;
                Console.WriteLine("The youngest Volodymyr to receive the award: ");
                Console.WriteLine($"Congratulations, {youngestVolodymyr.FirstName} {youngestVolodymyr.LastName}!");
                Console.WriteLine($"You have been awarded a bonus equal to 1/3 of your base salary: ${bonus:F2}");
            }
        }
    }
}
