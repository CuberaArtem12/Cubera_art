using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10.MethodDelegate
{
    public class ServiceNumber
    {
        public Predicate<int> PrimeNumber = (int number) =>
        {
            if (number < 2)
                return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        };
        public Predicate<int> ifNumberFinobachi = (int number) =>
        {
            int next = 1;
            int sum = 0;
            int curent = 0;
            while (curent <= number)
            {
                if (curent == number)
                    return true;
                sum = curent + next;
                curent = next;
                next = sum;
            }
            return false;
        };
    }
}
