using System;

namespace FuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            String original = "abcde FGHIJ ABC abc DEFG      ";
            String s1 = original.ToUpper();
            String s2 = original.ToLower();
            String s3 = original.Trim();


            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            String s4 = original.Substring(3);
            String s5 = original.Substring(3,5);
            String s6 = original.Replace('a','x');
            String s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            String* p1 = original;
            Console.WriteLine("Original: -"+original+"-");
            Console.WriteLine("ToUpper: -"+s1+"-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim :-" + s3 + "-");
            Console.WriteLine("IndexOf ('bc') :" + n1);
            Console.WriteLine("LastIndexOf('bc') :" + n2);
            Console.WriteLine("substring(3) :" + s4);
            Console.WriteLine("substring(3,5) :" + s5);
            Console.WriteLine("Replace('a','x'): " + s6);
            Console.WriteLine("Replace('abc', 'xy'):" + s7);
            Console.WriteLine("IsNullOrEmpty(original): " + b1);
            Console.WriteLine("IsNullOrWhiteSpace(original): " + b2);
            Console.WriteLine("===========================================================");
            


        }
    }
}
