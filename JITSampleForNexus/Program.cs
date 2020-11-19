using ClassLibrary1;
using System;

namespace JITSampleForNexus
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cl = new Class1();

            cl.SurpressJit(); //set bp here
            Console.WriteLine("Hello World!");
        }
    }
}
