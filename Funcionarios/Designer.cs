using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
  public class Designer : Funcionario
  {
    public Designer(string nome, string cpf) : base(nome, cpf, 3000)
    {

    }

    public override double getBonificacao()
    {
      return Salario * 0.17;
    }

    public override void AumentarSalario()
    {
      this.Salario *= 1.11;
    }
  }
}