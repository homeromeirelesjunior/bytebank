using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
  public class Auxiliar : Funcionario
  {
    public Auxiliar(string nome, string cpf) : base(nome, cpf, 2000)
    {

    }

    public override double getBonificacao()
    {
      return Salario * 0.2;
    }

    public override void AumentarSalario()
    {
      Salario = this.Salario * 1.1;
    }
  }
}