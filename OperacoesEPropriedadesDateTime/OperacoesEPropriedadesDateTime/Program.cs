using System;

namespace OperacoesEPropriedadesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DateTime d = new DateTime(2019,03,31,19,47,50,321);
            Console.WriteLine(d);                                   //Imprime Padrão date time
            Console.WriteLine("Data: "+d.Date);                     //Imprimindo apenas a data
            Console.WriteLine("Horas: "+d.Hour);                    //Imprimindo apenas as horas
            Console.WriteLine("Dia da semana: " + d.DayOfWeek);     //Imprimindo apenas o dia da semana
            Console.WriteLine("Dia do ano: " + d.DayOfYear);        //Imprimindo apenas o dia do ano
            Console.WriteLine("Mês: " + d.Month);                   //Imprimindo apenas o mês
            Console.WriteLine("Tempo do dia: " + d.TimeOfDay);      //Imprimindo apenas o tempo do dia
            Console.WriteLine("Tipo: " + d.Kind);                   //Imprimindo apenas o tipo
            */

            /*DateTime d = new DateTime(2019, 03, 31, 19, 47, 50, 321);
            Console.WriteLine(d.ToLongDateString());                //Imprime mês, ano e dia
            Console.WriteLine(d.ToLongTimeString());                //Imprime hora de forma mais detalhada
            Console.WriteLine(d.ToShortDateString());               //Imprime data de forma mais curta
            Console.WriteLine(d.ToShortTimeString());               //Imprime hora de forma mais detalhada

            String s1 = d.ToString("dd/MM/yyyy HH:mm:ss");          //Imprime data e hora com mascara de formatação
            String s2 = d.ToString("dd/MM/yyyy HH:mm:ss.fff");      //Imprime data e hora com mascara de formatação mais milisegundos
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            */
            /*DateTime d = new DateTime(2019, 03, 31, 19, 47, 50, 321);
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            */
            DateTime d1 = new DateTime(2019,03,31);
            DateTime d2 = new DateTime(2019,04,11);
            TimeSpan t = d2.Subtract(d1);
            Console.WriteLine(t);

        }
    }
}
