using System;

namespace ConditionalsExeTwo {
    class Program {
        static void Main(string[] args) {
            //Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.WriteLine("Enter two numbers:");
            string a = Console.ReadLine();

            string b = Console.ReadLine();
            int firstNum = Int32.Parse(a);
            int secondNum = Int32.Parse(b);
            if (firstNum > secondNum) {
                Console.WriteLine(firstNum + " is greater");
            } else {
                Console.WriteLine(secondNum + " is greater");
            }

        }
    }
}
