using System;

namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] vect = new Aluno[10];
            vect[1] = new Aluno("Marco Antonio", "marco@gmail.com");
            vect[5] = new Aluno("Maria Green", "maria@gmail.com");
            vect[8] = new Aluno("Alex Grey", "alex@gmail.com");
            for (int i = 0;i<10;i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine("Quarto "+i+"; Aluno " +vect[i].Nome+"; Email "+vect[i].Email);
                }
            }
        }
    }
}
