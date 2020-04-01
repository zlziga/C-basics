using System;
using System.Collections.Generic;

namespace ArrayListExercises {
    class Program {
        static void Main(string[] args) {
            //ExerciseOne();
            //ExerciseTwo();
            //ExerciseThree();
            //ExerciseFour();
            ExerciseFive();

            static void ExerciseOne() {
                //When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
                //If no one likes your post, it doesn't display anything.
                //If only one person likes your post, it displays: [Friend's Name] likes your post.
                //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
                //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
                //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
                //Depending on the number of names provided, display a message based on the above pattern.


                var names = new List<string>();
                while (true) {
                    Console.WriteLine("Enter a name:");
                    var name = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(name)) {
                        break;
                    } else {
                        names.Add(name);
                    }
                }

                if (names.Count > 2) {
                    Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Count - 2) + " others liked your post.");
                } else if (names.Count == 2) {
                    Console.WriteLine(names[0] + " and " + names[1] + " liked your post.");
                } else if (names.Count == 1) {
                    Console.WriteLine(names[0] + " liked your post.");
                }

            }
            static void ExerciseTwo() {
                //Write a program and ask the user to enter their name.
                //Use an array to reverse the name and then store the result in a new string.
                //Display the reversed name on the console.
                Console.WriteLine("Enter name to reverse it:");
                var name = Console.ReadLine();

                var array = name.ToCharArray();

                //for (var i = name.Length; i > 0; i--) {
                //    array[name.Length-1] = name[i - 1];
                //}

                Array.Reverse(array);
                var revName = new string(array);
                Console.WriteLine(revName);
            }
            static void ExerciseThree() {

                //Write a program and ask the user to enter 5 numbers.
                //If a number has been previously entered, display an error message and ask the user to re-try.
                //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

                var numbers = new List<int>();
                while (numbers.Count < 5) {
                    Console.WriteLine("Enter a number:");
                    var number = Convert.ToInt32(Console.ReadLine());
                    if (numbers.Contains(number)) {
                        Console.WriteLine("Already contains number " + number);
                        continue;
                    }
                    numbers.Add(number);
                }
                numbers.Sort();
                foreach (var number in numbers) {
                    Console.Write(number);
                }
            }
            static void ExerciseFour() {
                // Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
                // include duplicates. Display the unique numbers that the user has entered.
                var numbers = new List<int>();

                while (true) {
                    Console.WriteLine("Enter a number:");
                    var input = Console.ReadLine();
                    if (input.ToLower() == "quit") {
                        break;
                    }
                    numbers.Add(Convert.ToInt32(input));
                }
                var exclusiveNumbers = new List<int>();
                foreach (var number in numbers) {
                    if (!exclusiveNumbers.Contains(number)) {
                        exclusiveNumbers.Add(number);
                    }
                }
                Console.WriteLine("Exclusive numbers:");
                foreach (var number in exclusiveNumbers) {
                    Console.Write(number);
                }
            }
            static void ExerciseFive() {
                /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
                /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
                /// otherwise, display the 3 smallest numbers in the list.
                /// 

                string[] elements;//array of strings
                while (true) {
                    Console.WriteLine("Write a list of comma seperated numbers:");
                    var input = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(input)) {
                        elements = input.Split(",");
                        if (elements.Length >= 5) {
                            break;
                        }
                    }
                    Console.WriteLine("-1");
                }
                var numbers = new List<int>();
                foreach (var number in elements) {
                    numbers.Add(Convert.ToInt32(number));
                }

                numbers.Sort();

                var firstThree = new int[3];
                for (int i = 0; i < 3; i++) {
                    firstThree[i] = numbers[i];
                }
                foreach (var num in firstThree) {
                    Console.Write(num);
                }





            }
        }
    }
}

