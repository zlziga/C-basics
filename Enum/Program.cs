using System;

namespace Enum {

    public enum ShippingMethod {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program {
        static void Main(string[] args) {
            var method3 = ShippingMethod.Express;
            var methodId = 3;

            if (method3 == (ShippingMethod)methodId) {
                Console.WriteLine("The shipping method is " + (ShippingMethod)methodId + " or " + (int)method3 + " by shipping Id.");
            }

            Console.WriteLine(methodId.ToString());

            var methodName = "RegularAirMail";
            var methodNameId = (int)System.Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(methodNameId);
        }
    }
}
