using Classes.Math;
using System;

namespace Classes {
    class Program {
        static void Main(string[] args) {
            var Ziga = new Person();
            Ziga.firstName = "Ziga";
            Ziga.lastName = "Zlogar";
            Ziga.Introduce();

            var cal = new Calculator();
            var result = cal.Add(3, 4);
            Console.WriteLine(result);
        }
    }
}
