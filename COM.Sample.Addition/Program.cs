using COM.Server.Addition;
using System;
using System.Runtime.InteropServices;

namespace COM.Sample.Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Activation.Server();

            var result = server.Add(1,2);
            Console.WriteLine($"Total sum = {result}");
        }
    }

    namespace Activation
    {
        [ComImport]
        [CoClass(typeof(ServerClass))]
        [Guid("BA9AC84B-C7FC-41CF-8B2F-1764EB773D4B")]
        internal interface Server : IServer
        {
        }

        [ComImport]
        [Guid("DB1797F5-7198-4411-8563-D05F4E904956")]
        internal class ServerClass
        {
        }
    }
}
