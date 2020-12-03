using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(3000); //wait until server is up

            try
            {
                Console.WriteLine("trying to connect");

                var connection = new HubConnectionBuilder()
                    .WithUrl("https://localhost:5001/players")
                    .Build();

                connection.Closed += exception =>
                {
                    Console.WriteLine(exception);
                    return Task.CompletedTask;
                };

                await connection.StartAsync();

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }

    }
}
