using System;

namespace ConditionalsExeThree {
    class Program {
        static void Main(string[] args) {
            //Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.
            Console.WriteLine("Enter width then height");
            string w = Console.ReadLine();
            string h = Console.ReadLine();

            int width = int.Parse(w);
            int height = int.Parse(h);
            if (height > width) {
                Console.WriteLine("Its portrait");
            } else {
                Console.WriteLine("Its landscape");
            }
        }
    }
}
