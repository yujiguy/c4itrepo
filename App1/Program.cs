using System;
using System.Collections.Generic;

namespace App1
{
    internal class Program
    {
        public static object Command { get; private set; }

        static void Main(string[] args)
        {
            string word = "c4it";
            string workers = "worker1";
            int workers1 = 5;
            Console.WriteLine(word,workers,workers1);
            Console.ReadLine();
           

        }
    }
}