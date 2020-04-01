using System;

namespace Inheritance {
    public class PresentationObject {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Coppy() {
            Console.WriteLine("Coppied to clipboard");
        }

        public void Duplicate() {
            Console.WriteLine("Duplicated");
        }
    }
}
