using System;

namespace creview
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyMethod();
            
            int[] myArray = new int[5] {3, 4, 5, 6, 7};
            myArray[0] = 2;     //update value by index
            //Console.WriteLine( myArray[0] );

            for ( int i = 0; i < 5; i++) {
                Console.WriteLine( "Array Index:{0} | Array Value:{1}" , i, myArray[i] );
            }

            Console.WriteLine();

            int n = 0;
            while ( n < 5) {
                Console.WriteLine( "Array Index:{0} | Array Value:{1}" , n, myArray[n] );
                n += 2;
            }

            Console.WriteLine();

            foreach ( int num in myArray ) {
                Console.WriteLine( "Current Foreach Value is: {0}" , num);
            }

            Console.WriteLine( "Please enter your name: ");
            string myName = Console.ReadLine();
            Console.WriteLine( "Thank you, {0}!", myName);
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
