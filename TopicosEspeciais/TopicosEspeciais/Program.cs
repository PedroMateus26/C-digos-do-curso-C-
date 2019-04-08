using System;

namespace TopicosEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var x = 10;
             var y = 20.0;
             var z = "Maria";

             Console.WriteLine(x);
             Console.WriteLine(y);
             Console.WriteLine(z);
             */
            int x = int.Parse(Console.ReadLine());
            String day;
            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thusday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "The value is not valid";
                    break;

            }
            Console.WriteLine(day);
        }
    }
}
