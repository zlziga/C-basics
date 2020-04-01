using System;

namespace Arrays {
    class Program {
        static void Main(string[] args) {
            var tab = new int[3];
            tab[0] = 1;

            for (int i = 0; i < 3; i++) {
                Console.WriteLine(tab[i]);
            }


            var flags = new bool[3];
            flags[0] = true;

            for (int i = 0; i < 3; i++) {
                Console.WriteLine(flags[i]);
            }
            
            var names = new string[3] { "Ziga", "Katja", "Matevz" };
            
            var list = string.Join(", ", names);
            Console.WriteLine(list+".");
        }
    }
}

