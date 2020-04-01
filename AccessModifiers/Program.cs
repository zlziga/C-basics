using System;

namespace AccessModifiers {
    public class Customer {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Promote() {
            var rating = CalculateRating();
            if (rating == -1) {
                Console.WriteLine("Promoted to level one?");
            } else { 
                Console.WriteLine("promoted to level 2");
            }
        }
        public int CalculateRating() {
            return -1;
        }
    }
    class Program {
        static void Main(string[] args) {
            var Customer = new Customer();
        }
    }
}
