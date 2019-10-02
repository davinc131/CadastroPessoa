using System;
using System.Collections.Generic;
using System.Text;
using DomainPessoa.Entities;
using DomainPessoa.Repository;

namespace DomainPessoa.Service
{
    public class ServicePessoa : IServicePessoa
    {
        private IPessoaRepository pessoaRepository;

        public ServicePessoa()
        {
            pessoaRepository = new PessoRepository();
        }

        public List<CheckedPessoa> GetCheckedPessoas(List<Pessoa> p)
        {
            return pessoaRepository.GetCheckedPessoas(p);
        }

        public List<Pessoa> GetPessoas()
        {
            return pessoaRepository.GetPessoas();
        }

        public List<Pessoa> RemovePessoas(List<Pessoa> pessoas)
        {
            return pessoaRepository.RemovePessoas(pessoas);
        }

        public List<Pessoa> SetListPessoa(List<CheckedPessoa> checkedPessoas)
        {
            return pessoaRepository.SetListPessoa(checkedPessoas);
        }
    }
}
