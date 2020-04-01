using System;
using System.Collections.Generic;
using System.Text;

namespace Conditionals {
    class ExeOne {
        /*Write a program and ask the user to enter a number. The number should be between 1 to 10. 
         * If the user enters a valid number,
         * display "Valid" on the console. Otherwise, display "Invalid".
         * (This logic is used a lot in applications where values entered into input boxes need to be validated.)*/
        public static void main(String[] args) {
            Console.WriteLine("Enter a number between 1 to 10:");
            string num = Console.ReadLine();

            try {
                int number = Int32.Parse(num);
                Console.WriteLine("Entered:"+number);
                if(number>=1 && number <= 10) {
                    Console.WriteLine("Your arguments are valid.");
                }
            } catch (FormatException) {
                Console.WriteLine("Undefined number:" + num);
                Console.WriteLine("Arguments invalid.");
            }
            
            


        }
    }
}
