using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bytebank.Funcionarios;

namespace Bytebank.SistemasInterno
{
  public class SistemaInterno
  {
    public bool Logar(Autenticavel funcionario, string login, string senha)
    {
      bool usuarioAutenticado = funcionario.Autenticar(login, senha);

      if (usuarioAutenticado)
      {
        Console.WriteLine("Bem vindo ao sistema");
        return true;
      }
      else
      {
        Console.WriteLine("Senha incorreta");
        return false;
      }
    }
  }
}