using System;
using System.Linq;

namespace IntroduçãoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6};
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Execute the query
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}
