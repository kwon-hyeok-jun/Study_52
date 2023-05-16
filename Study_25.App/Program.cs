using System;

namespace Study_52.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Study_52.Creator.GetName());

            Console.WriteLine(Study_52.Math.Abs(-1234));

            Console.WriteLine("안녕하세요.".CutStringUnicode(6));
        }
    }
}