using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minimum value");
            int min=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter maximum value");
            int max= Convert.ToInt32(Console.ReadLine());
            bool flag;
            List<int> l = new List<int>();
            for(int i = min; i <= max; i++)
            {
                flag = true;
                for(int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true && i != 1)
                {
                    l.Add(i);
                }
            }
            Console.WriteLine("The prime numbers between {0} and {1} are:", min, max);
            foreach(int k in l)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Hello From Nandini R");
        }
    }
}
