using System;

namespace HoraLocalEGMT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DateTime d1 = new DateTime(2019,03,31,20,31,45,DateTimeKind.Local);
            DateTime d2 = new DateTime(2019, 03, 31, 20, 31, 45, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2019, 03, 31, 20, 31, 45);
            Console.WriteLine("d1: "+d1);
            Console.WriteLine("d1.kind: " + d1.Kind);
            Console.WriteLine("d1.toLocal: " + d1.ToLocalTime());
            Console.WriteLine("d1.UTC: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
            */

            DateTime d1 = DateTime.Parse("2019-03-31 20:42:12");
            DateTime d2 = DateTime.Parse("2019-03-31T20:42:12Z");
            /* Console.WriteLine(d1);
             Console.WriteLine(d2);
             */
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));


        }
    }
}
