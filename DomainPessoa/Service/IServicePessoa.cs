using DomainPessoa.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainPessoa.Service
{
    public interface IServicePessoa
    {
        List<Pessoa> GetPessoas();
        List<CheckedPessoa> GetCheckedPessoas(List<Pessoa> p);
        List<Pessoa> SetListPessoa(List<CheckedPessoa> checkedPessoas);
        List<Pessoa> RemovePessoas(List<Pessoa> pessoas);
    }
}
