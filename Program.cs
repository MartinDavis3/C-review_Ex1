using System;

namespace creview
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod();
        }
        
        static void MyMethod()
        {
            int x = 35;
            Console.WriteLine("Hello Martin!" + x);

            if (x < 30) {
                Console.WriteLine("x is less than thirty!");

            } else if (x == 30) {
                Console.WriteLine("x is thirty!");
            } else {
                Console.WriteLine("x is greater than Thirty!");
            }
            int a = 2;
            switch ( a ) {
                case 1:
                    Console.WriteLine( "Value is 1!" );
                    break;
                case 2:
                    Console.WriteLine( "Value is 2!" );
                    break;
                case 3:
                    Console.WriteLine( "Value is 3!" );
                    break;
                default:
                    Console.WriteLine( "uh oh, it is another value!" );
                    break;
            }
        }
    }
}
