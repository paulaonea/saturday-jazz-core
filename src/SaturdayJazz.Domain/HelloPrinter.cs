using System;
using Serilog;

namespace SaturdayJazz.Domain
{
    public static class HelloPrinter
    {
        public static void Print()
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

            Log.Information("Hello World");
        }
    }
}
