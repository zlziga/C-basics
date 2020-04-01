using System;

namespace Strings {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("New line like this \n");
            Console.WriteLine("Tab like this\tlalalala");
            Console.WriteLine("This is a backslah \\");
            Console.WriteLine("This is a single quotation mark \'");
            Console.WriteLine("This si a double quotation mark \"");

            var path = @"C:\";
            var firstName = "Ziga";
            var lastName = "Zlogar";
            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My full name is {0} {1}", firstName, lastName);
            var names = new string[3] { "Ziga", "Katja", "Matevz" };
            var formattedNames = string.Join(", ", names);


            var text = "Hey John!\nLook into the following path:\n\t c:\\folder1\\folder2\\\n\tc:\\folder3\\folder4\\";
            var textVerbatim =      @"Hey John!
                                    Look into the following path:
                                    c:\folder1\folder2\
                                    c:\folder3\folder4\";
            Console.WriteLine(text);
            Console.WriteLine(textVerbatim);

        }
    }
}
