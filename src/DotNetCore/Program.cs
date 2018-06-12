namespace Herdo.StrongTypes.DotNetCore
{
    using System;
    using DotNetStandard;

    internal static class Program
    {
        internal static void Main()
        {
            var ci = new CustomerInfo();
            Console.WriteLine(ci.GetMembershipDetails());
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
