using System;
namespace ReversalTest
{
    class EmptyClass
    {
        public static void Main(String[] args)
        {
            string input = "Hello, Michael";
            Console.WriteLine("hello");
            ReverseSentence mySent = new ReverseSentence();
            string output = mySent.ReverseSent(input);
            Console.WriteLine(output);
        }
    }
}
