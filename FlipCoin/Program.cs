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
            int head = 0, tail = 0;
            while (head < 21 || tail < 21)
            {
                if (random.Next(0, 2) == 0)
                    head++;
                else
                    tail++;
            }
            if (head > tail)
                Console.WriteLine("Head Won by " + (head - tail));
            else if (tail > head)
                Console.WriteLine("Tail Won by " + (tail - head));
            else
                Console.WriteLine("Its a Tie");
        }
    }
}