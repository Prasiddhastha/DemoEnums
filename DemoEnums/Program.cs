using System;
namespace DemoEnums
{   
    //enum
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express=3

    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.RegularAirMail;
            Console.WriteLine((int)method);//numeric value of that enum by casting to integer

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);//converting integer to shipping method

            Console.WriteLine(method.ToString());//convert enum to string

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);//string to enum

        }
    }
}
