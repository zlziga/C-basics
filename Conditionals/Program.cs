using System;

namespace Conditionals {
    class Program {
        static void Main(string[] args) {
            bool isGoldCustomer = false;
            float price = (isGoldCustomer) ? 15.99f : 25.99f;
            Console.WriteLine(price);


            var season = Season.Autnum;
            switch (season) {
                case Season.Autnum:
                case Season.Spring:
                    Console.WriteLine("The best time of the year!");
                    break;
                case Season.Summer:
                    Console.WriteLine("its summer");
                    break;
                case Season.Winter:
                    Console.WriteLine("its winter");
                    break;
                default:
                    Console.WriteLine("i dont understand this season???");
                    break;
            }
        }
    }
}
