using System;
using CX.Framework.Helper;

namespace CX.Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Console.ReadKey();

            var log = new NLogAdapter();
            Log.SetCore(log);

            Log.Debug();
        }
    }
}
