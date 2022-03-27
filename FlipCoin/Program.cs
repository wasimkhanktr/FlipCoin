using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int no_of_times = Convert.ToInt32(Console.ReadLine());
            int head = 0, tail = 0;
            while (no_of_times > 0)
            {
                if (random.Next(0, 2) == 0)
                    head++;
                else
                    tail++;
                no_of_times--;
            }
            Console.WriteLine("No of times head occured " + head);
            Console.WriteLine("No of times tail occured " + tail);
            Console.ReadLine();
        }
    }
}