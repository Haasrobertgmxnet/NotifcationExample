using System;
using SampleDll;

namespace NotificationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sC = new SampleClass();
            sC.Number = 1;
            sC.Number = 2;
            sC.Number =  sC.Number + 1;
            Console.WriteLine("Hello World!");
        }
    }
}