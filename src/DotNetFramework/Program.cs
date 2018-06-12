namespace Herdo.StrongTypes.DotNetFramework
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            var ci = new CustomerInfo();
            Console.WriteLine(ci.GetMembershipDetails());
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}