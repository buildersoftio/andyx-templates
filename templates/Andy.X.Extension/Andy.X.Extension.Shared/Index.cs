using Andy.X.Extension.Shared.Providers;
using System;

namespace Andy.X.Extension.Shared
{
    public static class RequestRunner
    {
        public static bool Run(Provider provider, object content)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Provider {provider}");


            // returning true, will acknowledge the request to distributed platform
            return true;
        }
    }
}
