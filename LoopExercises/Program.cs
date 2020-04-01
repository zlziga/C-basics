using System;

namespace LoopExercises {
    class Program {
        static void Main(string[] args) {
            // ExerciseOne();
            //ExerciseTwo();
            //ExerciseThree();
            //ExerciseFour();
            ExerciseFive();
            static void ExerciseOne() {
                //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
                var count = 0;
                for (var i = 0; i < 100; i++) {
                    if ((i % 3) == 0) {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }

            static void ExerciseTwo() {
                //Write a program and continuously ask the user to enter a number or "ok" to exit. 
                //Calculate the sum of all the previously entered numbers and display it on the console.
                var sum = 0;
                while (true) {
                    Console.WriteLine("Enter a number or 'ok' to exit:");
                    var e = Console.ReadLine();
                    if (!e.Equals("ok")) {
                        var num = int.Parse(e);
                        sum += num;
                    } else {
                        break;
                    }
                    Console.WriteLine(sum);
                }
            }

            static void ExerciseThree() {
                //Write a program and ask the user to enter a number.Compute the factorial of the number and print it on the console. 
                //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

                int factorial;
                Console.WriteLine("Enter a number:");
                var num = Convert.ToInt32(Console.ReadLine());
                factorial = num;
                for (int i = num - 1; i > 0; i--) {
                    factorial *= i;

                }
                Console.WriteLine(factorial);

            }

            static void ExerciseFour() {
                //Write a program that picks a random number between 1 and 10.
                //Give the user 4 chances to guess the number.
                //If the user guesses the number, display 
                //“You won"; otherwise, display “You lost". 
                //(To make sure the program is behaving correctly, you can display the secret number on the console first.)
                var random = new Random();
                int number = random.Next(1, 11);
                Console.WriteLine("psst, its " + number);
                for (int i = 0; i < 4; i++) {
                    Console.WriteLine(i + 1 + ". Enter a number between 1 and 10");
                    var input = Convert.ToInt32(Console.ReadLine());
                    if (input == number) {
                        Console.WriteLine("You won!");
                        break;
                    }
                    if (i == 3) {
                        Console.WriteLine("You lost!");
                    }
                }
            }
            static void ExerciseFive() {
                //Write a program and ask the user to enter a series of numbers separated by comma. 
                //Find the maximum of the numbers and display it on the console. 
                //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
                Console.WriteLine("Enter a series of numbers seperated by a comma:");
                var input = Console.ReadLine();

                var numbers = input.Split(",");
                int max = Convert.ToInt32(numbers[0]);
                foreach (var number in numbers) {
                    var num = Convert.ToInt32(number);
                    if (num > max) {
                        max = num;
                    }
                }
                Console.WriteLine("Max is " + max);
            }
        }
    }
}
