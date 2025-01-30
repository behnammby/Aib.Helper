using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HashidsNet;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Behnammby.Common
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CreateHostBuilder(args).Build().Run();
            var hashids = new Hashids("TaeM6jv_o78+OR4", 10);

            var decode = hashids.Decode("bO07BXV8q2");

            System.Console.WriteLine($"COUNT {decode.Count()}");

        }

        // public static IHostBuilder CreateHostBuilder(string[] args) =>
        //     Host.CreateDefaultBuilder(args)
        //         .ConfigureWebHostDefaults(webBuilder =>
        //         {
        //             webBuilder.UseStartup<Startup>();
        //         });
    }
}
