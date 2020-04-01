using System;

namespace simpleArraySum {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter the size of the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            var tab = new int[n];


            for (int i = 0; i < n; i++) {
                Console.WriteLine("Enter the value:");
                int j = Convert.ToInt32(Console.ReadLine());
                tab[i] = j;
            }
            Console.WriteLine("");
            var sum = 0;
            for (int i = 0; i < n; i++) {
                Console.Write(tab[i]);
                sum += tab[i];
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The sum of the array's elements is: " + sum);
        }
    }
}
