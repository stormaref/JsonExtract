using System;
using System.IO;
using System.Text.Json;
using test.Models;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scores");
            Welcome welcome = new Welcome();


            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            var jsonString = File.ReadAllText("test.json");
            Welcome jsonModel = JsonSerializer.Deserialize<Welcome>(jsonString, options);

            var list = jsonModel.End.Select(e=>e.Score).ToList<int>();
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
