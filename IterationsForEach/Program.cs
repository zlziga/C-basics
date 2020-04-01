using System;

namespace IterationsForEach {
    class Program {
        static void Main(string[] args) {
            var name = "John Smith";
            var numbers = new int[] { 1, 2, 3, 4 };
            //forLoop(name);
            //forEach(name, numbers);
            //whileLoop();
            //Console.WriteLine();
            anotherWhileLoop();



            static void forLoop(string name) {
                for (var i = 0; i < name.Length; i++) {
                    Console.WriteLine(name[i]);
                }
            }


            static void forEach(string name, int[] numbers) {
                Console.WriteLine();
                foreach (var character in name) {
                    Console.WriteLine(character);
                }
                Console.WriteLine();
                foreach (var number in numbers) {
                    Console.WriteLine(number);
                }
            }

            static void whileLoop() {
                var i = 0;
                while (i <= 10) {
                    if (i % 2 == 0) {
                        Console.WriteLine(i);
                    }
                    i++;
                }
            }
            static void anotherWhileLoop() {
                while (true) {
                    Console.Write("Type your name:");
                    var input = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(input)) {
                        Console.WriteLine("@Echo:{0}", input);
                        continue;
                    }
                    break;
                }
            }

        }
    }
}
