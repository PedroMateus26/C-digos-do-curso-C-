using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoEnumExercicio.Entities
{
    class Client
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public DateTime Date { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime date)
        {
            this.Name = name;
            this.Email = email;
            this.Date = date;
        }
    }
}
