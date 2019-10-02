using DomainPessoa.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainPessoa.Repository
{
    public interface IPessoaRepository
    {
        List<Pessoa> GetPessoas();
        List<CheckedPessoa> GetCheckedPessoas(List<Pessoa> pessoas);
        List<Pessoa> SetListPessoa(List<CheckedPessoa> pessoaSelected);
        List<Pessoa> RemovePessoas(List<Pessoa> pessoas);
    }
}
