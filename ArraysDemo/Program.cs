using System;

namespace ArraysDemo {
    class Program {
        static void Main(string[] args) {

            //1d
            var numbers = new[] { 3, 6, 2, 8, 9 };

            Console.WriteLine(numbers.Length);
            //indexOf()
            Console.WriteLine("Position of value 9 is: " + Array.IndexOf(numbers, 8));
            //Clear()
            Array.Clear(numbers, 1, 3);
            Console.WriteLine("\n\nEffect of: Array.Clear(array, 1, 3);");
            foreach (var num in numbers) {
                Console.Write(num);
            }

            //Coppy()
            Console.WriteLine("\n\nEffect of Array.Coppy(numbers, numberCoppy, 2):");
            var numberCoppy = new int[3];
            Array.Copy(numbers, numberCoppy, 2);
            foreach (var num in numberCoppy) {
                Console.Write(num);
            }

            //Sort()
            Console.WriteLine("\n\n Effect of Array.Sort(numberCoppy);");
            Array.Sort(numberCoppy);
            foreach (var num in numberCoppy) {
                Console.Write(num);
            }

            //Reverse()
            Console.WriteLine("\n\n Effect of Array.Reverse(numberCoppy):");
            Array.Reverse(numberCoppy);
            foreach(var num in numberCoppy) {
                Console.Write(num);
            }



            //rectangular array
            var matrix = new int[3, 5] {
                {1,3,4,1,7},
                {6,2,7,9,3},
                {2,1,5,2,9}
            };
            var element = matrix[0, 0];


            //jagged array
            var array = new int[3][];

            array[0] = new int[4];
            array[1] = new int[6];
            array[2] = new int[3];

            array[0][0] = 1;

        }
    }
}
