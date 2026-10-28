using System;
using EventHub.Data; 

namespace EFCore_AssOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EventHubDbContext())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}