using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
  public class Desenvolvedor : Funcionario
  {
    public Desenvolvedor(string nome, string cpf) : base(nome, cpf, 3000)
    {

    }

    public override double getBonificacao()
    {
      return Salario * 0.1;
    }

    public override void AumentarSalario()
    {

    }


  }
}