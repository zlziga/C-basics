using System;

namespace ReferenceTypesValueTypes {
    partial class Program {
        static void Main(string[] args) {
            var a = 10;
            var b = a;
            b++;



            Console.WriteLine(String.Format("The value of a: {0} and b:{1}", a, b));

            var arr1 = new int[3] { 1, 2, 3 };
            var arr2 = arr1;
            arr2[0] = 0;
            Console.WriteLine(String.Format("arr1[0]:{0} and arr2[0]:{1}", arr1[0], arr2[0]));
            Console.WriteLine();
            int number = 1;
            Increment(number);
            Console.WriteLine(number);//prints 1

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);//prints 30

            static void Increment(int number) {
                number += 10;
            }
            static void MakeOld(Person person) {
                person.Age += 10;
            }
        }
    }
}
