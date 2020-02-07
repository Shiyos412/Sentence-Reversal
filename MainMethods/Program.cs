using System;
using ReversalTest;

namespace MainMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello, Michael!";
            Console.WriteLine(input);
            ReverseSentence mySent = new ReverseSentence();
            string output = mySent.ReverseSent(input);
            Console.WriteLine(output);
        }
    }
}
