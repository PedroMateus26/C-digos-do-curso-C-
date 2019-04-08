using System;
using StringBuilderExemplo.Entities;

namespace StringBuilderExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Comments c1 = new Comments("Have a nice trip!");
            Comments c2 = new Comments("Wow that's awesome!");
            
            Post p1 = new Post(DateTime.Parse("06/21/2018 13:05:04"), "Traveling to New Zealand", "I'm going to visit this wonderful country",12);


            p1.AddComments(c1);
            p1.AddComments(c2);

            Console.WriteLine(p1);
            
        }
    }
}
