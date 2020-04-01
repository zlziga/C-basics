using System;

namespace typeConversion {
    class Program {
        static void Main(string[] args) {
			try {
                var i = 550;
                byte b = Convert.ToByte(i);
			} catch (Exception) {
                Console.WriteLine("The number could not be converted!");
			}
        }
    }
}
