using lb1_3kurs2.Model;

namespace lb1_3kurs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Client> request = new List<Client>() {
              new Client("ford",3),
              new Client("lolo",2),
              new Client("Artem",1),
              new Client("Track",2),
               new Client("Stalker",3)
            };
            request = request.OrderByDescending(c=>c.priority).ToList();
            Queue<Client> queueRequest = new Queue<Client>();
            List<PrintHistory> listpPrintHistory = new List<PrintHistory>();
            foreach (Client client in request) {
                queueRequest.Enqueue(client);
            }
            while (queueRequest.Count > 0) {
               var person= queueRequest.Dequeue();
               PrintHistory printHistory = new PrintHistory(person.name,DateTime.Now);
               listpPrintHistory.Add(printHistory);
            }
            foreach (PrintHistory his in listpPrintHistory) {
                Console.WriteLine(his);
            }
            using (StreamWriter str = new StreamWriter("historyPrint.txt"))
            {
                foreach (PrintHistory his in listpPrintHistory) { 
                str.WriteLine(his);
                }
            }
        }
    }
}
