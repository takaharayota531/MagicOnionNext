using MagicOnion.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace Sample.Server
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await MagicOnionHost.CreateDefaultBuilder()
                .UseMagicOnion()
                .RunConsoleAsync();
        }
    }
}