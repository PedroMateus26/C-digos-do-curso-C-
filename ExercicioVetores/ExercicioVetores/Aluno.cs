using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVetores
{
    class Aluno
    {
        public String Nome { get; set; }
        public String Email { get; set; }


        public Aluno(String nome, String email)
        {
            this.Nome = nome;
            this.Email = email;
        }

    }
}
