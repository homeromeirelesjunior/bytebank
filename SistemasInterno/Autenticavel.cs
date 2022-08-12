using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bytebank.Funcionarios;

namespace Bytebank.SistemasInterno
{
  public abstract class Autenticavel : Funcionario
  {
    public Autenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario)
    {

    }

    public string Login { get; set; }
    public string Senha { get; set; }

    public bool Autenticar(string login, string senha)
    {
      return (Senha == senha && Login == login);
    }
  }
}