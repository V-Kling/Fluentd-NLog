using System.Diagnostics;
using System.Threading;
using System;
using Serilog;

namespace Monitoring
{
    class Program
    {
        static void Main(string[] args)
        {
        var log = new LoggerConfiguration().WriteTo.Fluentd("localhost",24224,"Monitoring.Code",Serilog.Events.LogEventLevel.Debug).CreateLogger();

log.Information($"That's it!");

            int counter = 0;

            while(true)
            {
                Thread.Sleep(2000);
                Console.WriteLine("Log information via Console: " + counter);
                Thread.Sleep(2000);
                log.Debug($"That's it!");
                counter++;
            }
        }
    }
}
