using System;
using System.Collections.Generic;
using System.Text;
using DomainPessoa.Entities;

namespace DomainPessoa.Repository
{
    public class PessoRepository : IPessoaRepository
    {
        //Transforma uma lista de Pessoa em uma lista de CheckedPessoa
        public List<CheckedPessoa> GetCheckedPessoas(List<Pessoa> pessoas)
        {
            List<CheckedPessoa> checkedPessoas = new List<CheckedPessoa>();

            foreach(Pessoa p in pessoas)
            {
                CheckedPessoa checkedPessoa = new CheckedPessoa();
                checkedPessoa.Id = p.Id;
                checkedPessoa.PrimeiroNome = p.PrimeiroNome;
                checkedPessoa.SegundoNome = p.SegundoNome;
                checkedPessoa.Cpf = p.Cpf;

                checkedPessoas.Add(checkedPessoa);
            }

            return checkedPessoas;
        }

        //Retorna uma lista de pessoas
        public List<Pessoa> GetPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa(new Guid(), "Luciana", "Agatha Rosângela Santos", "463.137.219-26"));
            pessoas.Add(new Pessoa(new Guid(), "Gabriela", "Luzia da Cunha", "344.156.530-49"));
            pessoas.Add(new Pessoa(new Guid(), "Henry", "Leandro Vinicius Nogueira", "084.394.931-77"));
            pessoas.Add(new Pessoa(new Guid(), "Sueli", "Antônia Vieira", "448.368.586-40"));

            pessoas.Add(new Pessoa(new Guid(), "Raimundo", "Igor Diego Ribeiro", "937.431.274-31"));
            pessoas.Add(new Pessoa(new Guid(), "Fábio", "Antonio Igor Mendes", "403.074.153-33"));
            pessoas.Add(new Pessoa(new Guid(), "Tomás", "Ryan Antonio Gomes", "777.571.304-68"));
            pessoas.Add(new Pessoa(new Guid(), "Larissa", "Rafaela Mirella Sales", "207.668.056-03"));

            return pessoas;
        }

        public List<Pessoa> RemovePessoas(List<Pessoa> pessoas)
        {
            while(pessoas.Count > 0)
            {
                pessoas.RemoveAt(0);
            }

            return pessoas;
        }

        //Transforma uma lista de CheckedPessoa em uma lista de Pessoa
        public List<Pessoa> SetListPessoa(List<CheckedPessoa> pessoaSelected)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            foreach(CheckedPessoa c in pessoaSelected)
            {
                Pessoa pessoa = new Pessoa();
                pessoa = c;
                pessoas.Add(pessoa);
            }

            return pessoas;
        }
    }
}
