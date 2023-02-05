using System;
using System.Reflection.Metadata.Ecma335;

namespace Lambda
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));

            // args => expressuion 
            // number => number * number
            // fist int for data type 2nd int for return type
            Func<int, int> square = number => number*number;
            
            Console.WriteLine(square(7));




        }

        static int Square(int number)
        {
            return number * number;
        }


}

    
}

