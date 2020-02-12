using System;

namespace creview
{
    class Program
    {
        static void Main(string[] args)
        {
            int x =35;
            Console.WriteLine("Hello Martin!" + x);

            if (x < 30) {
                Console.WriteLine("x is less than thirty!");

            } else if (x == 30) {
                Console.WriteLine("x is thirty!");
            } else {
                Console.WriteLine("x is greater than Thirty!");
            }
        }
    }
}
