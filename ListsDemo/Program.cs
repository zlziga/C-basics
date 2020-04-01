using System;
using System.Collections.Generic;

namespace ListsDemo {
    class Program {
        static void Main(string[] args) {
            //We create a list when we dont know how many objects we are going to store!!
            var numbers = new List<int>() { 1, 2, 3, 4 }; //collections.generic!!

            numbers.AddRange(new int[3] { 5, 6, 7 });

            numbers.Add(8);
            foreach (var number in numbers) {
                Console.Write(number);
            }
            Console.WriteLine("\nindex of 1 is:" + numbers.IndexOf(1));
            numbers.Add(1);
            foreach (var number in numbers) {
                Console.Write(number);
            }
            Console.WriteLine("\nindex of 1 is:" + numbers.IndexOf(1));
            Console.WriteLine("\nlast index of 1 is:" + numbers.LastIndexOf(1));
            Console.WriteLine("\n");
            foreach (var number in numbers) {
                Console.Write(number);
            }
            Console.WriteLine("\nCount numbers:" + numbers.Count);

            for (var i = 0; i < numbers.Count; i++) {
                if (numbers[i] == 1) {
                    numbers.Remove(numbers[i]);
                }

            }
            foreach (var number in numbers) {
                Console.Write(number);
            }
        }
    }
}
