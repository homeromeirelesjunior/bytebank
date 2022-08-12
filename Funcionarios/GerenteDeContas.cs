using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bytebank.SistemasInterno;

namespace Bytebank.Funcionarios
{
  public class GerenteDeContas : Autenticavel
  {
    public GerenteDeContas(string nome, string cpf, double salario) : base(nome, cpf, salario)
    {

    }

    public override double getBonificacao()
    {
      return Salario * 0.25;
    }

    public override void AumentarSalario()
    {
      Salario = this.Salario * 1.25;
    }
  }
}