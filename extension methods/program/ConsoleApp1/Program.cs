using System;

namespace Extension
{

    class Program
    {
        static void Main(string[] args)
        {

            string post = "This is an string long long long long long long string";
            var shortendPost = post.Shorten(5);
            Console.WriteLine(shortendPost);

        }
    }
}

