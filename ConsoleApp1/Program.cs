using System;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var context = new LlamaContext();
            context.Database.Migrate();


            Console.WriteLine("DONE");
            Console.ReadLine();

        }
    }
}
