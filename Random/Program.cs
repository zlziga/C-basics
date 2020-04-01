using System;

namespace Random {
    class Program {
        static void Main(string[] args) {
            var random = new System.Random();

            const int passwordLength = 10;

            var buffer = new char[passwordLength];
            
            for (int i = 0; i < passwordLength; i++) {
                //    Console.WriteLine(random.Next(1,10));
                buffer[i] = (char)('a' + random.Next(0, 26)); //or char 67, 122 (ascii)

            }
            var password = new string(buffer);

            Console.WriteLine(password);


        }
    }
}
