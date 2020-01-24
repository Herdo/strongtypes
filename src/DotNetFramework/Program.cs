using System;
using Herdo.StrongTypes.DotNetStandard;

namespace Herdo.StrongTypes.DotNetFramework
{
    internal static class Program
    {
        internal static void Main()
        {
            var ci = new CustomerInfo();
            Console.WriteLine(ci.GetMembershipDetails());
            PrintNewtonsoftJsonSerializedObject(ci);
            PrintSystemTextJsonSerializedObject(ci);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void PrintNewtonsoftJsonSerializedObject(CustomerInfo ci)
        {
            var json1 = Newtonsoft.Json.JsonConvert.SerializeObject(ci, Newtonsoft.Json.Formatting.Indented);
            var deserialized = Newtonsoft.Json.JsonConvert.DeserializeObject<CustomerInfo>(json1);
            var json2 = Newtonsoft.Json.JsonConvert.SerializeObject(deserialized, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine("Newtonsoft.Json:");
            Console.WriteLine(json1);
            Console.WriteLine(json2);
        }

        private static void PrintSystemTextJsonSerializedObject(CustomerInfo ci)
        {
            var serializerOptions = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };
            var json1 = System.Text.Json.JsonSerializer.Serialize(ci, serializerOptions);
            var deserialized = System.Text.Json.JsonSerializer.Deserialize<CustomerInfo>(json1, serializerOptions);
            var json2 = System.Text.Json.JsonSerializer.Serialize(deserialized, serializerOptions);
            Console.WriteLine("System.Text.Json:");
            Console.WriteLine(json1);
            Console.WriteLine(json2);
        }
    }
}