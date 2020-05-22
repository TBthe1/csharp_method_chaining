using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Method_chaining
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            var listWords = new List<string>(new string[] { "this", "is", "a", "sample", "list", "of", "words", "that", "demonstrates", "some", "code" });

            listWords = listWords.Where(w => w.Length >= 3).ToList();
            listWords = listWords.Where(word => word.ToLower().Contains("c")).ToList();

            Console.WriteLine(String.Join(", ", listWords.ToArray())); // Print array to console, separating each word with a comma
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
