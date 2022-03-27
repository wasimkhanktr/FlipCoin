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
            if (random.Next(0, 2) == 0)
                Console.WriteLine("Head");
            else
                Console.WriteLine("Tail");
        }
    }
}