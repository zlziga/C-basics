using EO.Internal;
using System;

namespace Stopwatch {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("::::: Stopwatch console application :::::");

            var stopWatch = new Stopwatch();

            while (true) {
                Console.WriteLine("Press 'Y' to start the Stopwatch, 'N' to stop or 'Q' to qutit");
                switch (Console.ReadLine()) {
                    case "y":
                        Console.WriteLine("Start");
                        stopWatch.Start();
                        break;
                    case "n":
                        Console.WriteLine("Stop");
                        Console.WriteLine(stopWatch.Stop().ToString("c"));

                        break;
                    case "q":
                        return;

                }
            }
        }
    }
}
