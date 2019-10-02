using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DomainPessoa.Entities
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public string Cpf { get; set; }

        public Pessoa() { }

        public Pessoa(Guid i, string n, string nn, string c)
        {
            this.Id = i;
            this.PrimeiroNome = n;
            this.SegundoNome = nn;
            this.Cpf = c;
        }
    }
}
