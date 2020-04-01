using System;

namespace ConditionalsExeFour {
    class Program {
        static void Main(string[] args) {
            /*4- Your job is to write a program for a speed camera. 
             * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
             * Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
             * If the user enters a value less than the speed limit, program should display Ok on the console. 
             * If the value is above the speed limit, the program should calculate the number of demerit points. 
             * 
             * For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
             * If the number of demerit points is above 12, the program should display License Suspended.*/

            Console.WriteLine("First enter the speed limit, then enter the speed of the car:");
            var limit = Convert.ToInt32(Console.ReadLine());
            var speed = Convert.ToInt32(Console.ReadLine());


            if (limit > speed) {
                Console.WriteLine("OK");
            } else {
                const int kmPerDemeritPoints = 5;
                var demeritPoints = (speed - limit) / kmPerDemeritPoints;
                if (demeritPoints > 12) {
                    Console.WriteLine("License suspended");
                } else {
                    Console.WriteLine("Demerit points:" + demeritPoints);
                }
            }
        }
    }
}
